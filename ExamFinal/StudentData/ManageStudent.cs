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
    public partial class ManageStudent : Form
    {
        public ManageStudent()
        {
            InitializeComponent();
        }

        private void addStudentBtn_Click(object sender, EventArgs e)
        {
            AddStudent addStudent = new AddStudent();
            addStudent.Show();
        }

        private void ManageStudent_Load(object sender, EventArgs e)
        {

        }

        private void editStudentBtn_Click(object sender, EventArgs e)
        {
            EditStudent editStudent = new EditStudent();
            editStudent.Show();
        }

        private void getStdsBtn_Click(object sender, EventArgs e)
        {
            AllStudents allStudents = new AllStudents();
            allStudents.Show();
        }
    }
}
