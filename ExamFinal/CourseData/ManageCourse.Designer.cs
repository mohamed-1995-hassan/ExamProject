
namespace ExamFinal.CourseData
{
    partial class ManageCourse
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
            this.addCourseBtn = new System.Windows.Forms.Button();
            this.editCourseBtn = new System.Windows.Forms.Button();
            this.showDataBtn = new System.Windows.Forms.Button();
            this.topicManageBtn = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // addCourseBtn
            // 
            this.addCourseBtn.Location = new System.Drawing.Point(52, 60);
            this.addCourseBtn.Name = "addCourseBtn";
            this.addCourseBtn.Size = new System.Drawing.Size(177, 121);
            this.addCourseBtn.TabIndex = 0;
            this.addCourseBtn.Text = "Add Course";
            this.addCourseBtn.UseVisualStyleBackColor = true;
            this.addCourseBtn.Click += new System.EventHandler(this.addCourseBtn_Click);
            // 
            // editCourseBtn
            // 
            this.editCourseBtn.Location = new System.Drawing.Point(301, 60);
            this.editCourseBtn.Name = "editCourseBtn";
            this.editCourseBtn.Size = new System.Drawing.Size(177, 121);
            this.editCourseBtn.TabIndex = 1;
            this.editCourseBtn.Text = "Edit Course";
            this.editCourseBtn.UseVisualStyleBackColor = true;
            this.editCourseBtn.Click += new System.EventHandler(this.editCourseBtn_Click);
            // 
            // showDataBtn
            // 
            this.showDataBtn.Location = new System.Drawing.Point(52, 227);
            this.showDataBtn.Name = "showDataBtn";
            this.showDataBtn.Size = new System.Drawing.Size(177, 121);
            this.showDataBtn.TabIndex = 2;
            this.showDataBtn.Text = "Show_Degrees";
            this.showDataBtn.UseVisualStyleBackColor = true;
            this.showDataBtn.Click += new System.EventHandler(this.showDataBtn_Click);
            // 
            // topicManageBtn
            // 
            this.topicManageBtn.Location = new System.Drawing.Point(301, 227);
            this.topicManageBtn.Name = "topicManageBtn";
            this.topicManageBtn.Size = new System.Drawing.Size(177, 121);
            this.topicManageBtn.TabIndex = 3;
            this.topicManageBtn.Text = "Manage Topic";
            this.topicManageBtn.UseVisualStyleBackColor = true;
            this.topicManageBtn.Click += new System.EventHandler(this.topicManageBtn_Click);
            // 
            // ManageCourse
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(536, 426);
            this.Controls.Add(this.topicManageBtn);
            this.Controls.Add(this.showDataBtn);
            this.Controls.Add(this.editCourseBtn);
            this.Controls.Add(this.addCourseBtn);
            this.Name = "ManageCourse";
            this.Text = "ManageCourse";
            this.Load += new System.EventHandler(this.ManageCourse_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button addCourseBtn;
        private System.Windows.Forms.Button editCourseBtn;
        private System.Windows.Forms.Button showDataBtn;
        private System.Windows.Forms.Button topicManageBtn;
    }
}