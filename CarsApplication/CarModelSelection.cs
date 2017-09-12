using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CarsApplication
{
	class CarModelSelection
	{
		public void ShowModels(int brandIndexSelection, string brand, ComboBox modelComboBox)
		{
			if (!string.IsNullOrWhiteSpace(brand))
			{
				modelComboBox.Enabled = true;
				//clear previous items
				modelComboBox.Items.Clear();

				switch (brandIndexSelection)
				{
					case 0:
						modelComboBox.Items.Add("GT");
						modelComboBox.Items.Add("Giulietta");
						modelComboBox.Items.Add("8C Competizione");
						modelComboBox.Items.Add("");
						break;
					case 1:
						modelComboBox.Items.Add("A1");
						modelComboBox.Items.Add("A3");
						modelComboBox.Items.Add("R8");
						modelComboBox.Items.Add("");
						break;
					case 2:
						modelComboBox.Items.Add("M4");
						modelComboBox.Items.Add("Z8");
						modelComboBox.Items.Add("");
						break;
					case 3:
						modelComboBox.Items.Add("C3");
						modelComboBox.Items.Add("");
						break;
					case 4:
						modelComboBox.Items.Add("Bravo");
						modelComboBox.Items.Add("");
						break;
					case 5:
						modelComboBox.Items.Add("Freestyle");
						modelComboBox.Items.Add("Mustang");
						modelComboBox.Items.Add("");
						break;
					case 6:
						modelComboBox.Items.Add("F-type");
						modelComboBox.Items.Add("");
						break;
					case 7:
						modelComboBox.Items.Add("Grand Cherokee");
						modelComboBox.Items.Add("");
						break;
					case 8:
						modelComboBox.Items.Add("Delta");
						modelComboBox.Items.Add("");
						break;
					case 9:
						modelComboBox.Items.Add("Quattroporte");
						modelComboBox.Items.Add("");
						break;
					case 10:
						modelComboBox.Items.Add("GT-R");
						modelComboBox.Items.Add("NP 300 Pick up");
						modelComboBox.Items.Add("X-Trail");
						modelComboBox.Items.Add("");
						break;
					case 11:
						modelComboBox.Items.Add("Cascada");
						modelComboBox.Items.Add("Rapid");
						modelComboBox.Items.Add("");
						break;
					case 12:
						modelComboBox.Items.Add("207");
						modelComboBox.Items.Add("");
						break;
					case 13:
						modelComboBox.Items.Add("Toledo");
						modelComboBox.Items.Add("");
						break;
					case 14:
						modelComboBox.Items.Add("Octavia");
						modelComboBox.Items.Add("Outback");
						modelComboBox.Items.Add("");
						break;
					default:
						break;
				}
			}
			else
			{
				modelComboBox.SelectedIndex = modelComboBox.Items.Count - 1;
				modelComboBox.Enabled = false;
			}
		}




	}
}
