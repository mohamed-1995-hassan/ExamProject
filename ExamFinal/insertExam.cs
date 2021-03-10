using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ExamFinal
{
    public partial class insertExam : Form
    {
        ExaminationSystemEntities1 exS = new ExaminationSystemEntities1();
        public insertExam()
        {
            InitializeComponent();
        }

        private void insertExam_Load(object sender, EventArgs e)
        {
            panel1.Hide();
            var courses = exS.SelectCourses();
            foreach (var course in courses)
            {
                comboBox1.Items.Add(course.crs_Name);
            }

        }

        private void button1_Click(object sender, EventArgs e)
        {
            int inc = int.Parse(label3.Text) + 1;
            label3.Text = inc.ToString();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            int inc = int.Parse(label3.Text) - 1;
            label3.Text = inc.ToString();

        }

        private void button5_Click(object sender, EventArgs e)
        {
            try
            {
                int select = 0;
                string duration = label3.Text + ":" + label6.Text + ":" + "00";
                string ExamName = textBox1.Text;
                var course = exS.Select_Course_By_Name(comboBox1.Text);
                foreach (var cours in course)
                {
                    select = cours.crs_id;
                }

                exS.InsertExam(ExamName, new TimeSpan(int.Parse(label3.Text), int.Parse(label6.Text), 00), select);




                if (exS.SaveChanges() == 0)
                {
                    panel1.Show();
                }



            }
            catch (Exception ee)
            {
                MessageBox.Show(ee.Message);
            }
        }

        private void button4_Click(object sender, EventArgs e)
        {
            int inc = int.Parse(label6.Text) + 1;
            label6.Text = inc.ToString();

        }

        private void button3_Click(object sender, EventArgs e)
        {
            int dec = int.Parse(label6.Text) - 1;
            label6.Text = dec.ToString();
        }

        private void button6_Click(object sender, EventArgs e)
        {
            try
            {

                int value = exS.Q_id().First().Value;
                exS.insertQuestion(value, textBox2.Text,
                    comboBox2.Text, comboBox3.Text, int.Parse(textBox4.Text)
                    );
                exS.SaveChanges();


                foreach (string s in listBox1.Items)
                {


                    int scal = exS.QQ_id().First().Value;
                    exS.InsertChoice(scal, s);
                    exS.SaveChanges();
                }
                MessageBox.Show("question added");
                clearData();

            }
            catch (Exception ee)
            {
                MessageBox.Show(ee.Message);
            }
        }

        private void button8_Click(object sender, EventArgs e)
        {
            string choice = textBox6.Text;
            listBox1.Items.Add(choice);
            comboBox2.Items.Add(choice);
            textBox6.Text = "";
        }

        private void clearData()
        {
            textBox2.Text = "";
            textBox4.Text = "";
            textBox6.Text = "";
            listBox1.Items.Clear();
            comboBox2.Items.Clear();
            comboBox2.SelectedItem = " ";
        }

        private void button7_Click(object sender, EventArgs e)
        {
            panel1.Hide();
            textBox1.Text = "";
            label3.Text = "0";
            label6.Text = "0";
        }
    }
}


