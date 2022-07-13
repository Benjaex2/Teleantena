using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace TeleAntena
{
    public partial class PaginaMaestra : System.Web.UI.MasterPage
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!Page.IsPostBack)
            {
                ValidarUser();
            }
        }

        public void ValidarUser()
        {
            if (Session["ActiveUser"] == null)
            {
                Response.Redirect("Login.aspx");
            }
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
        protected void LnkListar_Click(object sender, EventArgs e)
        {
            Response.Redirect("ListarProducto.aspx");
        }
    }
}