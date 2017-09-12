using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CarsApplication
{
	class RootDirectoryOperations
	{
		public static string treeViewRootDirectoryPath { get; set; } = @"C:\Users\vagge\Documents\MyFolder";

		public void CreateListDirectory(TreeView treeView)
		{
			try
			{
				var rootDirectoryInfo = new DirectoryInfo(treeViewRootDirectoryPath);
				treeView.Nodes.Clear();
				treeView.Nodes.Add(CreateDirectoryNode(rootDirectoryInfo));
			}
			catch (UnauthorizedAccessException)
			{
				MessageBox.Show("Acccess to path denied. Select other directory.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
			}
		}

		private TreeNode CreateDirectoryNode(DirectoryInfo rootDirectoryInfo)
		{
			var directoryNode = new TreeNode(rootDirectoryInfo.Name);
			foreach (var directory_node in rootDirectoryInfo.GetDirectories())
			{
				directoryNode.Nodes.Add(CreateDirectoryNode(directory_node));
			}
			foreach (var directory_file in rootDirectoryInfo.GetFiles())
			{
				directoryNode.Nodes.Add(new TreeNode(directory_file.Name));
			}
			return directoryNode;
		}



	}
}
