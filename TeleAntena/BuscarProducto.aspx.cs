using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using TeleAntena.Controladores;

namespace TeleAntena
{
    public partial class BuscarProducto : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }


        protected void BtnBuscar_Click(object sender, EventArgs e)
        {

            System.Threading.Thread.Sleep(3000);
            Productos producto = ProductoController.FindProducto(int.Parse(TxtBuscar.Text));
            if (producto != null)
            {
                PanelProducto.Visible = true;
                TxtCodigo.Text = producto.ID_Producto.ToString();
                LbNombre.Text = producto.NombreProducto;
                LbMarca.Text = producto.Marcas.NombreMarca;
                LbTipo.Text = producto.TipoProductos.NombreTipo;
                TxtStock.Text = producto.Stock.ToString();
                LbLink.Text = producto.URL;
                LbDetalle.Text = producto.DetalleProducto;
                Imagen.ImageUrl = "/Img/ImgProductos/" + producto.Imagen;

                Session["producto"] = producto;

            }
            else
            {
                PanelProducto.Visible = false;
                LbMensajeError.Text = "Producto no encontrado";
                Session["producto"] = null;
            }
        }

        protected void TextBox1_TextChanged(object sender, EventArgs e)
        {

        }

        protected void LnkManual_Click(object sender, EventArgs e)
        {
            Response.Redirect("AgregarManual.aspx");
        }

        protected void LnkVideo_Click(object sender, EventArgs e)
        {
            Response.Redirect("AgregarVideo.aspx");
        }

        protected void LnkCapacitacion_Click(object sender, EventArgs e)
        {
            Response.Redirect("AgregarCapacitacion.aspx");
        }

        protected void LinkButton1_Click(object sender, EventArgs e)
        {
            Response.Redirect("ListarManuales.aspx");
        }

        protected void LinkButton2_Click(object sender, EventArgs e)
        {
            Response.Redirect("ListarVideos.aspx");
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

        protected void BtnEditar_Click(object sender, EventArgs e)
        {
            //Agregar que solo deje editar el stock
            LbMensaje.Text = ProductoController.EditStockProducto(int.Parse(TxtCodigo.Text), int.Parse(TxtStock.Text));
        }

        protected void LnkModificarStock_Click1(object sender, EventArgs e)
        {
            TxtStock.Enabled = true;
            BtnEditar.Enabled = true;
        }
        protected void TxtStock_TextChanged(object sender, EventArgs e)
        {

        }

        protected void LnkEditar_Click(object sender, EventArgs e)
        {
            Response.Redirect("EditarProductos.aspx");
        }

        protected void LnkEliminar_Click(object sender, EventArgs e)
        {
            LbMensaje.Text = ProductoController.RemoveProducto(int.Parse(TxtCodigo.Text));
        }
    }
}