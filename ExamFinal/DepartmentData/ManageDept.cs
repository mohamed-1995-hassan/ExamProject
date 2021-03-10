using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ExamFinal.DepartmentData
{
    public partial class ManageDept : Form
    {
        ExaminationSystemEntities1 db = new ExaminationSystemEntities1();
        public ManageDept()
        {
            InitializeComponent();
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            deptNameTxt.Text = string.Empty;
            empsList.Items.Clear();
            var depId = int.Parse(deptCombo.Text.Substring(0, deptCombo.Text.IndexOf("-")));
            var dep = db.Departments.Find(depId);
            if (dep != null)
            {
                deptNameTxt.Text = dep.Dept_Name;
                var emps = (from emp in db.Instructors where emp.Dept_id == depId select emp);
                foreach(var emp in emps)
                {
                    empsList.Items.Add(emp.Fname + " " + emp.Lname);
                }

            }
        }

        private void ManageDept_Load(object sender, EventArgs e)
        {
            fillData();
        }
        public void fillData()
        {
            deptCombo.Items.Clear();
            deptCombo.Text = string.Empty;
            deptNameTxt.Text = string.Empty;
            empsList.Items.Clear();
            var depts = db.Departments;
            foreach(var d in depts)
            {
                deptCombo.Items.Add(d.Dept_id + "-" + d.Dept_Name);
            }
        }

        private void addBtn_Click(object sender, EventArgs e)
        {
            try
            {

                Department department = new Department();
                department.Dept_Name = deptNameTxt.Text;
                db.Departments.Add(department);
                db.SaveChanges();
                fillData();
                MessageBox.Show("Added");
            }
            catch
            {
                MessageBox.Show("Error");

            }
        }

        private void closeBtn_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void updateBtn_Click(object sender, EventArgs e)
        {
            try
            {
                var depId = int.Parse(deptCombo.Text.Substring(0, deptCombo.Text.IndexOf("-")));
                Department department = db.Departments.Find(depId);
                department.Dept_Name = deptNameTxt.Text;
                db.SaveChanges();
                fillData();
                MessageBox.Show("Updated");
            }
            catch
            {
                MessageBox.Show("Error");

            }
        }

        private void deleteBtn_Click(object sender, EventArgs e)
        {
            try
            {
                var depId = int.Parse(deptCombo.Text.Substring(0, deptCombo.Text.IndexOf("-")));
                Department department = db.Departments.Find(depId);
                db.Departments.Remove(department);
                db.SaveChanges();
                fillData();
                MessageBox.Show("Deleted");
            }
            catch
            {
                MessageBox.Show("Error");

            }
        }

        private void empsList_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
