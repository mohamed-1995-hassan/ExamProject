using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.Entity.Core.Objects;

namespace ExamFinal
{
    public partial class Student_degrees : Form
    {
        ExaminationSystemEntities1 ee = new ExaminationSystemEntities1();
        public Student_degrees()
        {
            InitializeComponent();
        }

        private void Student_degrees_Load(object sender, EventArgs e)
        {
            //dataGridView1




            ObjectResult<Get_All_Degress_Result> objectResults = ee.Get_All_Degress();
            DataTable dataTable = new DataTable();
            dataTable.Columns.Add("Course Name");
            dataTable.Columns.Add("Student Name");
            dataTable.Columns.Add("Your Grade");
            dataTable.Columns.Add("Total Deree");

            foreach (var elm in objectResults)
            {
                DataRow dataRow = dataTable.NewRow();
                dataRow["Student Name"] = elm.Full_Name;
                dataRow["Course Name"] = elm.crs_Name;
                dataRow["Your Grade"] = elm.grade;
                dataRow["Total Deree"] = elm.Total_Deg;

                dataTable.Rows.Add(dataRow);
            }

            dataGridView1.DataSource = dataTable;

        }
    }
}
