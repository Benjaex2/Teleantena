using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;


namespace TeleAntena.Controladores
{
    public class CapacitacionController
    {
        private static TeleantenaEntities entidad = new TeleantenaEntities();

        //Agregar Capacitacion
        public static string AddCapacitacion(int codTipoCapacitacion, int codProducto, string url)
        {
            try
            {
                Capacitacion c = new Capacitacion()
                {
                    ID_TipoCapacitacion = codTipoCapacitacion,
                    ID_Producto = codProducto,
                    URL = url
                };
                entidad.Capacitacion.Add(c);
                entidad.SaveChanges();
                return "Capacitacion agregada";
            }
            catch (Exception err)
            {
                return err.Message;
            }
        }

        //Listar Capacitaciones
        public static List<Capacitacion> FindAll()
        {
            var lista = from c in entidad.Capacitacion
                        select c;
            return lista.ToList();
        }

        //Buscar Capacitacion
        public static Capacitacion FindCapacitacion(int id)
        {
            Capacitacion c = entidad.Capacitacion.SingleOrDefault(i => i.ID_Capacitacion == id);
            return c;
        }

        //Editar Capacitacion
        public static string EditCapacitacion(int id, int codTipoCapacitacion, int codProducto, string url)
        {
            Capacitacion c = FindCapacitacion(id);
            c.ID_TipoCapacitacion = codTipoCapacitacion;
            c.ID_Producto = codProducto;
            c.URL = url;
            entidad.SaveChanges();
            return "Capacitacion modificada";
        }

        //Remover Capacitacion
        public static string RemoveCapacitacion(int id)
        {
            Capacitacion c = FindCapacitacion(id);
            entidad.Capacitacion.Remove(c);
            entidad.SaveChanges();
            return "Capacitacion removida correctamente";
        }

        //Buscar Capacitacion por ID de Producto
        public static List<Capacitacion> FindManualByProductoID(int idProd)
        {
            var lista = from c in FindAll()
                        from t in TipoCapacitacionController.FindTipoCapacitacion(1)
                        where c.ID_Producto == idProd
                        where c.ID_TipoCapacitacion == t.ID_TipoCapacitacion
                        select c;
            return lista.ToList();
        }

        public static List<Capacitacion> FindVideoByProductoID(int idProd)
        {
            var lista = from c in FindAll()
                        from t in TipoCapacitacionController.FindTipoCapacitacion(2)
                        where c.ID_Producto == idProd
                        where c.ID_TipoCapacitacion == t.ID_TipoCapacitacion
                        select c;
            return lista.ToList();
        }

        public static void RemoveAllCapacitacionByProductoID(int idProd)
        {
            List<Capacitacion> Manuales = FindManualByProductoID(idProd);
            List<Capacitacion> Videos = FindVideoByProductoID(idProd);

            foreach (Capacitacion manual in Manuales)
            {
                RemoveCapacitacion(manual.ID_Capacitacion);
            }
            foreach (Capacitacion video in Videos)
            {
                RemoveCapacitacion(video.ID_Capacitacion);
            }
        }
    }
}