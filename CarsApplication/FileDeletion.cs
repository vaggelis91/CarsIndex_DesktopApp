using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CarsApplication
{
	class FileDeletion
	{
		TreeView treeView;

		public void Register(TreeView treeView)
		{
			this.treeView = treeView;
		}

		public void DeleteFile()
		{
			try
			{
				File.Delete(RootDirectoryOperations.treeViewRootDirectoryPath + treeView.SelectedNode.FullPath.Remove(0, treeView.SelectedNode.FullPath.IndexOf('\\')));
				treeView.Nodes.Remove(treeView.SelectedNode);
			}
			catch (NullReferenceException)
			{
				MessageBox.Show("You haven't selected a file or a folder to delete.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
			}
		}



	}
}
