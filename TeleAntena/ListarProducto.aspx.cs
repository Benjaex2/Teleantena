using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using TeleAntena.Controladores;

namespace TeleAntena
{
    public partial class ListarProducto : System.Web.UI.Page
    {
        private static TeleantenaEntities entidad = new TeleantenaEntities();
        protected void Page_Load(object sender, EventArgs e)
        {
            cargarGrid();
        }

        public void cargarGrid()
        {

            GrdManuales.DataSource = from en in ProductoController.FindAll()
                                     from ma in MarcaController.FindAll()
                                     from ti in TipoProductoController.FindAll()
                                     where en.ID_Marca == ma.ID_Marca
                                     where en.ID_TipoProducto == ti.ID_TipoProducto
                                     select new
                                     {
                                         ID = en.ID_Producto,
                                         Nombre = en.NombreProducto,
                                         Marca = ma.NombreMarca,
                                         Tipo = ti.NombreTipo,
                                         Stock = en.Stock,
                                         Link = en.URL,
                                         Detalle = en.DetalleProducto
                                     };

            GrdManuales.DataBind();
        }
        protected void GrdManuales_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        protected void LnkListar_Click(object sender, EventArgs e)
        {
            Response.Redirect("ListarProducto.aspx");
        }

        protected void LnkBuscar_Click(object sender, EventArgs e)
        {
            Response.Redirect("BuscarProducto.aspx");
        }

        protected void LnkCapa_Click(object sender, EventArgs e)
        {
            Response.Redirect("AgregarCapacitacion.aspx");
        }

        protected void LnkProd_Click(object sender, EventArgs e)
        {
            Response.Redirect("AgregarProducto.aspx");
        }
    }
}