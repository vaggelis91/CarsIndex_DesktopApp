using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CarsApplication
{
	class RecentFilesManagement
	{
		Dictionary<string, string> recentFilesDictionary = new Dictionary<string, string>();
		TreeView treeView;
		ListBox recentFilesListBox;

		public void Register(TreeView obj)
		{
			treeView = obj;
		}

		public void Register(ListBox obj)
		{
			recentFilesListBox = obj;
		}

		public void LoadDirectoriesAndFiles()
		{
			if (treeView.TopNode.IsSelected)
			{
				Process.Start(RootDirectoryOperations.treeViewRootDirectoryPath);
			}
			else
			{
				if (File.Exists(RootDirectoryOperations.treeViewRootDirectoryPath + treeView.SelectedNode.FullPath.Remove(0, treeView.SelectedNode.FullPath.IndexOf('\\'))))
				{
					AddFileToRecentSection(treeView.SelectedNode.Text, treeView.SelectedNode.FullPath);
					Process.Start(RootDirectoryOperations.treeViewRootDirectoryPath + treeView.SelectedNode.FullPath.Remove(0, treeView.SelectedNode.FullPath.IndexOf('\\')));
				}
			}
		}

		private void AddFileToRecentSection(string addFileNameToRecentSection, string addPathToRecentFilesDictionary)
		{
			if (!recentFilesDictionary.ContainsKey(treeView.SelectedNode.Text))
			{
				//store into dictionary the file name and its full path e.g myFile.txt , C://... 
				recentFilesDictionary.Add(treeView.SelectedNode.Text, RootDirectoryOperations.treeViewRootDirectoryPath + addPathToRecentFilesDictionary.Remove(0, addPathToRecentFilesDictionary.IndexOf('\\')));
				recentFilesListBox.Items.Add(addFileNameToRecentSection);
			}
		}

		public void AddFileToRecentFiles(SaveFileDialog saveDialog)
		{
			if (!recentFilesDictionary.ContainsKey(Path.GetFileName(saveDialog.FileName)))
			{
				recentFilesDictionary.Add(Path.GetFileName(saveDialog.FileName), saveDialog.FileName);
				recentFilesListBox.Items.Add(Path.GetFileName(saveDialog.FileName));
			}
		}

		public void LoadFilesFromListBox()
		{
			if (recentFilesListBox.SelectedIndex > 0)
			{
				foreach (KeyValuePair<string, string> dictValue in recentFilesDictionary)
				{
					if (recentFilesListBox.SelectedItem.ToString() == dictValue.Key)
					{
						Process.Start(dictValue.Value);
					}
				}
			}
		}

		public void RemoveAllItemsFromListBox()
		{
			for (int i = recentFilesListBox.Items.Count - 1; i > 0; i--)
			{
				recentFilesDictionary.Remove(recentFilesListBox.Items[i].ToString());
				recentFilesListBox.Items.RemoveAt(i);
			}
		}

		public void RemoveSelectedItemFromListBox()
		{
			if (recentFilesListBox.SelectedIndex > 0)
			{
				recentFilesDictionary.Remove(recentFilesListBox.SelectedItem.ToString());
				recentFilesListBox.Items.RemoveAt(recentFilesListBox.SelectedIndex);
			}
		}



	}
}
