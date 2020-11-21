using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using WebRestServices.BL;
using WebRestServices.Entity;

namespace WebRestServices.Controllers
{
    [Produces("application/json")]
    [Route("api/users")]
    public class UsersService : ControllerBase
    {
        [HttpGet]
        [Route("ObtenerUsuario")]
        public List<Users> ObtenerUsuarios()
        {
            List<Users> users = null;
            try
            {
                UsersBL usersBL = new UsersBL();
                users = usersBL.getUserInfo();
            }
            catch(Exception ex)
            {

            }
            return users;
        }

        [HttpPost]
        [Route("RegistrarUsuario")]
        public string RegistrarUsuario([FromBody] Users user)
        {
            string result;
            try
            {
                UsersBL usersBL = new UsersBL();
                usersBL.insertUserInfo(user);
                result = "Registro Exitoso";
            }
            catch (Exception ex)
            {
                result = "Registro Fallido: "+ex.Message;
            }
            return result;
        }
    }
}
