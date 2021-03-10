using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ExamFinal
{
    public partial class Form1 : Form
    {
        ExaminationSystemEntities1 db = new ExaminationSystemEntities1();
        public Form1()
        {
            InitializeComponent();
        }

        private void loginBtn_Click(object sender, EventArgs e)
        {
            try
            {
                var username = Convert.ToInt32(usernameTextBox.Text);
                var password = passwordTextBox.Text;
                if (studentRadio.Checked)
                {
                    Student user = (db.Students.Where(d => d.Username == username).Select(d => d)).First();
                    if (user != null)
                    {
                        if (user.Password == password)
                        {
                            perform_exam ST = new perform_exam(user,this);
                            ST.Show();
                            this.Hide();
                        }
                        else
                        {
                            MessageBox.Show("incorrect data");
                        }
                    }
                    else
                    {
                        MessageBox.Show("Username Not Found");
                    }
                }
                else
                {
                    var user = (db.Instructors.Where(d => d.Username == username).Select(d => d)).First();
                    if (user != null)
                    {
                        if (user.Password == password)
                        {
                            this.Hide();
                            InstractorForm instractorForm = new InstractorForm();
                            instractorForm.user = user;
                            instractorForm.Closed += (s, args) => this.Close();
                            instractorForm.Show();

                        }
                        else
                        {
                            MessageBox.Show("أتاكد من معلوماتك ي اخووو");
                        }
                    }
                    else
                    {
                        MessageBox.Show("Username Not Found");
                    }
                }
            }
            catch (Exception ee)
            {
                MessageBox.Show(ee.Message);
            }


        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
    }
}





































