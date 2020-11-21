using Dapper;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Threading.Tasks;
using WebRestServices.Entity;

namespace WebRestServices.DAL
{
    public class UserDAL : BaseConnections
    {
        public List<Users> get()
        {
            try
            {
                string Query = "select * from Users";
                List<Users> usuarios = SqlMapper.Query<Users>(GetOpenConnection(), Query).ToList();
                return usuarios;
            }
            catch(Exception ex)
            {
                throw ex;
            }
        }

        public void insert(Users user)
        {
            try
            {
                string Query = "insert into Users (User_Id,First_Name,Last_Name,Birth_Date,Email,User_Name,Password) values (@UserId,@FirstName,@LastName,@BirthDate,@Email,@UserName,@Password)";
                //var sqlParameters = GetInserParameters(user);
                SqlCommand sqlCommand = new SqlCommand();
                sqlCommand.Connection = (SqlConnection)GetOpenConnection();                
                sqlCommand.Parameters.Add("@UserId", SqlDbType.Int).Value = user.User_Id;
                sqlCommand.Parameters.Add("@FirstName", SqlDbType.VarChar).Value = user.First_Name;
                sqlCommand.Parameters.Add("@LastName", SqlDbType.VarChar).Value = user.Last_Name;
                sqlCommand.Parameters.Add("@BirthDate", SqlDbType.Date).Value = user.Birth_Date;
                sqlCommand.Parameters.Add("@Email", SqlDbType.VarChar).Value = user.Email;
                sqlCommand.Parameters.Add("@UserName", SqlDbType.VarChar).Value = user.User_Name;
                sqlCommand.Parameters.Add("@Password", SqlDbType.VarChar).Value = user.Password;
                sqlCommand.CommandText = Query;
                sqlCommand.ExecuteNonQuery();
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        //public List<SqlParameter> GetInserParameters(Users users)
        //{
        //    List<SqlParameter> sqlParameters1 = new List<SqlParameter>();
        //    sqlParameters1.Add(Add("@UserId", SqlDbType.Int, users.User_Id));
        //    sqlParameters1.Add(Add("@FirstName", SqlDbType.VarChar, users.First_Name));
        //    sqlParameters1.Add(Add("@LastName", SqlDbType.VarChar, users.Last_Name));
        //    sqlParameters1.Add(Add("@BirthDate", SqlDbType.Date, users.Birth_Date));
        //    sqlParameters1.Add(Add("@Email", SqlDbType.VarChar, users.Email));
        //    sqlParameters1.Add(Add("@UserName", SqlDbType.VarChar, users.User_Name));
        //    sqlParameters1.Add(Add("@Password", SqlDbType.VarChar, users.Password));
        //    return sqlParameters1;
        //}

        //public SqlParameter Add(string name, SqlDbType sqlDbType, object value = null, int? size = null)
        //{
        //    SqlParameter sqlParameter = new SqlParameter();
        //    sqlParameter.ParameterName = name;
        //    sqlParameter.SqlDbType = sqlDbType;
        //    sqlParameter.Value = value;
        //    sqlParameter.IsNullable = false;
        //    sqlParameter.Direction = ParameterDirection.Output;
        //    return sqlParameter;
        //}
    }
}
