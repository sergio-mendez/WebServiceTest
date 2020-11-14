using Dapper;
using System;
using System.Collections.Generic;
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
    }
}
