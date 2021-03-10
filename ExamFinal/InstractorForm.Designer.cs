
namespace ExamFinal
{
    partial class InstractorForm
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
            this.insDataView = new System.Windows.Forms.DataGridView();
            this.courseManageBtn = new System.Windows.Forms.Button();
            this.studentManageBtn = new System.Windows.Forms.Button();
            this.examManageBtn = new System.Windows.Forms.Button();
            this.instructorManageBtn = new System.Windows.Forms.Button();
            this.depManageBtn = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.insDataView)).BeginInit();
            this.SuspendLayout();
            // 
            // insDataView
            // 
            this.insDataView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.insDataView.Location = new System.Drawing.Point(417, 12);
            this.insDataView.Name = "insDataView";
            this.insDataView.RowHeadersWidth = 51;
            this.insDataView.RowTemplate.Height = 24;
            this.insDataView.Size = new System.Drawing.Size(473, 468);
            this.insDataView.TabIndex = 0;
            // 
            // courseManageBtn
            // 
            this.courseManageBtn.Location = new System.Drawing.Point(48, 69);
            this.courseManageBtn.Name = "courseManageBtn";
            this.courseManageBtn.Size = new System.Drawing.Size(315, 54);
            this.courseManageBtn.TabIndex = 1;
            this.courseManageBtn.Text = "Manage Course";
            this.courseManageBtn.UseVisualStyleBackColor = true;
            this.courseManageBtn.Click += new System.EventHandler(this.courseManageBtn_Click);
            // 
            // studentManageBtn
            // 
            this.studentManageBtn.Location = new System.Drawing.Point(48, 141);
            this.studentManageBtn.Name = "studentManageBtn";
            this.studentManageBtn.Size = new System.Drawing.Size(315, 54);
            this.studentManageBtn.TabIndex = 2;
            this.studentManageBtn.Text = "Manage Student";
            this.studentManageBtn.UseVisualStyleBackColor = true;
            this.studentManageBtn.Click += new System.EventHandler(this.studentManageBtn_Click);
            // 
            // examManageBtn
            // 
            this.examManageBtn.Location = new System.Drawing.Point(48, 288);
            this.examManageBtn.Name = "examManageBtn";
            this.examManageBtn.Size = new System.Drawing.Size(315, 54);
            this.examManageBtn.TabIndex = 3;
            this.examManageBtn.Text = "Manage Exam";
            this.examManageBtn.UseVisualStyleBackColor = true;
            this.examManageBtn.Click += new System.EventHandler(this.examManageBtn_Click);
            // 
            // instructorManageBtn
            // 
            this.instructorManageBtn.Enabled = false;
            this.instructorManageBtn.Location = new System.Drawing.Point(48, 361);
            this.instructorManageBtn.Name = "instructorManageBtn";
            this.instructorManageBtn.Size = new System.Drawing.Size(315, 54);
            this.instructorManageBtn.TabIndex = 4;
            this.instructorManageBtn.Text = "Manage Instructor";
            this.instructorManageBtn.UseVisualStyleBackColor = true;
            this.instructorManageBtn.Click += new System.EventHandler(this.instructorManageBtn_Click);
            // 
            // depManageBtn
            // 
            this.depManageBtn.Location = new System.Drawing.Point(48, 213);
            this.depManageBtn.Name = "depManageBtn";
            this.depManageBtn.Size = new System.Drawing.Size(315, 54);
            this.depManageBtn.TabIndex = 5;
            this.depManageBtn.Text = "Manage Department";
            this.depManageBtn.UseVisualStyleBackColor = true;
            this.depManageBtn.Click += new System.EventHandler(this.depManageBtn_Click);
            // 
            // InstractorForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(902, 492);
            this.Controls.Add(this.depManageBtn);
            this.Controls.Add(this.instructorManageBtn);
            this.Controls.Add(this.examManageBtn);
            this.Controls.Add(this.studentManageBtn);
            this.Controls.Add(this.courseManageBtn);
            this.Controls.Add(this.insDataView);
            this.Name = "InstractorForm";
            this.Text = "Instructor";
            this.Load += new System.EventHandler(this.InstractorForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.insDataView)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView insDataView;
        private System.Windows.Forms.Button courseManageBtn;
        private System.Windows.Forms.Button studentManageBtn;
        private System.Windows.Forms.Button examManageBtn;
        private System.Windows.Forms.Button instructorManageBtn;
        private System.Windows.Forms.Button depManageBtn;
    }
}