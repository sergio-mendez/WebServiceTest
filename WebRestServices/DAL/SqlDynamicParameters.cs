using Dapper;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;

namespace WebRestServices.DAL
{
    public class SqlDynamicParameters
    {
        private readonly List<SqlParameter> sqlParameters = new List<SqlParameter>();

        public void Add(string name, SqlDbType sqlDbType, object value = null, int? size = null)
        {
            SqlParameter sqlParameter = new SqlParameter();
            sqlParameter.ParameterName = name;
            sqlParameter.SqlDbType = sqlDbType;
            sqlParameter.Value = value;
            sqlParameter.Direction = ParameterDirection.Output;
            sqlParameters.Add(sqlParameter);        
        }
    }
}
