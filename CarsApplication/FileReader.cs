using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CarsApplication
{
	class FileReader
	{
		FileDialogs dialog = new FileDialogs();

		public void OpenFileToRead()
		{
			OpenFileDialog openDialog = dialog.OpenDialog();
			if (openDialog.ShowDialog() == DialogResult.OK)
			{
				GetDataFromFile(openDialog.FileName);
			}
		}

		private void GetDataFromFile(string fileName)
		{
			InsertForm.showInsertMessageFlag = false;
			StringBuilder insertQuery = new StringBuilder();

			try
			{
				//In order for update query to succeed the user must manually add Yes or No to the end of the file that wants to load.
				//These values correspond to the condition of the vehicle (reused or not).
				foreach (string line in File.ReadLines(fileName, Encoding.UTF8))
				{
					string[] lineArray = line.Split(',');
					for (int i = 0; i < lineArray.Length; i++)
					{
						if (i == 3 || i == 9 || i == 11)
						{
							insertQuery.Append(Convert.ToInt32(lineArray[i])).Append(",");
						}
						else
						{
							insertQuery.Append("'").Append(lineArray[i]).Append("',");
						}
					}				
					//remove the last comma
					insertQuery.Remove(insertQuery.Length - 1, 1);
					//excecute insert query
					InsertDataToDataBase(insertQuery);
					//clear stringbuilder for the next insertion.
					insertQuery.Clear();
				}
				MessageBox.Show(QueryInsertion.rowsCount.ToString() + " rows inserted successfully.", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
			}
			catch (Exception)
			{
				MessageBox.Show("Invalid data. Check the source file again.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
			}
			//set rowsCount to 0 for the next file data insertion.
			QueryInsertion.rowsCount = 0;
		}

		private void InsertDataToDataBase(StringBuilder insertQuery)
		{
			QueryInsertion build_query = new QueryInsertion(insertQuery);
			build_query.ExecuteInsertQuery();
		}




	}
}
