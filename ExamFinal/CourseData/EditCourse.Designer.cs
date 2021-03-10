
namespace ExamFinal.CourseData
{
    partial class EditCourse
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
            this.coursesCombo = new System.Windows.Forms.ComboBox();
            this.courseNameTxt = new System.Windows.Forms.TextBox();
            this.updateCourseBtn = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.deleteCourseBtn = new System.Windows.Forms.Button();
            this.closeBtn = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // coursesCombo
            // 
            this.coursesCombo.FormattingEnabled = true;
            this.coursesCombo.Location = new System.Drawing.Point(139, 12);
            this.coursesCombo.Name = "coursesCombo";
            this.coursesCombo.Size = new System.Drawing.Size(365, 24);
            this.coursesCombo.TabIndex = 0;
            this.coursesCombo.SelectedIndexChanged += new System.EventHandler(this.coursesCombo_SelectedIndexChanged);
            // 
            // courseNameTxt
            // 
            this.courseNameTxt.Location = new System.Drawing.Point(139, 57);
            this.courseNameTxt.Name = "courseNameTxt";
            this.courseNameTxt.Size = new System.Drawing.Size(365, 22);
            this.courseNameTxt.TabIndex = 1;
            // 
            // updateCourseBtn
            // 
            this.updateCourseBtn.Location = new System.Drawing.Point(461, 95);
            this.updateCourseBtn.Name = "updateCourseBtn";
            this.updateCourseBtn.Size = new System.Drawing.Size(105, 31);
            this.updateCourseBtn.TabIndex = 2;
            this.updateCourseBtn.Text = "Update";
            this.updateCourseBtn.UseVisualStyleBackColor = true;
            this.updateCourseBtn.Click += new System.EventHandler(this.updateCourseBtn_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(15, 16);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(75, 21);
            this.label1.TabIndex = 3;
            this.label1.Text = "Courses";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(15, 57);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(94, 17);
            this.label2.TabIndex = 4;
            this.label2.Text = "Course Name";
            // 
            // deleteCourseBtn
            // 
            this.deleteCourseBtn.Location = new System.Drawing.Point(350, 95);
            this.deleteCourseBtn.Name = "deleteCourseBtn";
            this.deleteCourseBtn.Size = new System.Drawing.Size(105, 31);
            this.deleteCourseBtn.TabIndex = 5;
            this.deleteCourseBtn.Text = "Delete";
            this.deleteCourseBtn.UseVisualStyleBackColor = true;
            this.deleteCourseBtn.Click += new System.EventHandler(this.deleteCourseBtn_Click);
            // 
            // closeBtn
            // 
            this.closeBtn.Location = new System.Drawing.Point(222, 96);
            this.closeBtn.Name = "closeBtn";
            this.closeBtn.Size = new System.Drawing.Size(122, 30);
            this.closeBtn.TabIndex = 6;
            this.closeBtn.Text = "Close";
            this.closeBtn.UseVisualStyleBackColor = true;
            this.closeBtn.Click += new System.EventHandler(this.closeBtn_Click);
            // 
            // EditCourse
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(578, 135);
            this.Controls.Add(this.closeBtn);
            this.Controls.Add(this.deleteCourseBtn);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.updateCourseBtn);
            this.Controls.Add(this.courseNameTxt);
            this.Controls.Add(this.coursesCombo);
            this.Name = "EditCourse";
            this.Text = "EditCourse";
            this.Load += new System.EventHandler(this.EditCourse_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox coursesCombo;
        private System.Windows.Forms.TextBox courseNameTxt;
        private System.Windows.Forms.Button updateCourseBtn;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button deleteCourseBtn;
        private System.Windows.Forms.Button closeBtn;
    }
}