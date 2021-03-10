
namespace ExamFinal.CourseData
{
    partial class AddCourse
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
            this.courseNameTxt = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.addCourseBtn = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // courseNameTxt
            // 
            this.courseNameTxt.Location = new System.Drawing.Point(136, 34);
            this.courseNameTxt.Name = "courseNameTxt";
            this.courseNameTxt.Size = new System.Drawing.Size(295, 22);
            this.courseNameTxt.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 34);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(94, 17);
            this.label1.TabIndex = 1;
            this.label1.Text = "Course Name";
            // 
            // addCourseBtn
            // 
            this.addCourseBtn.Location = new System.Drawing.Point(332, 70);
            this.addCourseBtn.Name = "addCourseBtn";
            this.addCourseBtn.Size = new System.Drawing.Size(99, 30);
            this.addCourseBtn.TabIndex = 2;
            this.addCourseBtn.Text = "Add Course";
            this.addCourseBtn.UseVisualStyleBackColor = true;
            this.addCourseBtn.Click += new System.EventHandler(this.addCourseBtn_Click);
            // 
            // AddCourse
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(446, 113);
            this.Controls.Add(this.addCourseBtn);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.courseNameTxt);
            this.MaximumSize = new System.Drawing.Size(464, 160);
            this.MinimumSize = new System.Drawing.Size(464, 160);
            this.Name = "AddCourse";
            this.Text = "AddCourse";
            this.Load += new System.EventHandler(this.AddCourse_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox courseNameTxt;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button addCourseBtn;
    }
}