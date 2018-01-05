using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL
{
    public class DatabaseConnectionFactory
    {
        public static string ConnectionString
        {
            get
            {
                return ConfigurationManager
                    .ConnectionStrings["ConnectionString"]
                    .ToString();
            }
        }
        public static SqlConnection GetConnection()
        {
            SqlConnection dbConnection = new SqlConnection(ConnectionString);
            return dbConnection;
        }
    }
}
