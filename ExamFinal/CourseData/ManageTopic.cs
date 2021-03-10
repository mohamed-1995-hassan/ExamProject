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
    public partial class ManageTopic : Form
    {
        ExaminationSystemEntities1 db = new ExaminationSystemEntities1();

        public ManageTopic()
        {
            InitializeComponent();
        }

        private void ManageTopic_Load(object sender, EventArgs e)
        {
            fillData();
        }
        public void fillData()
        {
            coursesCombo.Items.Clear();
            topicCombo.Items.Clear();
            topicCombo.Text = string.Empty;
            coursesCombo.Text = string.Empty;
            topicNameTxt.Text = string.Empty;
            var crs = db.Courses;
            foreach (var c in crs)
            {
                coursesCombo.Items.Add(c.crs_id + "-" + c.crs_Name);
            }

        }

        private void coursesCombo_SelectedIndexChanged(object sender, EventArgs e)
        {
            topicCombo.Items.Clear();
            topicNameTxt.Text = string.Empty;
            var crsId = int.Parse(coursesCombo.Text.Substring(0, coursesCombo.Text.IndexOf("-")));
            Cours crs = db.Courses.Find(crsId);
            var topics= crs.Topics;
            foreach(var t in topics)
            {
                topicCombo.Items.Add(t.Topic_id+"-"+t.Topic_Name);
            }
        }

   

        private void closeBtn_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void deleteTopicBtn_Click(object sender, EventArgs e)
        {
            try { 
            var topicId = int.Parse(topicCombo.Text.Substring(0, topicCombo.Text.IndexOf("-")));
            Topic topic = db.Topics.Find(topicId);
            if (topic != null)
                db.Topics.Remove(topic);
                db.SaveChanges();
                fillData();
                MessageBox.Show("Deleted");

            }
            catch
            {
                MessageBox.Show("Error");
            }
        }

        private void updateTopicBtn_Click(object sender, EventArgs e)
        {
            try
            {
                var topicId = int.Parse(topicCombo.Text.Substring(0, topicCombo.Text.IndexOf("-")));
                Topic topic = db.Topics.Find(topicId);
                if (topic != null)
                    topic.Topic_Name = topicNameTxt.Text;
                db.SaveChanges();
                fillData();
                MessageBox.Show("Updated");
            }
            catch
            {
                MessageBox.Show("Error");
            }
        }

        private void addTopicBtn_Click(object sender, EventArgs e)
        {
            try
            {
                var crsId = int.Parse(coursesCombo.Text.Substring(0, coursesCombo.Text.IndexOf("-")));
                Topic topic = new Topic();
                topic.Topic_Name = topicNameTxt.Text;
                topic.Crs_id = crsId;
                db.Topics.Add(topic);
                db.SaveChanges();
                fillData();
                MessageBox.Show("Added");
            }
            catch
            {
                MessageBox.Show("Error");
            }
        }

        private void topicCombo_SelectedIndexChanged(object sender, EventArgs e)
        {
            topicNameTxt.Text = string.Empty;
            var topicId = int.Parse(topicCombo.Text.Substring(0, topicCombo.Text.IndexOf("-")));
            Topic topic = db.Topics.Find(topicId);
            if (topic != null)
                topicNameTxt.Text = topic.Topic_Name;
        }
    }
}
