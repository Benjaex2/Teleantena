using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace TeleAntena.Controladores
{
    public class LoginController
    {
        public static Usuarios Login(string username, string pass)
        {
            Usuarios user = AdministradorController.FindAdministrador(username);
            if (user != null)
            {
                if (user.Contra.Equals(AdministradorController.GetMD5(pass)))
                {
                    return user;
                }
                else
                {
                    return null;
                }
            }
            else
            {
                return null;
            }
        }
    }
}