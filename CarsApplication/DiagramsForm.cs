using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CarsApplication
{
	public partial class DiagramsForm : Form
	{
		public DiagramsForm()
		{
			InitializeComponent();
		}

		private void chart1_Click(object sender, EventArgs e)
		{

		}

		private void DiagramsForm_Load(object sender, EventArgs e)
		{
			conditionChart.Series["Automobiles"].Points.AddXY("New Automobiles", 50);
			conditionChart.Series["Automobiles"].Points.AddXY("Reused Automobiles", 45);

			pricesChart.Series["Price"].XValueMember = "Year";
			//pricesChart.Series["Price"].XValueType = "3000 - 10000";
			//pricesChart.Series["Price"].Points.AddXY("3000 - 10000", 10);
			//pricesChart.Series["Price"].Points.AddXY("10000 - 15000", 40);
			//pricesChart.Series["Price"].Points.AddXY("15000 - 20000", 24);
			//pricesChart.Series["Price"].Points.AddXY("20000 - 30000", 11);
			//pricesChart.Series["Price"].Points.AddXY("30000 - 50000", 70);
			//pricesChart.Series["Price"].Points.AddXY("50000 - 100000", 2);
			//pricesChart.Series["Price"].Points.AddXY("100000 - 200000", 0);
			//pricesChart.Series["Price"].Points.AddXY("200000 - >", 1);
		}
	}
}
