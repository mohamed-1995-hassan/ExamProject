
namespace ExamFinal.InstractorData
{
    partial class ManageInstructor
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
            this.insCombo = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.fnameTxt = new System.Windows.Forms.TextBox();
            this.lnameTxt = new System.Windows.Forms.TextBox();
            this.LastName = new System.Windows.Forms.Label();
            this.salaryTxt = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.usernameTxt = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.passwordTxt = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.Depts = new System.Windows.Forms.Label();
            this.label = new System.Windows.Forms.Label();
            this.depCombo = new System.Windows.Forms.ComboBox();
            this.mangCombo = new System.Windows.Forms.ComboBox();
            this.addBtn = new System.Windows.Forms.Button();
            this.updateBtn = new System.Windows.Forms.Button();
            this.deleteBtn = new System.Windows.Forms.Button();
            this.closeBtn = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(23, 14);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(74, 17);
            this.label1.TabIndex = 0;
            this.label1.Text = "Instructors";
            // 
            // insCombo
            // 
            this.insCombo.FormattingEnabled = true;
            this.insCombo.Location = new System.Drawing.Point(134, 11);
            this.insCombo.Name = "insCombo";
            this.insCombo.Size = new System.Drawing.Size(395, 24);
            this.insCombo.TabIndex = 1;
            this.insCombo.SelectedIndexChanged += new System.EventHandler(this.insCombo_SelectedIndexChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(23, 72);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(72, 17);
            this.label2.TabIndex = 2;
            this.label2.Text = "FirstName";
            // 
            // fnameTxt
            // 
            this.fnameTxt.Location = new System.Drawing.Point(134, 72);
            this.fnameTxt.Name = "fnameTxt";
            this.fnameTxt.Size = new System.Drawing.Size(394, 22);
            this.fnameTxt.TabIndex = 3;
            // 
            // lnameTxt
            // 
            this.lnameTxt.Location = new System.Drawing.Point(134, 111);
            this.lnameTxt.Name = "lnameTxt";
            this.lnameTxt.Size = new System.Drawing.Size(394, 22);
            this.lnameTxt.TabIndex = 5;
            // 
            // LastName
            // 
            this.LastName.AutoSize = true;
            this.LastName.Location = new System.Drawing.Point(23, 111);
            this.LastName.Name = "LastName";
            this.LastName.Size = new System.Drawing.Size(72, 17);
            this.LastName.TabIndex = 4;
            this.LastName.Text = "LastName";
            // 
            // salaryTxt
            // 
            this.salaryTxt.Location = new System.Drawing.Point(134, 147);
            this.salaryTxt.Name = "salaryTxt";
            this.salaryTxt.Size = new System.Drawing.Size(394, 22);
            this.salaryTxt.TabIndex = 7;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(23, 152);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(48, 17);
            this.label4.TabIndex = 6;
            this.label4.Text = "Salary";
            // 
            // usernameTxt
            // 
            this.usernameTxt.Location = new System.Drawing.Point(135, 264);
            this.usernameTxt.Name = "usernameTxt";
            this.usernameTxt.Size = new System.Drawing.Size(394, 22);
            this.usernameTxt.TabIndex = 9;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(23, 269);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(55, 17);
            this.label5.TabIndex = 8;
            this.label5.Text = "User ID";
            // 
            // passwordTxt
            // 
            this.passwordTxt.Location = new System.Drawing.Point(134, 304);
            this.passwordTxt.Name = "passwordTxt";
            this.passwordTxt.PasswordChar = '*';
            this.passwordTxt.Size = new System.Drawing.Size(394, 22);
            this.passwordTxt.TabIndex = 11;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(23, 309);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(69, 17);
            this.label6.TabIndex = 10;
            this.label6.Text = "Password";
            // 
            // Depts
            // 
            this.Depts.AutoSize = true;
            this.Depts.Location = new System.Drawing.Point(23, 191);
            this.Depts.Name = "Depts";
            this.Depts.Size = new System.Drawing.Size(89, 17);
            this.Depts.TabIndex = 12;
            this.Depts.Text = "Departments";
            // 
            // label
            // 
            this.label.AutoSize = true;
            this.label.Location = new System.Drawing.Point(23, 232);
            this.label.Name = "label";
            this.label.Size = new System.Drawing.Size(64, 17);
            this.label.TabIndex = 13;
            this.label.Text = "Manager";
            // 
            // depCombo
            // 
            this.depCombo.FormattingEnabled = true;
            this.depCombo.Location = new System.Drawing.Point(134, 184);
            this.depCombo.Name = "depCombo";
            this.depCombo.Size = new System.Drawing.Size(395, 24);
            this.depCombo.TabIndex = 14;
            // 
            // mangCombo
            // 
            this.mangCombo.FormattingEnabled = true;
            this.mangCombo.Location = new System.Drawing.Point(134, 225);
            this.mangCombo.Name = "mangCombo";
            this.mangCombo.Size = new System.Drawing.Size(395, 24);
            this.mangCombo.TabIndex = 15;
            // 
            // addBtn
            // 
            this.addBtn.Location = new System.Drawing.Point(441, 349);
            this.addBtn.Name = "addBtn";
            this.addBtn.Size = new System.Drawing.Size(87, 32);
            this.addBtn.TabIndex = 16;
            this.addBtn.Text = "Add";
            this.addBtn.UseVisualStyleBackColor = true;
            this.addBtn.Click += new System.EventHandler(this.addBtn_Click);
            // 
            // updateBtn
            // 
            this.updateBtn.Location = new System.Drawing.Point(351, 349);
            this.updateBtn.Name = "updateBtn";
            this.updateBtn.Size = new System.Drawing.Size(87, 32);
            this.updateBtn.TabIndex = 17;
            this.updateBtn.Text = "Update";
            this.updateBtn.UseVisualStyleBackColor = true;
            this.updateBtn.Click += new System.EventHandler(this.updateBtn_Click);
            // 
            // deleteBtn
            // 
            this.deleteBtn.Location = new System.Drawing.Point(258, 349);
            this.deleteBtn.Name = "deleteBtn";
            this.deleteBtn.Size = new System.Drawing.Size(87, 32);
            this.deleteBtn.TabIndex = 18;
            this.deleteBtn.Text = "Delete";
            this.deleteBtn.UseVisualStyleBackColor = true;
            this.deleteBtn.Click += new System.EventHandler(this.deleteBtn_Click);
            // 
            // closeBtn
            // 
            this.closeBtn.Location = new System.Drawing.Point(26, 349);
            this.closeBtn.Name = "closeBtn";
            this.closeBtn.Size = new System.Drawing.Size(87, 32);
            this.closeBtn.TabIndex = 19;
            this.closeBtn.Text = "Close";
            this.closeBtn.UseVisualStyleBackColor = true;
            this.closeBtn.Click += new System.EventHandler(this.closeBtn_Click);
            // 
            // ManageInstructor
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(554, 402);
            this.Controls.Add(this.closeBtn);
            this.Controls.Add(this.deleteBtn);
            this.Controls.Add(this.updateBtn);
            this.Controls.Add(this.addBtn);
            this.Controls.Add(this.mangCombo);
            this.Controls.Add(this.depCombo);
            this.Controls.Add(this.label);
            this.Controls.Add(this.Depts);
            this.Controls.Add(this.passwordTxt);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.usernameTxt);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.salaryTxt);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.lnameTxt);
            this.Controls.Add(this.LastName);
            this.Controls.Add(this.fnameTxt);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.insCombo);
            this.Controls.Add(this.label1);
            this.Name = "ManageInstructor";
            this.Text = "ManageInstructor";
            this.Load += new System.EventHandler(this.ManageInstructor_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox insCombo;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox fnameTxt;
        private System.Windows.Forms.TextBox lnameTxt;
        private System.Windows.Forms.Label LastName;
        private System.Windows.Forms.TextBox salaryTxt;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox usernameTxt;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox passwordTxt;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label;
        private System.Windows.Forms.ComboBox depCombo;
        private System.Windows.Forms.ComboBox mangCombo;
        private System.Windows.Forms.Button addBtn;
        private System.Windows.Forms.Button updateBtn;
        private System.Windows.Forms.Button deleteBtn;
        private System.Windows.Forms.Button closeBtn;
        private System.Windows.Forms.Label Depts;
    }
}