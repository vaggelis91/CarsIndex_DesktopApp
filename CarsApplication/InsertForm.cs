using System;
using System.Windows.Forms;

namespace CarsApplication
{
	public partial class InsertForm : Form
	{
		public static bool showInsertMessageFlag = true;

		public InsertForm()
		{
			InitializeComponent();
		}

		private void showHelpCheckBox_CheckedChanged(object sender, EventArgs e)
		{
			if (showHelpCheckBox.Checked)
			{
				SetHelpLabelsToTrue();
			}
			else
			{
				SetHelpLabelsToFalse();
			}
		}

		private void SetHelpLabelsToTrue()
		{
			brandHelpLbl.Visible = true;
			modelHelpLbl.Visible = true;
			engine_typeHelpLbl.Visible = true;
			engine_capHelpLbl.Visible = true;
			max_speedHelpLbl.Visible = true;
			accelerationHelpLbl.Visible = true;
			horse_powerHelpLbl.Visible = true;
			fuelHelpLbl.Visible = true;
			fuel_conHelpLbl.Visible = true;
			doorsHelpLbl.Visible = true;
			typeHelpLbl.Visible = true;
			priceHelpLbl.Visible = true;
		}

		private void SetHelpLabelsToFalse()
		{
			brandHelpLbl.Visible = false;
			modelHelpLbl.Visible = false;
			engine_typeHelpLbl.Visible = false;
			engine_capHelpLbl.Visible = false;
			max_speedHelpLbl.Visible = false;
			accelerationHelpLbl.Visible = false;
			horse_powerHelpLbl.Visible = false;
			fuelHelpLbl.Visible = false;
			fuel_conHelpLbl.Visible = false;
			doorsHelpLbl.Visible = false;
			typeHelpLbl.Visible = false;
			priceHelpLbl.Visible = false;
		}

		private void SubmitBtn_Click(object sender, EventArgs e)
		{
			Validation validate = new Validation();

			if ((validate.ValidateBrand(BrandTextBox.Text).Length > 0 )
				|| (validate.ValidateModel(ModelTextBox.Text).Length > 0)
				|| (validate.ValidateEngineType(EngineTypeTextBox.Text).Length > 0)
				|| validate.ValidateEngineCap(EngineCapTextBox.Text) != 0
				|| (validate.ValidateMaxSpeed(MaxSpeedTextBox.Text).Length > 0)
				|| (validate.ValidateAcceleration(AccelerationTextBox.Text).Length > 0)
				|| (validate.ValidateHorsePower(HorsePowerTextBox.Text).Length > 0)
				|| (validate.ValidateFuel(FuelTextBox.Text).Length > 0)
				|| (validate.ValidateFuelCon(FuelConTextBox.Text).Length > 0)
				|| validate.ValidateDoors(DoorsTextBox.Text) != 0
				|| (validate.ValidateType(TypeTextBox.Text).Length > 0)
				|| validate.ValidatePrice(PriceTextBox.Text) != 0
				|| (validate.ValidateReused(YesRadioBtn.Checked, NoRadioBtn.Checked)).Length > 0)				
			{
				showInsertMessageFlag = true;

				QueryInsertion build_query = new QueryInsertion(BrandTextBox.Text.Trim(), ModelTextBox.Text.Trim(), EngineTypeTextBox.Text.Trim(), EngineCapTextBox.Text.Trim(), MaxSpeedTextBox.Text.Trim(), AccelerationTextBox.Text.Trim(), HorsePowerTextBox.Text.Trim(), FuelTextBox.Text.Trim(), FuelConTextBox.Text.Trim(), DoorsTextBox.Text.Trim(), TypeTextBox.Text.Trim(), PriceTextBox.Text.Trim(), GetReusedSelectionForInsert());
				build_query.ExecuteInsertQuery();			
			}
			else
			{
				MessageBox.Show("Invalid data.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
			}
		}

		private string GetReusedSelectionForInsert()
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
