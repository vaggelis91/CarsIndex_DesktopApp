using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CarsApplication
{
	class QuerySelection : QueryBuilder
	{
		string brand;
		string model;
		string engine;
		string fuel;
		string price;
		string vehicle;
		string reused;

		public QuerySelection(string brand, string model, string engine, string fuel, string price, string vehicle, string reused)
		{
			this.brand = brand;
			this.model = model;
			this.engine = engine;
			this.fuel = fuel;
			this.price = price;
			this.vehicle = vehicle;
			this.reused = reused;
		}

		protected override StringBuilder BuildQuery()
		{
			StringBuilder whereStatement = new StringBuilder();

			if (!string.IsNullOrWhiteSpace(brand))
			{
				whereStatement.Append("Brand = '").Append(brand).Append("'");
			}
			if (!string.IsNullOrWhiteSpace(model))
			{
				if (!string.IsNullOrEmpty(whereStatement.ToString()))
				{
					whereStatement.Append(" AND Model = '").Append(model).Append("'");
				}
				else
				{
					whereStatement.Append("Model = '").Append(model).Append("'");
				}
			}
			if (!string.IsNullOrWhiteSpace(engine))
			{
				string engineCapacity = engine.Replace("-", "AND");
				if (!string.IsNullOrEmpty(whereStatement.ToString()))
				{
					whereStatement.Append(" AND [Engine Capacity] BETWEEN ").Append(engineCapacity);
				}
				else
				{
					whereStatement.Append("[Engine Capacity] BETWEEN ").Append(engineCapacity);
				}
			}
			if (!string.IsNullOrWhiteSpace(fuel))
			{
				if (!string.IsNullOrEmpty(whereStatement.ToString()))
				{
					whereStatement.Append(" AND Fuel = '").Append(fuel).Append("'");
				}
				else
				{
					whereStatement.Append("Fuel = '").Append(fuel).Append("'");
				}
			}
			if (!string.IsNullOrWhiteSpace(price))
			{
				string selectedPrice = price.Replace("-", "AND");
				if (!string.IsNullOrEmpty(whereStatement.ToString()))

				{
					whereStatement.Append(" AND [Price(€)] BETWEEN ").Append(selectedPrice);
				}
				else
				{
					whereStatement.Append("[Price(€)] BETWEEN ").Append(selectedPrice);
				}
			}
			if (!string.IsNullOrWhiteSpace(vehicle))
			{
				if (!string.IsNullOrEmpty(whereStatement.ToString()))
				{
					whereStatement.Append(" AND Type = '").Append(vehicle).Append("'");
				}
				else
				{
					whereStatement.Append("Type = '").Append(vehicle).Append("'");
				}
			}
			if (!string.IsNullOrWhiteSpace(reused))
			{
				if (!string.IsNullOrEmpty(whereStatement.ToString()) && reused == "No")
				{
					whereStatement.Append(" AND Reused = ").Append("'No'");
				}
				else if (!string.IsNullOrEmpty(whereStatement.ToString()) && reused == "Yes")
				{
					whereStatement.Append(" AND Reused = ").Append("'Yes'");
				}
				else if (reused == "No")
				{
					whereStatement.Append("Reused = ").Append("'No'");
				}
				else if (reused == "Yes")
				{
					whereStatement.Append("Reused = ").Append("'Yes'");
				}
			}
			return whereStatement;	
		}

		public DataTable ExecuteSelectQuery()
		{
			DataTable dt = new DataTable();
			using (SqlConnection con = new SqlConnection(QueryBuilder.connectionString))
			{
				con.Open();
				SqlCommand command = new SqlCommand();
				command.Connection = con;
				if (BuildQuery().ToString().Length > 0)
				{
					command.CommandText = "SELECT ID AS #, Brand, Model, [Engine Type], [Engine Capacity], [Max Speed], Acceleration, [Horse Power], Fuel, [Fuel Consumption], Doors, Type, [Price(€)] FROM MycarsTB WHERE " + BuildQuery();
				}
				else
				{
					command.CommandText = "SELECT ID AS #, Brand, Model, [Engine Type], [Engine Capacity], [Max Speed], Acceleration, [Horse Power], Fuel, [Fuel Consumption], Doors, Type, [Price(€)] FROM MycarsTB";
				}
				SqlDataReader dr = command.ExecuteReader();
				dt.Load(dr);
			}
			return dt;

		}





	}

}

		
			
