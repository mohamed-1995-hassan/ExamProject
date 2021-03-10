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
    public partial class ManageCourse : Form
    {
        public ManageCourse()
        {
            InitializeComponent();
        }

        private void addCourseBtn_Click(object sender, EventArgs e)
        {
            AddCourse addCourse = new AddCourse();
            addCourse.Show();
        }

        private void editCourseBtn_Click(object sender, EventArgs e)
        {
            EditCourse editCourse = new EditCourse();
            editCourse.Show();
        }

        private void topicManageBtn_Click(object sender, EventArgs e)
        {
            ManageTopic manageTopic = new ManageTopic();
            manageTopic.Show();
        }

        private void ManageCourse_Load(object sender, EventArgs e)
        {

        }

        private void showDataBtn_Click(object sender, EventArgs e)
        {
            Student_degrees std = new Student_degrees();
            std.Show();

        }
    }
}
