using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;

namespace documnets_demo
{
    internal class DataBase_Connection
    {
        SqlConnection SqlConnection = new SqlConnection(@"Data Source = ZHEKA-PC\SQLEXPRESS; Initial Catalog = Documents; Integrated Security = True");

        public void OpenConnection()
        {
            if(SqlConnection.State == System.Data.ConnectionState.Closed)
            {
                SqlConnection.Open();
            }
        }

        public void CloseConnection()
        {
            if(SqlConnection.State == System.Data.ConnectionState.Open)
            {
                SqlConnection.Close();
            }
        }

        public SqlConnection GetConnection()
        {
            return SqlConnection;
        }
    }
}
