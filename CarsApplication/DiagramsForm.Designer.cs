namespace CarsApplication
{
	partial class DiagramsForm
	{
		/// <summary>
		/// Required designer variable.
		/// </summary>
		private System.ComponentModel.IContainer components = null;

		/// <summary>
		/// Clean up any resources being used.
		/// </summary>
		/// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
		protected override void Dispose(bool disposing)
		{
			if (disposing && (components != null))
			{
				components.Dispose();
			}
			base.Dispose(disposing);
		}

		#region Windows Form Designer generated code

		/// <summary>
		/// Required method for Designer support - do not modify
		/// the contents of this method with the code editor.
		/// </summary>
		private void InitializeComponent()
		{
			System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea1 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
			System.Windows.Forms.DataVisualization.Charting.Legend legend1 = new System.Windows.Forms.DataVisualization.Charting.Legend();
			System.Windows.Forms.DataVisualization.Charting.Series series1 = new System.Windows.Forms.DataVisualization.Charting.Series();
			System.Windows.Forms.DataVisualization.Charting.Title title1 = new System.Windows.Forms.DataVisualization.Charting.Title();
			System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea2 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
			System.Windows.Forms.DataVisualization.Charting.Legend legend2 = new System.Windows.Forms.DataVisualization.Charting.Legend();
			System.Windows.Forms.DataVisualization.Charting.LegendCellColumn legendCellColumn1 = new System.Windows.Forms.DataVisualization.Charting.LegendCellColumn();
			System.Windows.Forms.DataVisualization.Charting.Series series2 = new System.Windows.Forms.DataVisualization.Charting.Series();
			System.Windows.Forms.DataVisualization.Charting.Title title2 = new System.Windows.Forms.DataVisualization.Charting.Title();
			this.conditionChart = new System.Windows.Forms.DataVisualization.Charting.Chart();
			this.pricesChart = new System.Windows.Forms.DataVisualization.Charting.Chart();
			((System.ComponentModel.ISupportInitialize)(this.conditionChart)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.pricesChart)).BeginInit();
			this.SuspendLayout();
			// 
			// conditionChart
			// 
			chartArea1.Name = "ChartArea1";
			this.conditionChart.ChartAreas.Add(chartArea1);
			legend1.Name = "Legend1";
			this.conditionChart.Legends.Add(legend1);
			this.conditionChart.Location = new System.Drawing.Point(12, 12);
			this.conditionChart.Name = "conditionChart";
			series1.ChartArea = "ChartArea1";
			series1.Legend = "Legend1";
			series1.Name = "Automobiles";
			this.conditionChart.Series.Add(series1);
			this.conditionChart.Size = new System.Drawing.Size(300, 300);
			this.conditionChart.TabIndex = 0;
			this.conditionChart.Text = "Automobile Condition";
			title1.Name = "Title1";
			title1.Text = "Automobiles Condition";
			this.conditionChart.Titles.Add(title1);
			this.conditionChart.Click += new System.EventHandler(this.chart1_Click);
			// 
			// pricesChart
			// 
			chartArea2.Name = "ChartArea1";
			this.pricesChart.ChartAreas.Add(chartArea2);
			legendCellColumn1.Name = "Column1";
			legend2.CellColumns.Add(legendCellColumn1);
			legend2.Name = "lg1";
			this.pricesChart.Legends.Add(legend2);
			this.pricesChart.Location = new System.Drawing.Point(362, 12);
			this.pricesChart.Name = "pricesChart";
			series2.ChartArea = "ChartArea1";
			series2.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Pie;
			series2.Legend = "lg1";
			series2.Name = "Price";
			this.pricesChart.Series.Add(series2);
			this.pricesChart.Size = new System.Drawing.Size(493, 328);
			this.pricesChart.TabIndex = 1;
			this.pricesChart.Text = "Price Range";
			title2.Name = "priceRange";
			title2.Text = "Price Range";
			this.pricesChart.Titles.Add(title2);
			// 
			// DiagramsForm
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(858, 340);
			this.Controls.Add(this.pricesChart);
			this.Controls.Add(this.conditionChart);
			this.Name = "DiagramsForm";
			this.Text = "DiagramsForm";
			this.Load += new System.EventHandler(this.DiagramsForm_Load);
			((System.ComponentModel.ISupportInitialize)(this.conditionChart)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.pricesChart)).EndInit();
			this.ResumeLayout(false);

		}

		#endregion

		private System.Windows.Forms.DataVisualization.Charting.Chart conditionChart;
		private System.Windows.Forms.DataVisualization.Charting.Chart pricesChart;
	}
}