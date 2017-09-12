namespace CarsApplication
{
    partial class MailForm
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
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MailForm));
			this.SendBtn = new System.Windows.Forms.Button();
			this.label1 = new System.Windows.Forms.Label();
			this.fromEmailAddress = new System.Windows.Forms.TextBox();
			this.richTextBox1 = new System.Windows.Forms.RichTextBox();
			this.label2 = new System.Windows.Forms.Label();
			this.emailSubject = new System.Windows.Forms.TextBox();
			this.label3 = new System.Windows.Forms.Label();
			this.toEmailAddress = new System.Windows.Forms.TextBox();
			this.AttachmentBtn = new System.Windows.Forms.Button();
			this.attachFileLbl = new System.Windows.Forms.Label();
			this.changeAccountBtn = new System.Windows.Forms.Button();
			this.SuspendLayout();
			// 
			// SendBtn
			// 
			this.SendBtn.Location = new System.Drawing.Point(328, 295);
			this.SendBtn.Name = "SendBtn";
			this.SendBtn.Size = new System.Drawing.Size(55, 23);
			this.SendBtn.TabIndex = 0;
			this.SendBtn.Text = "Send";
			this.SendBtn.UseVisualStyleBackColor = true;
			this.SendBtn.Click += new System.EventHandler(this.SendBtn_Click);
			// 
			// label1
			// 
			this.label1.AutoSize = true;
			this.label1.Location = new System.Drawing.Point(25, 30);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(30, 13);
			this.label1.TabIndex = 1;
			this.label1.Text = "From";
			// 
			// fromEmailAddress
			// 
			this.fromEmailAddress.Location = new System.Drawing.Point(61, 27);
			this.fromEmailAddress.Name = "fromEmailAddress";
			this.fromEmailAddress.Size = new System.Drawing.Size(322, 20);
			this.fromEmailAddress.TabIndex = 2;
			// 
			// richTextBox1
			// 
			this.richTextBox1.Location = new System.Drawing.Point(61, 167);
			this.richTextBox1.Name = "richTextBox1";
			this.richTextBox1.Size = new System.Drawing.Size(322, 121);
			this.richTextBox1.TabIndex = 3;
			this.richTextBox1.Text = "";
			// 
			// label2
			// 
			this.label2.AutoSize = true;
			this.label2.Location = new System.Drawing.Point(35, 63);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(20, 13);
			this.label2.TabIndex = 4;
			this.label2.Text = "To";
			// 
			// emailSubject
			// 
			this.emailSubject.Location = new System.Drawing.Point(61, 93);
			this.emailSubject.Name = "emailSubject";
			this.emailSubject.Size = new System.Drawing.Size(322, 20);
			this.emailSubject.TabIndex = 6;
			// 
			// label3
			// 
			this.label3.AutoSize = true;
			this.label3.Location = new System.Drawing.Point(12, 96);
			this.label3.Name = "label3";
			this.label3.Size = new System.Drawing.Size(43, 13);
			this.label3.TabIndex = 7;
			this.label3.Text = "Subject";
			// 
			// toEmailAddress
			// 
			this.toEmailAddress.Location = new System.Drawing.Point(61, 60);
			this.toEmailAddress.Name = "toEmailAddress";
			this.toEmailAddress.Size = new System.Drawing.Size(322, 20);
			this.toEmailAddress.TabIndex = 8;
			// 
			// AttachmentBtn
			// 
			this.AttachmentBtn.Location = new System.Drawing.Point(61, 128);
			this.AttachmentBtn.Name = "AttachmentBtn";
			this.AttachmentBtn.Size = new System.Drawing.Size(118, 23);
			this.AttachmentBtn.TabIndex = 9;
			this.AttachmentBtn.Text = "Add Attachment";
			this.AttachmentBtn.UseVisualStyleBackColor = true;
			this.AttachmentBtn.Click += new System.EventHandler(this.AttachmentBtn_Click);
			// 
			// attachFileLbl
			// 
			this.attachFileLbl.AutoSize = true;
			this.attachFileLbl.Location = new System.Drawing.Point(185, 133);
			this.attachFileLbl.Name = "attachFileLbl";
			this.attachFileLbl.Size = new System.Drawing.Size(0, 13);
			this.attachFileLbl.TabIndex = 10;
			// 
			// changeAccountBtn
			// 
			this.changeAccountBtn.Location = new System.Drawing.Point(389, 27);
			this.changeAccountBtn.Name = "changeAccountBtn";
			this.changeAccountBtn.Size = new System.Drawing.Size(22, 20);
			this.changeAccountBtn.TabIndex = 11;
			this.changeAccountBtn.Text = "...";
			this.changeAccountBtn.TextAlign = System.Drawing.ContentAlignment.TopCenter;
			this.changeAccountBtn.UseVisualStyleBackColor = true;
			this.changeAccountBtn.Click += new System.EventHandler(this.changeAccountBtn_Click);
			// 
			// Mail_Form
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(423, 341);
			this.Controls.Add(this.changeAccountBtn);
			this.Controls.Add(this.attachFileLbl);
			this.Controls.Add(this.AttachmentBtn);
			this.Controls.Add(this.toEmailAddress);
			this.Controls.Add(this.label3);
			this.Controls.Add(this.emailSubject);
			this.Controls.Add(this.label2);
			this.Controls.Add(this.richTextBox1);
			this.Controls.Add(this.fromEmailAddress);
			this.Controls.Add(this.label1);
			this.Controls.Add(this.SendBtn);
			this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
			this.MaximizeBox = false;
			this.Name = "Mail_Form";
			this.Text = "Mail Form";
			this.Activated += new System.EventHandler(this.Mail_Form_Activated);
			this.Load += new System.EventHandler(this.Mail_Form_Load);
			this.ResumeLayout(false);
			this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button SendBtn;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox fromEmailAddress;
        private System.Windows.Forms.RichTextBox richTextBox1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox emailSubject;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox toEmailAddress;
        private System.Windows.Forms.Button AttachmentBtn;
        private System.Windows.Forms.Label attachFileLbl;
		private System.Windows.Forms.Button changeAccountBtn;
	}
}