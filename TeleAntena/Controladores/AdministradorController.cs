using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Web;

namespace TeleAntena.Controladores
{
    public class AdministradorController
    {
        public static string GetMD5(string contrasena)
        {
            MD5 md5 = MD5CryptoServiceProvider.Create();
            ASCIIEncoding codificar = new ASCIIEncoding();
            byte[] stream = null;
            StringBuilder sb = new StringBuilder();
            stream = md5.ComputeHash(codificar.GetBytes(contrasena));
            for (int i = 0; i < stream.Length; i++) sb.AppendFormat("{0:x2}", stream[i]);
            return sb.ToString();
        }

        private static TeleantenaEntities entidad = new TeleantenaEntities();

        //Agregar Administrador
        public static string AddAdministrador(string usuario, string contrasena)
        {
            try
            {
                Usuarios user = new Usuarios()
                {
                    Usuario = usuario,
                    Contra = GetMD5(contrasena)
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
            Usuarios user = entidad.Usuarios.SingleOrDefault(i => i.Usuario == usuario);
            if (user == null)
            {
                return null;
            }
            else
            {
                return user;
            }
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