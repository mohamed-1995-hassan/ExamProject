using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ExamFinal.InstractorData
{
    public partial class ManageInstructor : Form
    {
        ExaminationSystemEntities1 db = new ExaminationSystemEntities1();

        public ManageInstructor()
        {
            InitializeComponent();
        }

        private void ManageInstructor_Load(object sender, EventArgs e)
        {
            fillData();
        }
        public void fillData()
        {
            clearFields();
            var ins = db.Instructors;
            foreach(var i in ins)
            {
                insCombo.Items.Add(i.Ins_id + "-"+i.Fname + " " + i.Lname);
                if(i.Manger == null)
                {
                    mangCombo.Items.Add(i.Ins_id + "-" + i.Fname + " " + i.Lname);
                }
            }
            var deps = db.Departments;
            foreach(var d in deps)
            {
                depCombo.Items.Add(d.Dept_id + "-" + d.Dept_Name);

            }


        }
        public void clearFields()
        {
            insCombo.Items.Clear();
            insCombo.Text = string.Empty;
            depCombo.Items.Clear();
            depCombo.Text = string.Empty; 
            mangCombo.Items.Clear();
            mangCombo.Text = string.Empty;
            fnameTxt.Text= string.Empty;
            lnameTxt.Text = string.Empty;
            salaryTxt.Text = string.Empty;
            usernameTxt.Text = string.Empty;
            passwordTxt.Text = string.Empty;



        }

        private void closeBtn_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void deleteBtn_Click(object sender, EventArgs e)
        {
            try
            {
                var insId = int.Parse(insCombo.Text.Substring(0, insCombo.Text.IndexOf("-")));
                Instructor instructor = db.Instructors.Find(insId);
                db.Instructors.Remove(instructor);
                db.SaveChanges();
                fillData();
                MessageBox.Show("Deleted");
            } 
            catch
            {
                MessageBox.Show("Error");
            }
        }

        private void updateBtn_Click(object sender, EventArgs e)
        {
            try
            {
                var insId = int.Parse(insCombo.Text.Substring(0, insCombo.Text.IndexOf("-")));
                Instructor instructor = db.Instructors.Find(insId);
                instructor.Fname = fnameTxt.Text;
                instructor.Lname = lnameTxt.Text;
                instructor.Salary =int.Parse(salaryTxt.Text);
                instructor.Username = int.Parse(usernameTxt.Text);
                instructor.Password = passwordTxt.Text;
                instructor.Dept_id = int.Parse(depCombo.Text.Substring(0, depCombo.Text.IndexOf("-")));
                if (mangCombo.Text == string.Empty)
                {
                    instructor.Manger = null;
                }
                else
                {
                    instructor.Manger = int.Parse(mangCombo.Text.Substring(0, mangCombo.Text.IndexOf("-")));
                }
                db.SaveChanges();
                fillData();
                MessageBox.Show("Updated");
            }
            catch
            {
                MessageBox.Show("Error");
            }
        }

        private void addBtn_Click(object sender, EventArgs e)
        {
            try
            {
                Instructor instructor = new Instructor();
                instructor.Fname = fnameTxt.Text;
                instructor.Lname = lnameTxt.Text;
                instructor.Salary = int.Parse(salaryTxt.Text);
                instructor.Username = int.Parse(usernameTxt.Text);
                instructor.Password = passwordTxt.Text;
                instructor.Dept_id = int.Parse(depCombo.Text.Substring(0, depCombo.Text.IndexOf("-")));
                if (mangCombo.Text == string.Empty)
                {
                    instructor.Manger = null;
                }
                else { 
                instructor.Manger = int.Parse(mangCombo.Text.Substring(0, mangCombo.Text.IndexOf("-")));
                }
                db.Instructors.Add(instructor);
                db.SaveChanges();
                fillData();
                MessageBox.Show("Added");
            }
            catch
            {
                MessageBox.Show("Error");
            }

        }

        private void insCombo_SelectedIndexChanged(object sender, EventArgs e)
        {

            var insId = int.Parse(insCombo.Text.Substring(0, insCombo.Text.IndexOf("-")));
            Instructor instructor = db.Instructors.Find(insId);
             fnameTxt.Text = instructor.Fname;
            lnameTxt.Text= instructor.Lname;
             salaryTxt.Text= instructor.Salary.ToString();
             usernameTxt.Text= instructor.Username.ToString() ;
            passwordTxt.Text = instructor.Password ;
         
        }
    }
}
