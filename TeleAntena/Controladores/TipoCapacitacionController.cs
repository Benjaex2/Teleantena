using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
namespace TeleAntena.Controladores
{
    public class TipoCapacitacionController
    {
        private static TeleantenaEntities entidad = new TeleantenaEntities();

        public static string AddTipoCapacitacion(int id, string nombrecapacitacion)
        {
            try
            {
                TipoCapacitacion tc = new TipoCapacitacion()
                {
                    ID_TipoCapacitacion = id,
                    NombreCapacitacion = nombrecapacitacion
                };
                entidad.TipoCapacitacion.Add(tc);
                entidad.SaveChanges();
                return "Tipo de Capacitacion ingresada.";
            }
            catch (Exception ex)
            {
                return ex.Message;
            }
        }

        public static List<TipoCapacitacion> FindAll()
        {
            var lista = from r in entidad.TipoCapacitacion
                        select r;

            return lista.ToList();
        }

        public static List<TipoCapacitacion> FindTipoCapacitacion(int id)
        {
            var lista = from tp in FindAll()
                        where tp.ID_TipoCapacitacion == id
                        select tp;
            return lista.ToList();
        }
    }
}