using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AcmeBanking.Control
{
    class DatabaseConnector
    {
        public static SqlConnection ConnectToDatabase(string connectionString)
        {
            SqlConnection connection = new SqlConnection(connectionString);
            connection.Open();
            return connection;
        }
    }
}
