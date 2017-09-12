using System;
using System.Windows.Forms;

namespace CarsApplication
{
	public partial class ChangeEmailAccount : Form
	{
		public static string setNewEmail { get; set; }
		public static string setNewEmail_password { get; set; }
		public static string accountSelection { get; set; }

		public ChangeEmailAccount()
		{
			InitializeComponent();
		}

		private void ChangeEmailAccount_Load(object sender, EventArgs e)
		{
			selectAccountComboBox.SelectedIndex = 1;
		}	

		private void saveAccountBtn_Click(object sender, EventArgs e)
		{			
			ValidateChangeAccount();
		}

		private void ValidateChangeAccount()
		{
			Validation validate = new Validation();
			if (validate.ValidateEmail(newEmail.Text) && emailPassword.TextLength > 0)
			{
				setNewEmail = newEmail.Text;
				setNewEmail_password = emailPassword.Text;
				accountSelection = GetSMTPServer();
				MessageBox.Show("Account saved.");
				this.Close();
			}
			else
			{
				MessageBox.Show("Error occured. Check your credentials.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
			}
		}

		private string GetSMTPServer()
		{
			if (selectAccountComboBox.SelectedIndex == 1)
			{
				return "smtp.live.com";
			}
			else
			{
				return "smtp.gmail.com";
			}
		}

		private void ChangeEmailAccount_FormClosing(object sender, FormClosingEventArgs e)
		{
			Validation validate = new Validation();
			if (!validate.ValidateEmail(newEmail.Text) || emailPassword.TextLength == 0)
			{
				if (MessageBox.Show("Data is not valid. Do you want to procceed?", "Incorrect Data", MessageBoxButtons.OKCancel, MessageBoxIcon.Warning) == DialogResult.Cancel)
				{
					e.Cancel = true;
				}
			}
		}



	}
}
