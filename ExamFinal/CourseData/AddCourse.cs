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
    public partial class AddCourse : Form
    {
        ExaminationSystemEntities1 db = new ExaminationSystemEntities1();

        public AddCourse()
        {
            InitializeComponent();
        }

        private void addCourseBtn_Click(object sender, EventArgs e)
        {
            try
            {
                var courseName = courseNameTxt.Text;
                db.InsertCourses(courseName);
                this.Close();
            }
            catch
            {
                MessageBox.Show("Enter Vaild Data");
            }
           
        }

        private void AddCourse_Load(object sender, EventArgs e)
        {

        }
    }
}
