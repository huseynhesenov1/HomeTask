using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EntitiyFrameWorkTask2.Helpers
{
	public static class sqlHelper
	{
		
		private static readonly string _connectionString = "Server=PC\\SQLEXPRESS;Database=StudentService1;Trusted_Connection=True;TrustServerCertificate=True;";

		public static string GetConnection()
		{
			return _connectionString;
		}
	}
}
