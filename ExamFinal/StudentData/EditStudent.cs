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
    public partial class EditStudent : Form
    {
        ExaminationSystemEntities1 db = new ExaminationSystemEntities1();
        public EditStudent()
        {
            InitializeComponent();
        }

        private void EditStudent_Load(object sender, EventArgs e)
        {
            fillData();
        }
        public void fillData()
        {
            stdCombo.Text = string.Empty;
            stdCombo.Items.Clear();
            var stds = db.Students;
            foreach (var s in stds)
            {
                stdCombo.Items.Add(s.Std_id + "-" + s.Fname + " " + s.Lname);
            }
        }

        private void stdCombo_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {

                var stdId = int.Parse(stdCombo.Text.Substring(0, stdCombo.Text.IndexOf("-")));
                var std = db.Students.Find(stdId);
                fnameTxt.Text = std.Fname;
                lnameTxt.Text = std.Lname;
                addressTxt.Text = std.Address;
                dateTimePicker1.Value = std.Dob.Value;
                useridTxt.Text = std.Username.ToString();
                passwordTxt.Text = std.Password;
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
                var stdId = int.Parse(stdCombo.Text.Substring(0, stdCombo.Text.IndexOf("-")));
                var std = db.Students.Find(stdId);
                if(std != null)
                {
                    std.Fname = fnameTxt.Text;
                    std.Lname = lnameTxt.Text;
                    std.Address = addressTxt.Text;
                    std.Dob = dateTimePicker1.Value;
                    std.Username = int.Parse(useridTxt.Text);
                    std.Password = passwordTxt.Text;
                    db.SaveChanges();
                    MessageBox.Show("Updated");
                }
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
                var stdId = int.Parse(stdCombo.Text.Substring(0, stdCombo.Text.IndexOf("-")));
                var std = db.Students.Find(stdId);
                if(std!=null)
                {
                    db.Students.Remove(std);
                    db.SaveChanges();
                    MessageBox.Show("Deleted");
                }    
          

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
