using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using TeleAntena.Controladores;

namespace TeleAntena
{
    public partial class ListarVideos : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            cargarGrid();
        }
        public void cargarGrid()
        {
            if (Session["producto"] == null)
            {
                Response.Redirect("BuscarProducto.aspx"); //No es así, se usará un LbMensaje 
            }

            Productos producto = (Productos)Session["producto"];
            int Identificador = producto.ID_Producto;

            GrdManuales.DataSource = from en in CapacitacionController.FindVideoByProductoID(Identificador)
                                     select new
                                     {
                                         ID = en.ID_Capacitacion,
                                         Video = en.URL
                                     };

            GrdManuales.DataBind();
        }
        protected void GrdManuales_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        protected void LnkVolver_Click(object sender, EventArgs e)
        {
            Response.Redirect("BuscarProducto.aspx");
        }
    }
}