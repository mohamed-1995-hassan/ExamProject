
namespace ExamFinal.CourseData
{
    partial class ManageTopic
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.label1 = new System.Windows.Forms.Label();
            this.coursesCombo = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.topicNameTxt = new System.Windows.Forms.TextBox();
            this.addTopicBtn = new System.Windows.Forms.Button();
            this.updateTopicBtn = new System.Windows.Forms.Button();
            this.deleteTopicBtn = new System.Windows.Forms.Button();
            this.closeBtn = new System.Windows.Forms.Button();
            this.topicCombo = new System.Windows.Forms.ComboBox();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(202, 15);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(66, 21);
            this.label1.TabIndex = 0;
            this.label1.Text = "Course";
            // 
            // coursesCombo
            // 
            this.coursesCombo.FormattingEnabled = true;
            this.coursesCombo.Location = new System.Drawing.Point(266, 12);
            this.coursesCombo.Name = "coursesCombo";
            this.coursesCombo.Size = new System.Drawing.Size(331, 24);
            this.coursesCombo.TabIndex = 1;
            this.coursesCombo.SelectedIndexChanged += new System.EventHandler(this.coursesCombo_SelectedIndexChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(314, 102);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(43, 17);
            this.label2.TabIndex = 3;
            this.label2.Text = "Topic";
            // 
            // topicNameTxt
            // 
            this.topicNameTxt.Location = new System.Drawing.Point(363, 102);
            this.topicNameTxt.Name = "topicNameTxt";
            this.topicNameTxt.Size = new System.Drawing.Size(310, 22);
            this.topicNameTxt.TabIndex = 4;
            // 
            // addTopicBtn
            // 
            this.addTopicBtn.Location = new System.Drawing.Point(656, 161);
            this.addTopicBtn.Name = "addTopicBtn";
            this.addTopicBtn.Size = new System.Drawing.Size(72, 34);
            this.addTopicBtn.TabIndex = 5;
            this.addTopicBtn.Text = "Add";
            this.addTopicBtn.UseVisualStyleBackColor = true;
            this.addTopicBtn.Click += new System.EventHandler(this.addTopicBtn_Click);
            // 
            // updateTopicBtn
            // 
            this.updateTopicBtn.Location = new System.Drawing.Point(578, 161);
            this.updateTopicBtn.Name = "updateTopicBtn";
            this.updateTopicBtn.Size = new System.Drawing.Size(72, 34);
            this.updateTopicBtn.TabIndex = 6;
            this.updateTopicBtn.Text = "Update";
            this.updateTopicBtn.UseVisualStyleBackColor = true;
            this.updateTopicBtn.Click += new System.EventHandler(this.updateTopicBtn_Click);
            // 
            // deleteTopicBtn
            // 
            this.deleteTopicBtn.Location = new System.Drawing.Point(500, 161);
            this.deleteTopicBtn.Name = "deleteTopicBtn";
            this.deleteTopicBtn.Size = new System.Drawing.Size(72, 34);
            this.deleteTopicBtn.TabIndex = 7;
            this.deleteTopicBtn.Text = "Delete";
            this.deleteTopicBtn.UseVisualStyleBackColor = true;
            this.deleteTopicBtn.Click += new System.EventHandler(this.deleteTopicBtn_Click);
            // 
            // closeBtn
            // 
            this.closeBtn.Location = new System.Drawing.Point(317, 161);
            this.closeBtn.Name = "closeBtn";
            this.closeBtn.Size = new System.Drawing.Size(72, 34);
            this.closeBtn.TabIndex = 8;
            this.closeBtn.Text = "Close";
            this.closeBtn.UseVisualStyleBackColor = true;
            this.closeBtn.Click += new System.EventHandler(this.closeBtn_Click);
            // 
            // topicCombo
            // 
            this.topicCombo.FormattingEnabled = true;
            this.topicCombo.Location = new System.Drawing.Point(12, 100);
            this.topicCombo.Name = "topicCombo";
            this.topicCombo.Size = new System.Drawing.Size(277, 24);
            this.topicCombo.TabIndex = 9;
            this.topicCombo.SelectedIndexChanged += new System.EventHandler(this.topicCombo_SelectedIndexChanged);
            // 
            // ManageTopic
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(740, 206);
            this.Controls.Add(this.topicCombo);
            this.Controls.Add(this.closeBtn);
            this.Controls.Add(this.deleteTopicBtn);
            this.Controls.Add(this.updateTopicBtn);
            this.Controls.Add(this.addTopicBtn);
            this.Controls.Add(this.topicNameTxt);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.coursesCombo);
            this.Controls.Add(this.label1);
            this.Name = "ManageTopic";
            this.Text = "ManageTopic";
            this.Load += new System.EventHandler(this.ManageTopic_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox coursesCombo;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox topicNameTxt;
        private System.Windows.Forms.Button addTopicBtn;
        private System.Windows.Forms.Button updateTopicBtn;
        private System.Windows.Forms.Button deleteTopicBtn;
        private System.Windows.Forms.Button closeBtn;
        private System.Windows.Forms.ComboBox topicCombo;
    }
}