using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.Entity.Core.Objects;

namespace ExamFinal
{
    public partial class perform_exam : Form
    {
        ExaminationSystemEntities1 ee = new ExaminationSystemEntities1();
        Exam exam;
        Cours course;
        Student ss;
        List<Question> quest=new List<Question>();
        Form1 f;
        public perform_exam(Student s,Form1 f)
        {
            InitializeComponent();
            ss = s;
            this.f = f;

        }

        private void perform_exam_Load(object sender, EventArgs e)
        {
            panel1.AutoScroll = true;

            var cources=ee.SelectCourses();
            foreach(var cource in cources)
            {
                comboBox1.Items.Add(cource.crs_Name);
            }
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                comboBox2.Items.Clear();
                string selected = comboBox1.SelectedItem.ToString();
                course = ee.Courses.Where(c => c.crs_Name == selected).Select(c => c).First();

                Exam ex = ee.Exams.Where(E => E.Course_id == course.crs_id).Select(eex => eex).First();
                int sel = (int)ee.count_Answer(ss.Std_id, ex.Exam_id).First();

                if (sel == 0)
                {
                    comboBox2.Items.Add(ex.Exam_data);
                }
            }catch(Exception ee)
            {
                MessageBox.Show("No Exam in this course");
            }
            

        }

        private void button1_Click(object sender, EventArgs e)
        {
            
            try
            {
                

                string E_content = comboBox2.SelectedItem.ToString();
                exam = ee.Exams.Where(ee => ee.Exam_data == E_content).Select(E => E).First();
               // quest=  ee.Questions.Where(q => q.Exam_id == exam.Exam_id).Select(E=>E).ToList();
               


                ObjectResult<ExamGenertator_multi_Result> objectResults = ee.ExamGenertator_multi(comboBox1.SelectedItem.ToString(), 6);
                ObjectResult<ExamGenertator_T_or_F_Result> objectResults1 = ee.ExamGenertator_T_or_F(comboBox1.SelectedItem.ToString(), 3);
                
                foreach (var v in objectResults)
                {
                    Question q1 = new Question();
                    q1.Ques_id = v.Ques_id;
                    q1.Question1 = v.Question;
                    q1.Ques_Answer = v.Ques_Answer;
                    q1.Type = v.Type;
                    q1.Exam_id = v.Exam_id;
                    q1.Degree = v.Degree;
                    quest.Add(q1);
                }

                foreach (var v1 in objectResults1)
                {
                    Question q1 = new Question();
                    q1.Ques_id = v1.Ques_id;
                    q1.Question1 = v1.Question;
                    q1.Ques_Answer = v1.Ques_Answer;
                    q1.Type = v1.Type;
                    q1.Exam_id = v1.Exam_id;
                    q1.Degree = v1.Degree;
                    quest.Add(q1);

                }


                int label_x = 40;
                int label_y = 40;
                int gb_x = 500;
                int gb_y = 40;
                foreach (var ii in quest)
                  {
                    var choices = ee.Choices.Where(c => c.Ques_id == ii.Ques_id).Select(c => c);
                    Label l = new Label();
                    l.Location = new Point(label_x, label_y );
                    l.Text = ii.Question1;
                    l.Size = new Size(400, 60);
                    l.Parent = panel1;
                    l.Show();
                    label_y += 70;

                    GroupBox gb = new GroupBox();
                    gb.Location = new Point(gb_x, gb_y);
                    gb.Text = "choices";
                    gb.Size = new Size(300,60);
                    gb.Parent = panel1;
                    gb.Show();
                    int y_r = 20;
                    foreach (var cc in choices)
                     {
                        
                    RadioButton rd = new RadioButton();
                    rd.Size = new Size(70, 21);
                    rd.Location = new Point(y_r, 20);
                    rd.Text = cc.Choice1;
                    rd.Parent = gb;
                    rd.Show();
                    y_r += 70;

                    }
                    gb_y += 70;

                    button1.Enabled = false;
                }
              
            }
            catch(Exception ee)
            {
                MessageBox.Show("select first");
            }

        }

        private void comboBox2_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {
          
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (comboBox2.Text == "")
            {
                MessageBox.Show("select first");
                return;
            }

            if(quest.Count==0)
            {
                MessageBox.Show("perform Exam first");
                return;
            }


            List<GroupBox> en =panel1.Controls.OfType<GroupBox>().Select(d=>d).ToList();
            int degree = 0;
            int total_res = 0;
           for(int i = 0; i < en.Count; i++)
            {
                List<RadioButton> rrd = en[i].Controls.OfType<RadioButton>().Select(R => R).ToList();
                for(int j = 0; j < rrd.Count; j++)
                {
                    if(rrd[j].Checked)
                    {
                        
                        if(quest[i].Ques_Answer== rrd[j].Text)
                        {
                            degree+= (int) quest[i].Degree;
                            ee.Exam_Answers(quest[i].Exam_id,quest[i].Ques_id,ss.Std_id, rrd[j].Text,(int) quest[i].Degree);
                        }
                    }
                }
                total_res +=(int) quest[i].Degree;

            }

            MessageBox.Show("your degree is : " + degree + "  of  " + total_res);
            Std_Crs st_c = new Std_Crs();
            st_c.crs_id = course.crs_id;
            st_c.std_id = ss.Std_id;
            st_c.grade = degree;
            st_c.Total_Deg = total_res;
            ee.Std_Crs.Add(st_c);
            ee.SaveChanges();
            Hide();
            f.Show();       
        }
    }
}
