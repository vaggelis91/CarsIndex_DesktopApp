using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CarsApplication
{
	class QueryDeletion : QueryBuilder
	{
		DataGridView dataGrid;

		public QueryDeletion(DataGridView dataGrid)
		{
			this.dataGrid = dataGrid;
		}

		protected override StringBuilder BuildQuery()
		{
			StringBuilder buildDeleteQuery = new StringBuilder();
			int i = 0;
			foreach (DataGridViewRow Datarow in dataGrid.SelectedRows)
			{
				if (i == 0)
				{
					buildDeleteQuery.Append(Convert.ToInt32(Datarow.Cells[0].Value));
				}
				else
				{
					buildDeleteQuery.Append(',').Append(Convert.ToInt32(Datarow.Cells[0].Value));
				}
				i += 1;
			}
			return buildDeleteQuery;
		}

		public void ExecuteDeleteQuery()
		{
			try
			{
				using (SqlConnection con = new SqlConnection(QueryBuilder.connectionString))
				{
					con.Open();
					SqlCommand command = new SqlCommand();
					command.Connection = con;
					command.CommandText = "DELETE FROM MycarsTB WHERE ID IN (" + BuildQuery() + ")";
					SqlDataReader dr = command.ExecuteReader();
				}
				MessageBox.Show("Deletion completed successfully.", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
			}
			catch (Exception)
			{
				MessageBox.Show("Deletion failed.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
			}
		}


	}
}
