
namespace ExamFinal.DepartmentData
{
    partial class ManageDept
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
            this.Departments = new System.Windows.Forms.Label();
            this.deptCombo = new System.Windows.Forms.ComboBox();
            this.empsList = new System.Windows.Forms.ListBox();
            this.label1 = new System.Windows.Forms.Label();
            this.deptNameTxt = new System.Windows.Forms.TextBox();
            this.addBtn = new System.Windows.Forms.Button();
            this.updateBtn = new System.Windows.Forms.Button();
            this.deleteBtn = new System.Windows.Forms.Button();
            this.closeBtn = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // Departments
            // 
            this.Departments.AutoSize = true;
            this.Departments.Location = new System.Drawing.Point(12, 18);
            this.Departments.Name = "Departments";
            this.Departments.Size = new System.Drawing.Size(89, 17);
            this.Departments.TabIndex = 0;
            this.Departments.Text = "Departments";
            // 
            // deptCombo
            // 
            this.deptCombo.FormattingEnabled = true;
            this.deptCombo.Location = new System.Drawing.Point(129, 15);
            this.deptCombo.Name = "deptCombo";
            this.deptCombo.Size = new System.Drawing.Size(281, 24);
            this.deptCombo.TabIndex = 1;
            this.deptCombo.SelectedIndexChanged += new System.EventHandler(this.comboBox1_SelectedIndexChanged);
            // 
            // empsList
            // 
            this.empsList.FormattingEnabled = true;
            this.empsList.ItemHeight = 16;
            this.empsList.Location = new System.Drawing.Point(12, 76);
            this.empsList.Name = "empsList";
            this.empsList.Size = new System.Drawing.Size(394, 324);
            this.empsList.TabIndex = 2;
            this.empsList.SelectedIndexChanged += new System.EventHandler(this.empsList_SelectedIndexChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 427);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(123, 17);
            this.label1.TabIndex = 3;
            this.label1.Text = "Department Name";
            // 
            // deptNameTxt
            // 
            this.deptNameTxt.Location = new System.Drawing.Point(172, 424);
            this.deptNameTxt.Name = "deptNameTxt";
            this.deptNameTxt.Size = new System.Drawing.Size(237, 22);
            this.deptNameTxt.TabIndex = 4;
            // 
            // addBtn
            // 
            this.addBtn.Location = new System.Drawing.Point(339, 485);
            this.addBtn.Name = "addBtn";
            this.addBtn.Size = new System.Drawing.Size(70, 31);
            this.addBtn.TabIndex = 5;
            this.addBtn.Text = "Add";
            this.addBtn.UseVisualStyleBackColor = true;
            this.addBtn.Click += new System.EventHandler(this.addBtn_Click);
            // 
            // updateBtn
            // 
            this.updateBtn.Location = new System.Drawing.Point(263, 485);
            this.updateBtn.Name = "updateBtn";
            this.updateBtn.Size = new System.Drawing.Size(70, 31);
            this.updateBtn.TabIndex = 6;
            this.updateBtn.Text = "Update";
            this.updateBtn.UseVisualStyleBackColor = true;
            this.updateBtn.Click += new System.EventHandler(this.updateBtn_Click);
            // 
            // deleteBtn
            // 
            this.deleteBtn.Location = new System.Drawing.Point(187, 485);
            this.deleteBtn.Name = "deleteBtn";
            this.deleteBtn.Size = new System.Drawing.Size(70, 31);
            this.deleteBtn.TabIndex = 7;
            this.deleteBtn.Text = "Delete";
            this.deleteBtn.UseVisualStyleBackColor = true;
            this.deleteBtn.Click += new System.EventHandler(this.deleteBtn_Click);
            // 
            // closeBtn
            // 
            this.closeBtn.Location = new System.Drawing.Point(15, 485);
            this.closeBtn.Name = "closeBtn";
            this.closeBtn.Size = new System.Drawing.Size(70, 31);
            this.closeBtn.TabIndex = 8;
            this.closeBtn.Text = "Close";
            this.closeBtn.UseVisualStyleBackColor = true;
            this.closeBtn.Click += new System.EventHandler(this.closeBtn_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(126, 52);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(155, 17);
            this.label2.TabIndex = 9;
            this.label2.Text = "Department Employees";
            // 
            // ManageDept
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(427, 526);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.closeBtn);
            this.Controls.Add(this.deleteBtn);
            this.Controls.Add(this.updateBtn);
            this.Controls.Add(this.addBtn);
            this.Controls.Add(this.deptNameTxt);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.empsList);
            this.Controls.Add(this.deptCombo);
            this.Controls.Add(this.Departments);
            this.Name = "ManageDept";
            this.Text = "ManageDept";
            this.Load += new System.EventHandler(this.ManageDept_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label Departments;
        private System.Windows.Forms.ComboBox deptCombo;
        private System.Windows.Forms.ListBox empsList;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox deptNameTxt;
        private System.Windows.Forms.Button addBtn;
        private System.Windows.Forms.Button updateBtn;
        private System.Windows.Forms.Button deleteBtn;
        private System.Windows.Forms.Button closeBtn;
        private System.Windows.Forms.Label label2;
    }
}