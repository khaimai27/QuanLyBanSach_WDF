using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL
{
    internal class DBHelper
    {
        //câu lệnh kết nối sql server
        private static string connectionString = "Data Source=.;Initial Catalog=BookStore;Integrated Security=True";
        public static SqlConnection GetConnection()
        {
            SqlConnection connection = new SqlConnection(connectionString);
            connection.Open();
            return connection;
        }
    }
}
