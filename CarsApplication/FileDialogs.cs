using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CarsApplication
{
	class FileDialogs
	{
		public SaveFileDialog SaveDialog()
		{
			SaveFileDialog sDialog = new SaveFileDialog();
			sDialog.Title = "Save File";
			sDialog.InitialDirectory = "C:\\";
			sDialog.Filter = "Text Files|*.txt";
			sDialog.RestoreDirectory = true;
			sDialog.ValidateNames = true;
			return sDialog;
		}

		public OpenFileDialog OpenDialog()
		{
			OpenFileDialog oDialog = new OpenFileDialog();
			oDialog.Title = "Save File";
			oDialog.InitialDirectory = "C:\\";
			oDialog.Filter = "Text Files|*.txt|CSV Files|*.csv";
			oDialog.ValidateNames = true;
			return oDialog;
		}




	}
}
