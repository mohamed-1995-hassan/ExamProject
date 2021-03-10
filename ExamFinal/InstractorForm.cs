using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using ExamFinal.CourseData;
using ExamFinal.DepartmentData;
using ExamFinal.InstractorData;
using ExamFinal.StudentData;

namespace ExamFinal
{
    public partial class InstractorForm : Form
    {
        ExaminationSystemEntities1 db = new ExaminationSystemEntities1();
        public Instructor user;
        public InstractorForm()
        {
            InitializeComponent();
        }

        private void InstractorForm_Load(object sender, EventArgs e)
        {
            instructorManageBtn.Enabled = false;
            fillData();
            checkIfManage();
        }
        public void checkIfManage()
        {
            if (user.Manger == null)
            {
                instructorManageBtn.Enabled = true;
            }
            else
            {
                instructorManageBtn.Enabled = false;

            }
        }
        public void fillData()
        {
            DataTable dataTable = new DataTable();
            var ins = db.Instructors.ToList();

            dataTable.Columns.Add("ID");
            dataTable.Columns.Add("Name");
            dataTable.Columns.Add("DepID");
            foreach (var elm in ins)
            {
                DataRow dataRow = dataTable.NewRow();
                dataRow["ID"] = elm.Ins_id.ToString();
                dataRow["Name"] = elm.Fname.ToString() + " " + elm.Lname.ToString();
                dataRow["DepID"] = elm.Dept_id.ToString();
                dataTable.Rows.Add(dataRow);
            }
            insDataView.DataSource = dataTable;
        }

        private void courseManageBtn_Click(object sender, EventArgs e)
        {
            ManageCourse manageCourse = new ManageCourse();
            manageCourse.Show();
        }

        private void studentManageBtn_Click(object sender, EventArgs e)
        {
            ManageStudent manageStudent = new ManageStudent();
            manageStudent.Show();
        }

        private void depManageBtn_Click(object sender, EventArgs e)
        {
            ManageDept manageDept = new ManageDept();
            manageDept.Show();
        }

        private void instructorManageBtn_Click(object sender, EventArgs e)
        {
            ManageInstructor manageInstructor = new ManageInstructor();
            manageInstructor.Show();
        }

        private void examManageBtn_Click(object sender, EventArgs e)
        {
            insertExam insert_show = new insertExam();
            insert_show.Show();

        }
    }
}
