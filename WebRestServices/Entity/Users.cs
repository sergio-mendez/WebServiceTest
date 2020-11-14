using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace WebRestServices.Entity
{
    public class Users
    {
        public int UserId { get; set; }
        public string Firt_Name { get; set; }
        public string Last_Name { get; set; }
        public DateTime Birth_Date { get; set; }
        public string Email { get; set; }
        public string User_Name { get; set; }
        public string Password { get; set; }
    }
}
