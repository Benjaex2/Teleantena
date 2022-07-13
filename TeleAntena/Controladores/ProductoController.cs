using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;


namespace TeleAntena.Controladores
{
    public class ProductoController
    {
        private static TeleantenaEntities entidad = new TeleantenaEntities();

        //Método para agregar


        public static string AddProducto(int id, string nombreproducto, int codMarca, int codTipoproducto, int stock, string detalleproducto, string imagen, string url)
        {
            try
            {
                Productos p = new Productos()
                {
                    ID_Producto = id,
                    NombreProducto = nombreproducto,
                    ID_TipoProducto = codTipoproducto,
                    ID_Marca = codMarca,
                    Stock = stock,
                    DetalleProducto = detalleproducto,
                    Imagen = imagen,
                    URL = url
                };

                entidad.Productos.Add(p);
                entidad.SaveChanges();
                return "Producto agregado";
            }
            catch (Exception ex)
            {
                return ex.Message;
            }
        }

        public static List<Productos> FindAll()
        {
            var lista = from p in entidad.Productos
                        select p;
            return lista.ToList();
        }

        //Buscar Producto
        public static Productos FindProducto(int id)
        {
            Productos p = entidad.Productos.SingleOrDefault(i => i.ID_Producto == id);
            if (p == null)
            {
                return null;
            }
            else
            {
                return p;
            }
        }

        //Editar Producto
        public static string EditProducto(int id, string nombreproducto, int codMarca, int codTipoproducto, int stock, string link, string detalleproducto, string imagen)
        {
            Productos p = FindProducto(id);
            p.NombreProducto = nombreproducto;
            p.ID_Marca = codMarca;
            p.ID_TipoProducto = codTipoproducto;
            p.Stock = stock;
            p.URL = link;
            p.DetalleProducto = detalleproducto;
            p.Imagen = imagen;
            entidad.SaveChanges();
            return "Producto modificado";
        }

        public static string EditStockProducto(int id, int stock)
        {
            Productos p = FindProducto(id);
            p.Stock = stock;
            entidad.SaveChanges();
            return "Stock modificado";
        }

        //Remover Producto
        public static string RemoveProducto(int id)
        {
            Productos p = FindProducto(id);
            CapacitacionController.RemoveAllCapacitacionByProductoID(id);
            entidad.Productos.Remove(p);
            entidad.SaveChanges();
            return "Producto removido correctamente";
        }
    }
}