using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using TeleAntena.Controladores;

namespace TeleAntena
{
    public partial class EditarProductos : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!Page.IsPostBack)
            {
                cargarDropTipo();
                cargarDropMarca();
                cargarDatos();
            }
        }
        public void cargarDatos()
        {
            if (Session["producto"] == null)
            {
                Response.Redirect("BuscarProducto");
            }

            Productos producto = (Productos)Session["producto"];
            TxtCodigo.Text = producto.ID_Producto.ToString();
            TxtNombre.Text = producto.NombreProducto;
            TxtStock.Text = producto.Stock.ToString();
            TxtLink.Text = producto.URL;
            TxtDetalle.Text = producto.DetalleProducto;
            DropTipo.SelectedValue = producto.TipoProductos.ID_TipoProducto.ToString();
            DropMarca.SelectedValue = producto.Marcas.ID_Marca.ToString();
        }

        public void cargarDropMarca()
        {
            DropMarca.DataSource = from ma in MarcaController.FindAll()
                                   select new
                                   {
                                       codigo = ma.ID_Marca,
                                       texto = ma.NombreMarca
                                   };
            DropMarca.DataValueField = "codigo";
            DropMarca.DataTextField = "texto";
            DropMarca.DataBind();
        }

        public void cargarDropTipo()
        {
            DropTipo.DataSource = from ti in TipoProductoController.FindAll()
                                  select new
                                  {
                                      codigo = ti.ID_TipoProducto,
                                      texto = ti.NombreTipo
                                  };
            DropTipo.DataValueField = "codigo";
            DropTipo.DataTextField = "texto";
            DropTipo.DataBind();
        }

        protected void TxtCodigo_TextChanged(object sender, EventArgs e)
        {

        }

        protected void BtnEditar_Click(object sender, EventArgs e)
        {
            if (fuImagen.HasFile)
            {
                string imagenPath = Server.MapPath("~/Img/ImgProductos/");
                string nombreImagen = fuImagen.FileName;
                string extension = System.IO.Path.GetExtension(nombreImagen);
                if ((extension == ".jpg") || (extension == ".png"))
                {
                    imagenPath += nombreImagen;
                    fuImagen.SaveAs(imagenPath);
                    LbMensaje.Text = ProductoController.EditProducto(int.Parse(TxtCodigo.Text), TxtNombre.Text, int.Parse(DropMarca.SelectedValue), int.Parse(DropTipo.SelectedValue), int.Parse(TxtStock.Text), TxtLink.Text, TxtDetalle.Text, nombreImagen);
                }
                else
                {
                    LbMensaje.Text = "La imagen ingresada no contiene el formato necesario. Ingrese imagenes formato .jpg o .png";
                }

            }
            else
            {
                Productos producto = (Productos)Session["producto"];
                String Imagen = producto.Imagen;
                LbMensaje.Text = ProductoController.EditProducto(int.Parse(TxtCodigo.Text), TxtNombre.Text, int.Parse(DropMarca.SelectedValue), int.Parse(DropTipo.SelectedValue), int.Parse(TxtStock.Text), TxtLink.Text, TxtDetalle.Text, Imagen);
            }
        }
    }
}