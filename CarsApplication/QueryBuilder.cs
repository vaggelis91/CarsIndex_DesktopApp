using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CarsApplication
{
	abstract class QueryBuilder
	{
		public static string connectionString = "data source = DESKTOP-07JF108\\SQLEXPRESS; Initial Catalog = Cars; Integrated Security = SSPI";
		protected abstract StringBuilder BuildQuery();

	}
}
