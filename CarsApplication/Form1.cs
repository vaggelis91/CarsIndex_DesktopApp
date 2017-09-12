using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Threading;


namespace CarsApplication
{
	public partial class Form1 : Form
	{
		public static List<string> selectedCellValues;
		bool copy_cutFlag;

		FileWriter write_file = new FileWriter();
		FileDeletion delete_file = new FileDeletion();
		FileCopyCutPaste file_ops = new FileCopyCutPaste();
		RecentFilesManagement manage_file = new RecentFilesManagement();
		RootDirectoryOperations root_directory = new RootDirectoryOperations();
		

		public Form1()
		{
			InitializeComponent();
			write_file.Register(DataGrid1);
			delete_file.Register(treeView);
			file_ops.Register(treeView);
			manage_file.Register(treeView);
			manage_file.Register(RecentFilesListBox);
		}

		private void Form1_Load(object sender, EventArgs e)
		{
			this.MinimumSize = new Size(800, 500);
			comboModel.Enabled = false;		
			root_directory.CreateListDirectory(treeView);			
		}

		private void comboBrand_SelectedIndexChanged(object sender, EventArgs e)
		{
			CarModelSelection model = new CarModelSelection();
			model.ShowModels(comboBrand.SelectedIndex, comboBrand.Text, comboModel);
		}

		private void SearchBtn_Click(object sender, EventArgs e)
		{
			QuerySelection build_query = new QuerySelection(comboBrand.Text, comboModel.Text, comboEngine.Text, comboFuel.Text, comboPrice.Text, comboVehicle.Text, comboReused.Text);
			DataGrid1.DataSource = build_query.ExecuteSelectQuery();
		}		

		private void ClearBtn_Click(object sender, EventArgs e)
		{
			//index corresponding to empty value
			comboBrand.SelectedIndex = comboBrand.Items.Count-1;
			comboPrice.SelectedIndex = comboPrice.Items.Count - 1;
			comboFuel.SelectedIndex = comboFuel.Items.Count - 1;
			comboEngine.SelectedIndex = comboEngine.Items.Count - 1;
			comboVehicle.SelectedIndex = comboVehicle.Items.Count - 1;
			comboReused.SelectedIndex = comboReused.Items.Count - 1;
			comboModel.Enabled = false;
		}

		//
		// TREE VIEW CONTROL
		//
		private void treeView_DoubleClick(object sender, EventArgs e)
		{
			manage_file.LoadDirectoriesAndFiles();
		}

		private void treeView_KeyDown(object sender, KeyEventArgs e)
		{
			if (e.KeyCode == Keys.Enter)
			{
				manage_file.LoadDirectoriesAndFiles();
			}
		}

		private void contextMenuStrip2_Opened(object sender, EventArgs e)
		{
			if (treeView.TopNode.IsSelected)
			{
				delToolStripMenuItem.Enabled = false;
				cutToolStripMenuItem.Enabled = false;
				changeRootDirectoryToolStripMenuItem.Enabled = true;
			}
			else 
			{
				delToolStripMenuItem.Enabled = true;
				cutToolStripMenuItem.Enabled = true;
				pasteToolStripMenuItem.Enabled = true;
				changeRootDirectoryToolStripMenuItem.Enabled = false;
			}
		}

		private void refreshToolStripMenuItem_Click(object sender, EventArgs e)
		{
			root_directory.CreateListDirectory(treeView);
		}

		private void changeRootDirectoryToolStripMenuItem_Click(object sender, EventArgs e)
		{
			FolderBrowserDialog folderDialog = new FolderBrowserDialog();
			if (folderDialog.ShowDialog() == DialogResult.OK)
			{
				RootDirectoryOperations.treeViewRootDirectoryPath = folderDialog.SelectedPath;
				root_directory.CreateListDirectory(treeView);
			}
		}

		private void delToolStripMenuItem_Click(object sender, EventArgs e)
		{
			delete_file.DeleteFile();
		}

		private void copyToolStripMenuItem_Click(object sender, EventArgs e)
		{
			copy_cutFlag = false;
			file_ops.CopyCutFile();
		}

		private void cutToolStripMenuItem_Click(object sender, EventArgs e)
		{
			copy_cutFlag = true;
			file_ops.CopyCutFile();
		}

		private void pasteToolStripMenuItem_Click(object sender, EventArgs e)
		{
			file_ops.PasteFile(copy_cutFlag);
		}

		private void sendEmailToolStripMenuItem_Click(object sender, EventArgs e)
		{
			MailForm sentMail = new MailForm();
			sentMail.Show();		
		}

		//
		// DATA GRID 
		//
		private void DataGrid1_MouseClick(object sender, MouseEventArgs e)
		{
			if (e.Button == MouseButtons.Right)
			{
				int currentMouseOverRow = DataGrid1.HitTest(e.X, e.Y).RowIndex;
				if (DataGrid1.SelectedCells.Count > 0 && currentMouseOverRow != -1)
				{
					dataGridMenuStrip.Show(DataGrid1, new Point(e.X, e.Y));
				}
			}
		}

		private void saveToolStripMenuItem_Click(object sender, EventArgs e)
		{
			if (DataGrid1.SelectedRows.Count > 0)
			{
				write_file.AppendText();
			}
			else
			{
				MessageBox.Show("First select the row/s you want to save.", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
			}
		}

		private void saveAsToolStripMenuItem_Click(object sender, EventArgs e)
		{
			if (DataGrid1.SelectedRows.Count > 0)
			{
				write_file.WriteNewText();
			}
			else
			{
				MessageBox.Show("First select the row/s you want to save.", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
			}
		}

		private void newEntryToolStripMenuItem_Click(object sender, EventArgs e)
		{
			InsertForm insert_form = new InsertForm();
			insert_form.ShowDialog();
		}

		private void updateToolStripMenuItem_Click(object sender, EventArgs e)
		{
			selectedCellValues = new List<string>();
			if (DataGrid1.SelectedRows.Count == 1)
			{
				selectedCellValues.Add(DataGrid1.SelectedCells[0].Value.ToString());
				selectedCellValues.Add(DataGrid1.SelectedCells[1].Value.ToString()); 
				selectedCellValues.Add(DataGrid1.SelectedCells[2].Value.ToString());
				selectedCellValues.Add(DataGrid1.SelectedCells[3].Value.ToString());
				selectedCellValues.Add(DataGrid1.SelectedCells[4].Value.ToString());
				selectedCellValues.Add(DataGrid1.SelectedCells[5].Value.ToString());
				selectedCellValues.Add(DataGrid1.SelectedCells[6].Value.ToString());
				selectedCellValues.Add(DataGrid1.SelectedCells[7].Value.ToString());
				selectedCellValues.Add(DataGrid1.SelectedCells[8].Value.ToString());
				selectedCellValues.Add(DataGrid1.SelectedCells[9].Value.ToString());
				selectedCellValues.Add(DataGrid1.SelectedCells[10].Value.ToString());
				selectedCellValues.Add(DataGrid1.SelectedCells[11].Value.ToString());
				selectedCellValues.Add(DataGrid1.SelectedCells[12].Value.ToString());
				selectedCellValues.Add(comboReused.Text);

				UpdateForm update_form = new UpdateForm();
				update_form.ShowDialog(); 
			}
			else
			{
				MessageBox.Show("Select a single row to update.", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
			}
		}

		private void deleteToolStripMenuItem_Click(object sender, EventArgs e)
		{
			if (DataGrid1.SelectedRows.Count > 0)
			{
				QueryDeletion build_query = new QueryDeletion(DataGrid1);
				build_query.ExecuteDeleteQuery();
			}
			else
			{
				MessageBox.Show("Select the respective row in order to delete it.", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
			}		
		}

		private void DataGrid1_KeyDown(object sender, KeyEventArgs e)
		{
			if (e.KeyCode == Keys.Delete)
			{
				if (MessageBox.Show("Are you sure you want to delete the selected items?", "Warning", MessageBoxButtons.OKCancel, MessageBoxIcon.Warning) == DialogResult.OK)
				{
					QueryDeletion build_query = new QueryDeletion(DataGrid1);
					build_query.ExecuteDeleteQuery();
				}
			}
		}

		private void loadDataFromFileToolStripMenuItem_Click(object sender, EventArgs e)
		{
			FileReader read_file = new FileReader();
			read_file.OpenFileToRead();
		}

		private void refreshToolStripMenuItem1_Click(object sender, EventArgs e)
		{
			QuerySelection build_query = new QuerySelection(comboBrand.Text, comboModel.Text, comboEngine.Text, comboFuel.Text, comboPrice.Text, comboVehicle.Text, comboReused.Text);
			DataGrid1.DataSource = build_query.ExecuteSelectQuery();
		}

		//
		// LIST BOX
		//
		private void RecentFilesListBox_MouseDoubleClick(object sender, MouseEventArgs e)
		{
			manage_file.LoadFilesFromListBox();
		}

		private void RecentFilesMenuStrip_Opening(object sender, CancelEventArgs e)
		{
			if (RecentFilesListBox.SelectedIndex == 0)
			{
				clearAllToolStripMenuItem.Enabled = true;
				clearToolStripMenuItem.Enabled = false;
			}
			else
			{
				clearAllToolStripMenuItem.Enabled = false;
				clearToolStripMenuItem.Enabled = true;
			}
		}

		private void clearAllToolStripMenuItem_Click(object sender, EventArgs e)
		{
			manage_file.RemoveAllItemsFromListBox();
		}

		private void clearToolStripMenuItem_Click(object sender, EventArgs e)
		{
			manage_file.RemoveSelectedItemFromListBox();
		}

		private void showDiagrammsToolStripMenuItem_Click(object sender, EventArgs e)
		{
			DiagramsForm diagram = new DiagramsForm();
			diagram.Show();
		}


	}

}
