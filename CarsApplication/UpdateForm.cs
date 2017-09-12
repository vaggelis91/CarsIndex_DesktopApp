using System;
using System.Windows.Forms;

namespace CarsApplication
{
	public partial class UpdateForm : Form
	{

		public UpdateForm() 
		{
			InitializeComponent();
		}

		private void UpdateForm_Load(object sender, EventArgs e)
		{
			LoadDataIntoTextBoxes();
		}

		private void LoadDataIntoTextBoxes()
		{
			BrandTextBox.Text = Form1.selectedCellValues[1];
			ModelTextBox.Text = Form1.selectedCellValues[2];
			EngineTypeTextBox.Text = Form1.selectedCellValues[3];
			EngineCapTextBox.Text = Form1.selectedCellValues[4];
			MaxSpeedTextBox.Text = Form1.selectedCellValues[5];
			AccelerationTextBox.Text = Form1.selectedCellValues[6];
			HorsePowerTextBox.Text = Form1.selectedCellValues[7];
			FuelTextBox.Text = Form1.selectedCellValues[8];
			FuelConTextBox.Text = Form1.selectedCellValues[9];
			DoorsTextBox.Text = Form1.selectedCellValues[10];
			TypeTextBox.Text = Form1.selectedCellValues[11];
			PriceTextBox.Text = Form1.selectedCellValues[12];

			if (Form1.selectedCellValues[13] == "Yes")
			{
				YesRadioBtn.Checked = true;
			}
			else if (Form1.selectedCellValues[13] == "No")
			{
				NoRadioBtn.Checked = true;
			}
		}

		private void UpdateBtn_Click(object sender, EventArgs e)
		{
			Validation validateUpdate = new Validation();

			if ((validateUpdate.ValidateBrand(BrandTextBox.Text).Length > 0)
				|| (validateUpdate.ValidateModel(ModelTextBox.Text).Length > 0)
				|| (validateUpdate.ValidateEngineType(EngineTypeTextBox.Text).Length > 0)
				|| validateUpdate.ValidateEngineCap(EngineCapTextBox.Text) != 0
				|| (validateUpdate.ValidateMaxSpeed(MaxSpeedTextBox.Text).Length > 0)
				|| (validateUpdate.ValidateAcceleration(AccelerationTextBox.Text).Length > 0)
				|| (validateUpdate.ValidateHorsePower(HorsePowerTextBox.Text).Length > 0)
				|| (validateUpdate.ValidateFuel(FuelTextBox.Text).Length > 0
				|| (validateUpdate.ValidateFuelCon(FuelConTextBox.Text).Length > 0)
				|| validateUpdate.ValidateDoors(DoorsTextBox.Text) != 0
				|| (validateUpdate.ValidateType(TypeTextBox.Text).Length > 0)
				|| validateUpdate.ValidatePrice(PriceTextBox.Text) != 0))
			{
				QueryUpdating update_query = new QueryUpdating(BrandTextBox.Text.Trim(), ModelTextBox.Text.Trim(), EngineTypeTextBox.Text.Trim(), EngineCapTextBox.Text.Trim(), MaxSpeedTextBox.Text.Trim(), AccelerationTextBox.Text.Trim(), HorsePowerTextBox.Text.Trim(), FuelTextBox.Text.Trim(), FuelConTextBox.Text.Trim(), DoorsTextBox.Text.Trim(), TypeTextBox.Text.Trim(), PriceTextBox.Text.Trim(), GetReusedSelectionForUpdate());
				update_query.ExecuteUpdateQuery();			
			}
			else
			{
				MessageBox.Show("Error", "Invalid data.", MessageBoxButtons.OK, MessageBoxIcon.Error);
			}
		}

		private string GetReusedSelectionForUpdate()
		{
			if (YesRadioBtn.Checked)
			{
				return "Yes";
			}
			else
			{
				return "No";
			}
		}


	}
}
