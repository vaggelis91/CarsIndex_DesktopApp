using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Text.RegularExpressions;
using System.Net.Mail;

namespace CarsApplication
{
	class Validation
	{

		public string ValidateBrand(string BrandTextBox)
		{
			Regex brandPattern = new Regex("[^a-zA-Z ]");
			if (!brandPattern.IsMatch(BrandTextBox))
			{
				return BrandTextBox;
			}
			else
			{
				return null;
			}
		}

		public string ValidateModel(string ModelTextBox)
		{
			Regex modelPattern = new Regex("[^a-zA-Z0-9 ]");
			if (!modelPattern.IsMatch(ModelTextBox))
			{
				return ModelTextBox;
			}
			else
			{
				return null;
			}
		}

		public string ValidateEngineType(string EngineTypeTextBox)
		{
			return EngineTypeTextBox;
		}

		public int ValidateEngineCap(string EngineCapTextBox)
		{
			Regex engine_capPattern = new Regex("[^0-9 -]");
			if (!engine_capPattern.IsMatch(EngineCapTextBox))
			{
				return Convert.ToInt32(EngineCapTextBox);
			}
			else
			{
				return 0;
			}
		}

		public string ValidateMaxSpeed(string MaxSpeedTextBox)
		{
			Regex max_speedPattern = new Regex("[^a-zA-Z0-9 /]");
			if (!max_speedPattern.IsMatch(MaxSpeedTextBox))
			{
				return MaxSpeedTextBox;
			}
			else
			{
				return null;
			}
		}

		public string ValidateAcceleration(string AccelerationTextBox)
		{
			Regex accelerationPattern = new Regex("[^a-zA-Z0-9 .]");
			if (!accelerationPattern.IsMatch(AccelerationTextBox))
			{
				return AccelerationTextBox;
			}
			else
			{
				return null;
			}
		}

		public string ValidateHorsePower(string HorsePowerTextBox)
		{
			Regex horse_powerPattern = new Regex("[^a-zA-Z0-9 ]");
			if (!horse_powerPattern.IsMatch(HorsePowerTextBox))
			{
				return HorsePowerTextBox;
			}
			else
			{
				return null;
			}
		}

		public string ValidateFuel(string FuelTextBox)
		{
			Regex fuelPattern = new Regex("[^a-zA-Z ]");
			if (!fuelPattern.IsMatch(FuelTextBox))
			{
				return FuelTextBox;
			}
			else
			{
				return null;
			}
		}

		public string ValidateFuelCon(string FuelConTextBox)
		{
			Regex fuel_conPattern = new Regex("[^-./a-zA-Z0-9 ]");
			if (!fuel_conPattern.IsMatch(FuelConTextBox))
			{
				return FuelConTextBox;
			}
			else
			{
				return null;
			}
		}

		public int ValidateDoors(string DoorsTextBox)
		{
			Regex doorsPattern = new Regex("[^0-9]");
			if (!doorsPattern.IsMatch(DoorsTextBox))
			{
				return Convert.ToInt16(DoorsTextBox);
			}
			else
			{
				return 0;
			}
		}

		public string ValidateType(string TypeTextBox)
		{
			Regex typePattern = new Regex("[^a-zA-Z ]");
			if (!typePattern.IsMatch(TypeTextBox))
			{
				return TypeTextBox;
			}
			else
			{
				return null;
			}
		}

		public int ValidatePrice(string PriceTextBox)
		{
			Regex pricePattern = new Regex("[^0-9]");
			if (!pricePattern.IsMatch(PriceTextBox))
			{
				return Convert.ToInt32(PriceTextBox);
			}
			else
			{
				return 0;
			}
		}

		public string ValidateReused(bool YesSelection, bool NoSelection)
		{
			if (YesSelection)
			{
				return "Yes";
			}
			else if (NoSelection)
			{
				return "No";
			}
			else
			{
				return null;
			}
		}

		public bool ValidateEmail(string email)
		{
			try
			{
				MailAddress emailAddress = new MailAddress(email);
				return true;
			}
			catch
			{
				return false;
			}
		}



	}
}
