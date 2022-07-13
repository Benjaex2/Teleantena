using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using TeleAntena.Controladores;

namespace TeleAntena
{
    public partial class AgregarCapacitacion : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            //Nos permite obtener los datos que enviamos despues del fomulario
            if (!Page.IsPostBack)
            {
                CargarDropProducto();
            }
        }

        //Crear drop
        public void CargarDropProducto()
        {
            DropProducto.DataSource = from pr in ProductoController.FindAll()
                                      select new
                                      {
                                          codigo = pr.ID_Producto,
                                          texto = pr.NombreProducto
                                      };
            DropProducto.DataValueField = "codigo";
            DropProducto.DataTextField = "texto";
            DropProducto.DataBind();
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

        protected void BtnAgregar_Click(object sender, EventArgs e)
        {
            if (int.Parse(DropCapa.SelectedValue) == 1)
            {
                LbMensaje.Text = CapacitacionController.AddCapacitacion(1, int.Parse(DropProducto.SelectedValue), TxtLink.Text);
            }
            else
            {
                LbMensaje.Text = CapacitacionController.AddCapacitacion(2, int.Parse(DropProducto.SelectedValue), TxtLink.Text);
            }

        }

        protected void DropCapa_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        protected void LnkListar_Click(object sender, EventArgs e)
        {
            Response.Redirect("ListarProducto.aspx");
        }


    }
}