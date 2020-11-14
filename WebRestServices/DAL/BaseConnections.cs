using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Threading.Tasks;

namespace WebRestServices.DAL
{
    public class BaseConnections
    {
        protected IDbConnection connection;        

        public IDbConnection GetOpenConnection()
        {
            try
            {
                string CadenaConexion = "Data Source=database-test.ccjwv18zrpzr.us-east-2.rds.amazonaws.com,1433;Initial Catalog=user_example;Persist Security Info=True;User ID=admin;Password=y\\x!8rBy";
                var connection = new SqlConnection(CadenaConexion);
                if(connection.State == ConnectionState.Closed)
                {
                    connection.Open();
                }
                this.connection = connection;
                return connection;
            }
            catch(Exception ex)
            {
                throw ex;
            }
        }

        public void CloseConnection(IDbConnection connection)
        {
            try
            {
                if(connection.State == ConnectionState.Open)
                {
                    connection.Close();
                }
            }
            catch(Exception ex)
            {
                throw ex;
            }
        }
    }
}
