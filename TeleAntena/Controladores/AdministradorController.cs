using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace TeleAntena.Controladores
{
    public class AdministradorController
    {
        private static TeleantenaEntities entidad = new TeleantenaEntities();

        //Agregar Administrador
        public static string AddAdministrador(string usuario, string contrasena)
        {
            try
            {
                Usuarios user = new Usuarios()
                {
                    Usuario = usuario,
                    Contra = contrasena
                };
                entidad.Usuarios.Add(user);
                entidad.SaveChanges();
                return "Administrador ingresado.";
            }
            catch (Exception ex)
            {
                return ex.Message;
            }
        }

        //Listar Administradores
        public static List<Usuarios> FindAll()
        {
            var lista = from u in entidad.Usuarios
                        select u;
            return lista.ToList();
        }

        //Buscar Administrador
        public static Usuarios FindAdministrador(string usuario)
        {
            Usuarios user = entidad.Usuarios.Single(i => i.Usuario == usuario);
            return user;
        }

        //Editar Administrador
        public static string EditAdministrador(string usuario, string contrasena)
        {
            Usuarios user = FindAdministrador(usuario);
            user.Contra = contrasena;
            entidad.SaveChanges();
            return "Usuario modificado";
        }

        //Remover Administrador
        public static string RemoveAdministrador(string usuario)
        {
            Usuarios user = FindAdministrador(usuario);
            entidad.Usuarios.Remove(user);
            entidad.SaveChanges();
            return "Usuario removido correctamente";
        }
    }
}