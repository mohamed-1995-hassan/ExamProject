using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ExamFinal.StudentData
{
    public partial class AddStudent : Form
    {
        ExaminationSystemEntities1 db = new ExaminationSystemEntities1();
        public AddStudent()
        {
            InitializeComponent();
        }

        private void closeBtn_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void AddStudent_Load(object sender, EventArgs e)
        {
            fillData();
        }
        public void fillData()
        {
            depTxt.Text = string.Empty;
            depTxt.Items.Clear();
            var deps = db.Departments;
            foreach(var d in deps)
            {
                depTxt.Items.Add(d.Dept_id+"-"+d.Dept_Name);
            }    

        }
        public void clearData()
        {
            fnameTxt.Text = string.Empty;
            lnameTxt.Text = string.Empty;
            addressTxt.Text = string.Empty;
            useridTxt.Text = string.Empty;
            passwordTxt.Text = string.Empty;

        }
        private void addBtn_Click(object sender, EventArgs e)
        {
            try
            {
                Student student = new Student();
                student.Fname = fnameTxt.Text;
                student.Lname = lnameTxt.Text;
                student.Address = addressTxt.Text;
                student.Dob = dateTimePicker1.Value;
                student.Dept_id = int.Parse(depTxt.Text.Substring(0, depTxt.Text.IndexOf("-")));
                student.Username = int.Parse(useridTxt.Text);
                student.Password = passwordTxt.Text;
                db.Students.Add(student);
                db.SaveChanges();
                MessageBox.Show("Added");
            }
            catch
            {
                MessageBox.Show("Error");

            }

        }
    }
}
