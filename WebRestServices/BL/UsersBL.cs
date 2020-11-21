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

        public void insertUserInfo(Users users)
        {
            UserDAL userDalT = new UserDAL();
            users.Birth_Date = DateTime.Now;
            userDalT.insert(users);
        }
    }
}
