using System;
using System.IO;
using System.Windows.Forms;
using System.Net.Mail;
using System.Threading;

namespace CarsApplication
{
    public partial class MailForm : Form
    {             
		string attachmentFileName { get; set; }

		public MailForm()
        {
            InitializeComponent();
		}

		private void Mail_Form_Load(object sender, EventArgs e)
		{
			fromEmailAddress.Enabled = false;
		}

		private void Mail_Form_Activated(object sender, EventArgs e)
		{
			fromEmailAddress.Text = ChangeEmailAccount.setNewEmail;
		}

		private void SendBtn_Click(object sender, EventArgs e)
        {
			Validation validate = new Validation();
			
            if (validate.ValidateEmail(ChangeEmailAccount.setNewEmail) && validate.ValidateEmail(toEmailAddress.Text))
            {
				SendBtn.Enabled = false;
				SendEmail();
			}
            else
            {
                MessageBox.Show("Check the email address and password.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);               
            }
            SendBtn.Enabled = true;
        }

		private void SendEmail()
		{
			try
			{
				MailMessage mail = new MailMessage();
				SmtpClient SmtpServer = new SmtpClient(ChangeEmailAccount.accountSelection);
				mail.From = new MailAddress(ChangeEmailAccount.setNewEmail);
				mail.To.Add(toEmailAddress.Text);
				mail.Subject = emailSubject.Text;
				mail.Body = richTextBox1.Text;

				if (!string.IsNullOrEmpty(attachmentFileName))
				{
					Attachment attachment;
					attachment = new Attachment(attachmentFileName);
					mail.Attachments.Add(attachment);
				}

				SmtpServer.Port = 587;
				SmtpServer.Credentials = new System.Net.NetworkCredential(ChangeEmailAccount.setNewEmail, ChangeEmailAccount.setNewEmail_password);
				SmtpServer.EnableSsl = true;
				SmtpServer.Send(mail);
				MessageBox.Show("Mail was sent.", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
			}
			catch (Exception ex)
			{
				MessageBox.Show(ex.ToString());
			}
		}

        private void AttachmentBtn_Click(object sender, EventArgs e)
        {
			FileDialogs dialog = new FileDialogs();	
			OpenFileDialog openDialog = dialog.OpenDialog();

            if (openDialog.ShowDialog() == DialogResult.OK)
            {
				attachmentFileName = openDialog.FileName;
                attachFileLbl.Text = Path.GetFileName(attachmentFileName);
            }
        }

		private void changeAccountBtn_Click(object sender, EventArgs e)
		{
			ChangeEmailAccount change_account = new ChangeEmailAccount();
			change_account.ShowDialog();
		}




	}
}
