using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CarsApplication
{
	class FileWriter 
	{
		FileDialogs dialog = new FileDialogs();
		RecentFilesManagement add_file = new RecentFilesManagement();
		DataGridView dataGrid;

		public void Register(DataGridView obj)
		{
			dataGrid = obj;
		}

		public void AppendText()
		{			
			SaveFileDialog saveDialog = dialog.SaveDialog();
			saveDialog.OverwritePrompt = false;
			if (saveDialog.ShowDialog() == DialogResult.OK)
			{
				File.AppendAllText(saveDialog.FileName, GetTextFromDataGrid());
				add_file.AddFileToRecentFiles(saveDialog);
			}	
		}

		public void WriteNewText()
		{
			SaveFileDialog saveAsDialog = dialog.SaveDialog();
			if (saveAsDialog.ShowDialog() == DialogResult.OK)
			{
				File.WriteAllText(saveAsDialog.FileName, GetTextFromDataGrid());
				add_file.AddFileToRecentFiles(saveAsDialog);
			}
		}

		private string GetTextFromDataGrid()
		{
			StringBuilder selectedDataGridText = new StringBuilder();

			foreach (DataGridViewRow Datarow in dataGrid.SelectedRows)
			{
				selectedDataGridText.Append(Datarow.Cells[1].Value).Append(',');
				selectedDataGridText.Append(Datarow.Cells[2].Value).Append(',');
				selectedDataGridText.Append(Datarow.Cells[3].Value).Append(',');
				selectedDataGridText.Append(Datarow.Cells[4].Value).Append(',');
				selectedDataGridText.Append(Datarow.Cells[5].Value).Append(',');
				selectedDataGridText.Append(Datarow.Cells[6].Value).Append(',');
				selectedDataGridText.Append(Datarow.Cells[7].Value).Append(',');
				selectedDataGridText.Append(Datarow.Cells[8].Value).Append(',');
				selectedDataGridText.Append(Datarow.Cells[9].Value).Append(',');
				selectedDataGridText.Append(Datarow.Cells[10].Value).Append(',');
				selectedDataGridText.Append(Datarow.Cells[11].Value).Append(',');
				selectedDataGridText.AppendLine(Datarow.Cells[12].Value.ToString());
			}
			return selectedDataGridText.ToString();
		}



	}
}
