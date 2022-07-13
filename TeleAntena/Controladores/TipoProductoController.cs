using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace TeleAntena.Controladores
{
    public class TipoProductoController
    {
        private static TeleantenaEntities entidad = new TeleantenaEntities();

        //Agregar TipoProducto
        public static string AddTipoProducto(int id, string nombretipo)
        {
            try
            {
                TipoProductos tp = new TipoProductos()
                {
                    NombreTipo = nombretipo
                };
                entidad.TipoProductos.Add(tp);
                entidad.SaveChanges();
                return "Revista agregada";
            }
            catch (Exception err)
            {
                return err.Message;
            }
        }

        //Listar TipoProductos
        public static List<TipoProductos> FindAll()
        {
            var lista = from tp in entidad.TipoProductos
                        select tp;
            return lista.ToList();
        }

        //Buscar TipoProducto
        public static TipoProductos FindTipoProducto(int id)
        {
            TipoProductos tp = entidad.TipoProductos.SingleOrDefault(i => i.ID_TipoProducto == id);
            return tp;
        }

        //Editar TipoProducto
        public static string EditTipoProducto(int id, string nombretipo)
        {
            TipoProductos tp = FindTipoProducto(id);
            tp.NombreTipo = nombretipo;
            entidad.SaveChanges();
            return "Tipo de producto modificado";
        }

        //Remover TipoProducto
        public static string RemoveTipoProducto(int id)
        {
            TipoProductos tp = FindTipoProducto(id);
            entidad.TipoProductos.Remove(tp);
            entidad.SaveChanges();
            return "Tipo de producto removido correctamente";
        }
    }
}