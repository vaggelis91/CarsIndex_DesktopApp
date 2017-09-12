namespace CarsApplication
{
	partial class ChangeEmailAccount
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
			this.saveAccountBtn = new System.Windows.Forms.Button();
			this.label1 = new System.Windows.Forms.Label();
			this.newEmail = new System.Windows.Forms.TextBox();
			this.selectAccountComboBox = new System.Windows.Forms.ComboBox();
			this.label2 = new System.Windows.Forms.Label();
			this.label3 = new System.Windows.Forms.Label();
			this.emailPassword = new System.Windows.Forms.TextBox();
			this.SuspendLayout();
			// 
			// saveAccountBtn
			// 
			this.saveAccountBtn.Location = new System.Drawing.Point(203, 149);
			this.saveAccountBtn.Name = "saveAccountBtn";
			this.saveAccountBtn.Size = new System.Drawing.Size(55, 23);
			this.saveAccountBtn.TabIndex = 0;
			this.saveAccountBtn.Text = "Save";
			this.saveAccountBtn.UseVisualStyleBackColor = true;
			this.saveAccountBtn.Click += new System.EventHandler(this.saveAccountBtn_Click);
			// 
			// label1
			// 
			this.label1.AutoSize = true;
			this.label1.Location = new System.Drawing.Point(51, 52);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(32, 13);
			this.label1.TabIndex = 1;
			this.label1.Text = "Email";
			// 
			// newEmail
			// 
			this.newEmail.Location = new System.Drawing.Point(110, 49);
			this.newEmail.Name = "newEmail";
			this.newEmail.Size = new System.Drawing.Size(148, 20);
			this.newEmail.TabIndex = 2;
			// 
			// selectAccountComboBox
			// 
			this.selectAccountComboBox.FormattingEnabled = true;
			this.selectAccountComboBox.Items.AddRange(new object[] {
            "Gmail",
            "Hotmail"});
			this.selectAccountComboBox.Location = new System.Drawing.Point(110, 112);
			this.selectAccountComboBox.Name = "selectAccountComboBox";
			this.selectAccountComboBox.Size = new System.Drawing.Size(148, 21);
			this.selectAccountComboBox.TabIndex = 3;
			// 
			// label2
			// 
			this.label2.AutoSize = true;
			this.label2.Location = new System.Drawing.Point(51, 80);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(53, 13);
			this.label2.TabIndex = 4;
			this.label2.Text = "Password";
			// 
			// label3
			// 
			this.label3.AutoSize = true;
			this.label3.Location = new System.Drawing.Point(24, 115);
			this.label3.Name = "label3";
			this.label3.Size = new System.Drawing.Size(80, 13);
			this.label3.TabIndex = 5;
			this.label3.Text = "Select Account";
			// 
			// emailPassword
			// 
			this.emailPassword.Location = new System.Drawing.Point(110, 77);
			this.emailPassword.Name = "emailPassword";
			this.emailPassword.Size = new System.Drawing.Size(148, 20);
			this.emailPassword.TabIndex = 6;
			// 
			// ChangeEmailAccount
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(293, 222);
			this.Controls.Add(this.emailPassword);
			this.Controls.Add(this.label3);
			this.Controls.Add(this.label2);
			this.Controls.Add(this.selectAccountComboBox);
			this.Controls.Add(this.newEmail);
			this.Controls.Add(this.label1);
			this.Controls.Add(this.saveAccountBtn);
			this.Name = "ChangeEmailAccount";
			this.Text = "Change Account";
			this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.ChangeEmailAccount_FormClosing);
			this.Load += new System.EventHandler(this.ChangeEmailAccount_Load);
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.Button saveAccountBtn;
		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.TextBox newEmail;
		private System.Windows.Forms.ComboBox selectAccountComboBox;
		private System.Windows.Forms.Label label2;
		private System.Windows.Forms.Label label3;
		private System.Windows.Forms.TextBox emailPassword;
	}
}