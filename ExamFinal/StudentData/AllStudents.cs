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
    public partial class AllStudents : Form
    {
        ExaminationSystemEntities1 db = new ExaminationSystemEntities1();
        public AllStudents()
        {
            InitializeComponent();
        }

        private void AllStudents_Load(object sender, EventArgs e)
        {
            var stds = db.Students;
            DataTable dataTable = new DataTable();
            dataTable.Columns.Add("StudentId");
            dataTable.Columns.Add("FName");
            dataTable.Columns.Add("LName");
            dataTable.Columns.Add("Address");
            dataTable.Columns.Add("Dob");
            dataTable.Columns.Add("DepID");
            dataTable.Columns.Add("UserName");
            dataTable.Columns.Add("Password");
            foreach(var s in stds)
            {
                DataRow dataRow = dataTable.NewRow();
                dataRow["StudentId"] = s.Std_id;
                dataRow["FName"] = s.Fname;
                dataRow["LName"] = s.Lname;
                dataRow["Address"] = s.Address;
                dataRow["Dob"] = s.Dob;
                dataRow["DepID"] = s.Dept_id;
                dataRow["UserName"] = s.Username;
                dataRow["Password"] = s.Password;
                dataTable.Rows.Add(dataRow);
            }
            dataGridView1.DataSource = dataTable;

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
