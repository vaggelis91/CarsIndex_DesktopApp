using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CarsApplication
{

	class FileCopyCutPaste
	{
		TreeView treeView;
		string sourcePathForSelectedFile;
		string selectedFileName;

		public void Register(TreeView treeView)
		{
			this.treeView = treeView;
		}

		public void CopyCutFile()
		{
			try
			{
				sourcePathForSelectedFile = GetSelectedNodeFullPath();
				selectedFileName = treeView.SelectedNode.Text;
			}
			catch (NullReferenceException)
			{
				MessageBox.Show("You haven't selected a file or a folder.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
			}
		}

		public void PasteFile(bool copyOrPaste)
		{
			try
			{
				string destinationPathForSelectedFolder = GetSelectedNodeFullPath();
				int removeRootDirectory = sourcePathForSelectedFile.IndexOf('\\');
				if (copyOrPaste)
				{
					File.Move(RootDirectoryOperations.treeViewRootDirectoryPath + sourcePathForSelectedFile.Remove(0, removeRootDirectory), RootDirectoryOperations.treeViewRootDirectoryPath + destinationPathForSelectedFolder.Remove(0, removeRootDirectory) + "\\" + selectedFileName);
				}
				else
				{
					File.Copy(RootDirectoryOperations.treeViewRootDirectoryPath + sourcePathForSelectedFile.Remove(0, removeRootDirectory), RootDirectoryOperations.treeViewRootDirectoryPath + destinationPathForSelectedFolder.Remove(0, removeRootDirectory) + "\\" + selectedFileName);
				}
			}
			catch (NullReferenceException)
			{
				MessageBox.Show("First you must copy or cut a file or folder.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
			}
			catch (Exception)
			{
				MessageBox.Show("Select the respective directory. File overwriting is not permitted.", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
			}
		}

		private string GetSelectedNodeFullPath()
		{
			return treeView.SelectedNode.FullPath;
		}



	}



	
}
