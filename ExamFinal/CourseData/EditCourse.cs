using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ExamFinal.CourseData
{
    public partial class EditCourse : Form
    {
        ExaminationSystemEntities1 db = new ExaminationSystemEntities1();
        public EditCourse()
        {
            InitializeComponent();
        }

        private void EditCourse_Load(object sender, EventArgs e)
        {
            fillData();
        }
        public void fillData()
        {
            coursesCombo.Items.Clear();
            courseNameTxt.Text = string.Empty;
            coursesCombo.Text = string.Empty;
            var crs = db.Courses;
            foreach (var c in crs)
            {
                coursesCombo.Items.Add(c.crs_id + "-" + c.crs_Name);
            }

        }

        private void coursesCombo_SelectedIndexChanged(object sender, EventArgs e)
        {
            var crsId =int.Parse(coursesCombo.Text.Substring(0, coursesCombo.Text.IndexOf("-")));
            Cours crs = db.Courses.Find(crsId);
            if (crs != null)
                courseNameTxt.Text = crs.crs_Name;



        }

        private void updateCourseBtn_Click(object sender, EventArgs e)
        {
            try
            {
                var crsId = int.Parse(coursesCombo.Text.Substring(0, coursesCombo.Text.IndexOf("-")));
                Cours crs = db.Courses.Find(crsId);
                if (crs != null)
                    crs.crs_Name = courseNameTxt.Text;

                db.SaveChanges();
                fillData();

                MessageBox.Show("Updated");
            }
            catch
            {
                MessageBox.Show("Enter Vaild Data");

            }
        }

        private void deleteCourseBtn_Click(object sender, EventArgs e)
        {
            try
            {
                var crsId = int.Parse(coursesCombo.Text.Substring(0, coursesCombo.Text.IndexOf("-")));
                Cours crs = db.Courses.Find(crsId);
                if (crs != null)
                    db.Courses.Remove(crs);

                db.SaveChanges();
                fillData();

                MessageBox.Show("Deleted");
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
    }
}
