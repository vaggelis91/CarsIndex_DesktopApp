using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CarsApplication
{
	class QueryInsertion : QueryBuilder
	{
		StringBuilder buildInsertQueryForFiles = new StringBuilder();
		public static int rowsCount = 0;

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

		public QueryInsertion(string brand, string model, string engineType, string engineCap, string maxSpeed, string acceleration, string horsePower, string fuelType, string fuelConsumption, string doors, string vehicleType, string price, string reused)
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

		public QueryInsertion(StringBuilder buildInsertQueryForFiles)
		{
			this.buildInsertQueryForFiles = buildInsertQueryForFiles;
		}

		protected override StringBuilder BuildQuery()
		{
			StringBuilder buildInsertQuery = new StringBuilder();

			buildInsertQuery.Append("'").Append(brand)
				.Append("','").Append(model)
				.Append("','").Append(engineType)
				.Append("',").Append(engineCap)
				.Append(",'").Append(maxSpeed)
				.Append("','").Append(acceleration)
				.Append("','").Append(horsePower)
				.Append("','").Append(fuelType)
				.Append("','").Append(fuelConsumption)
				.Append("',").Append(doors)
				.Append(",'").Append(vehicleType)
				.Append("',").Append(price)
				.Append(",'").Append(reused).Append("'");

			return buildInsertQuery;
		}

		public void ExecuteInsertQuery()
		{
			try
			{
				using (SqlConnection con = new SqlConnection(QueryBuilder.connectionString))
				{
					con.Open();
					SqlCommand command = new SqlCommand();
					command.Connection = con;
					if (buildInsertQueryForFiles.Length > 0)
					{
						command.CommandText = "INSERT INTO MycarsTB (Brand, Model, [Engine Type], [Engine Capacity], [Max Speed], Acceleration, [Horse Power], Fuel, [Fuel Consumption], Doors, Type, [Price(€)], Reused) VALUES (" + buildInsertQueryForFiles + ")";
						SqlDataReader dr = command.ExecuteReader();
						rowsCount += 1;
					}
					else
					{
						command.CommandText = "INSERT INTO MycarsTB (Brand, Model, [Engine Type], [Engine Capacity], [Max Speed], Acceleration, [Horse Power], Fuel, [Fuel Consumption], Doors, Type, [Price(€)], Reused) VALUES (" + BuildQuery() + ")";
						SqlDataReader dr = command.ExecuteReader();
					}				
				}
				if (InsertForm.showInsertMessageFlag == true)
				{
					MessageBox.Show("Row inserted successfully.", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
				}
			}
			catch (Exception)
			{
				if (buildInsertQueryForFiles.Length > 0)
				{
					MessageBox.Show("Insertion failed. Invalid data: " + buildInsertQueryForFiles, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error); 
				}
				else
				{
					MessageBox.Show("Insertion failed.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
				}			
			}
		}




	}
}
