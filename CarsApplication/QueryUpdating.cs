using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CarsApplication
{
	class QueryUpdating : QueryBuilder
	{
		string brand;
		string model;
		string engineType;
		string engineCap;
		string maxSpeed;
		string acceleration;
		string horsePower;
		string fuelType;
		string fuelConsumption;
		string doors;
		string vehicleType;
		string price;
		string reused;

		public QueryUpdating(string brand, string model, string engineType, string engineCap, string maxSpeed, string acceleration, string horsePower, string fuelType, string fuelConsumption, string doors, string vehicleType, string price, string reused)
		{
			this.brand = brand;
			this.model = model;
			this.engineType = engineType;
			this.engineCap = engineCap;
			this.maxSpeed = maxSpeed;
			this.acceleration = acceleration;
			this.horsePower = horsePower;
			this.fuelType = fuelType;
			this.fuelConsumption = fuelConsumption;
			this.doors = doors;
			this.vehicleType = vehicleType;
			this.price = price;
			this.reused = reused;
		}

		protected override StringBuilder BuildQuery()
		{
			StringBuilder buildUpdateQuery = new StringBuilder();

			buildUpdateQuery.Append("Brand = '").Append(brand)
				.Append("', Model = '").Append(model)
				.Append("', [Engine Type] = '").Append(engineType)
				.Append("', [Engine Capacity] = ").Append(engineCap)
				.Append(", [Max Speed] = '").Append(maxSpeed)
				.Append("', Acceleration = '").Append(acceleration)
				.Append("', [Horse Power] = '").Append(horsePower)
				.Append("', Fuel = '").Append(fuelType)
				.Append("', [Fuel Consumption] = '").Append(fuelConsumption)
				.Append("', Doors = ").Append(doors)
				.Append(", Type = '").Append(vehicleType)
				.Append("',[Price(€)] = ").Append(price)
				.Append(", Reused = '").Append(reused).Append("'"); 

			return buildUpdateQuery;
		}

		public void ExecuteUpdateQuery()
		{
			try
			{
				using (SqlConnection con = new SqlConnection(connectionString))
				{
					con.Open();
					SqlCommand command = new SqlCommand();
					command.Connection = con;
					command.CommandText = "UPDATE MycarsTB SET " + BuildQuery() + " WHERE ID = " + Form1.selectedCellValues[0];
					SqlDataReader dr = command.ExecuteReader();
				}
				MessageBox.Show("Update completed successfully.", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
			}
			catch (Exception)
			{
				MessageBox.Show("Update row failed.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
			}
		}




	}
}
