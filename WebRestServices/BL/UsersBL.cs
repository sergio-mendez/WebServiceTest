using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using WebRestServices.DAL;
using WebRestServices.Entity;

namespace WebRestServices.BL
{
    public class UsersBL
    {
        public List<Users> getUserInfo()
        {
            UserDAL userDalT = new UserDAL();
            List<Users> users = userDalT.get();            
            return users;
        }
    }
}
