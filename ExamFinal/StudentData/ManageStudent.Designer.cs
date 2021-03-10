
namespace ExamFinal.StudentData
{
    partial class ManageStudent
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
            this.addStudentBtn = new System.Windows.Forms.Button();
            this.editStudentBtn = new System.Windows.Forms.Button();
            this.stdDegreeBtn = new System.Windows.Forms.Button();
            this.getStdsBtn = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // addStudentBtn
            // 
            this.addStudentBtn.Location = new System.Drawing.Point(12, 12);
            this.addStudentBtn.Name = "addStudentBtn";
            this.addStudentBtn.Size = new System.Drawing.Size(208, 166);
            this.addStudentBtn.TabIndex = 0;
            this.addStudentBtn.Text = "Add Student";
            this.addStudentBtn.UseVisualStyleBackColor = true;
            this.addStudentBtn.Click += new System.EventHandler(this.addStudentBtn_Click);
            // 
            // editStudentBtn
            // 
            this.editStudentBtn.Location = new System.Drawing.Point(268, 12);
            this.editStudentBtn.Name = "editStudentBtn";
            this.editStudentBtn.Size = new System.Drawing.Size(208, 166);
            this.editStudentBtn.TabIndex = 1;
            this.editStudentBtn.Text = "Edit Student";
            this.editStudentBtn.UseVisualStyleBackColor = true;
            this.editStudentBtn.Click += new System.EventHandler(this.editStudentBtn_Click);
            // 
            // stdDegreeBtn
            // 
            this.stdDegreeBtn.Location = new System.Drawing.Point(12, 187);
            this.stdDegreeBtn.Name = "stdDegreeBtn";
            this.stdDegreeBtn.Size = new System.Drawing.Size(208, 166);
            this.stdDegreeBtn.TabIndex = 2;
            this.stdDegreeBtn.Text = "Get Student Degree";
            this.stdDegreeBtn.UseVisualStyleBackColor = true;
            // 
            // getStdsBtn
            // 
            this.getStdsBtn.Location = new System.Drawing.Point(268, 187);
            this.getStdsBtn.Name = "getStdsBtn";
            this.getStdsBtn.Size = new System.Drawing.Size(208, 166);
            this.getStdsBtn.TabIndex = 3;
            this.getStdsBtn.Text = "Get All Students";
            this.getStdsBtn.UseVisualStyleBackColor = true;
            this.getStdsBtn.Click += new System.EventHandler(this.getStdsBtn_Click);
            // 
            // ManageStudent
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(488, 365);
            this.Controls.Add(this.getStdsBtn);
            this.Controls.Add(this.stdDegreeBtn);
            this.Controls.Add(this.editStudentBtn);
            this.Controls.Add(this.addStudentBtn);
            this.Name = "ManageStudent";
            this.Text = "ManageStudent";
            this.Load += new System.EventHandler(this.ManageStudent_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button addStudentBtn;
        private System.Windows.Forms.Button editStudentBtn;
        private System.Windows.Forms.Button stdDegreeBtn;
        private System.Windows.Forms.Button getStdsBtn;
    }
}