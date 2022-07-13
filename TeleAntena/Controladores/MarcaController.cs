using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
//using TeleAntena.Clases;

namespace TeleAntena.Controladores
{
    public class MarcaController
    {
        private static TeleantenaEntities entidad = new TeleantenaEntities();

        //Agregar Marca
        public static string AddMarca(int id, string nombremarca)
        {

            try
            {
                Marcas m = new Marcas()
                {
                    NombreMarca = nombremarca
                };

                entidad.Marcas.Add(m);
                entidad.SaveChanges();
                return "Marca ingresada.";
            }
            catch (Exception ex)
            {
                return ex.Message;
            }
        }

        //Listar Marcas
        public static List<Marcas> FindAll()
        {
            var listaMarcas = from m in entidad.Marcas
                              select m;
            return listaMarcas.ToList();
        }

        //Buscar Marca
        public static Marcas FindMarca(int id)
        {
            Marcas m = entidad.Marcas.SingleOrDefault(i => i.ID_Marca == id);
            return m;
        }

        //Editar Marca
        public static string EditMarca(int id, string nombremarca)
        {
            Marcas m = FindMarca(id);

            m.NombreMarca = nombremarca;

            entidad.SaveChanges();

            return "Marca modificada correctamente.";
        }

        //Remover Marca
        public static string RemoveMarca(int id)
        {
            Marcas m = FindMarca(id);

            entidad.Marcas.Remove(m);
            entidad.SaveChanges();

            return "Marca removida";
        }
    }
}