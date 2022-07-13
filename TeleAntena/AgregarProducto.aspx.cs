using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using TeleAntena.Controladores;

namespace TeleAntena
{
    public partial class AgregarProducto : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            //Nos permite obtener los datos que enviamos despues del fomulario
            if (!Page.IsPostBack)
            {
                CargarDropTipo();
                CargarDropMarca();
            }



        }
        //Crear metodo para cargar drop
        public void CargarDropMarca()
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

        public void CargarDropTipo()
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
        protected void BtnAgregar_Click(object sender, EventArgs e)
        {
            Productos producto = ProductoController.FindProducto(int.Parse(TxtCodigo.Text));
            if (producto == null)
            {
                string imagenPath = Server.MapPath("~/Img/ImgProductos/");
                string nombreImagen = "";
                if (fuImagen.HasFile)
                {
                    nombreImagen = fuImagen.FileName;
                    string extension = System.IO.Path.GetExtension(nombreImagen);
                    if ((extension == ".jpg") || (extension == ".png"))
                    {
                        imagenPath += nombreImagen;
                        fuImagen.SaveAs(imagenPath);
                        LbMensaje.Text = ProductoController.AddProducto(int.Parse(TxtCodigo.Text),
                        TxtNombre.Text,
                        int.Parse(DropMarca.SelectedValue),
                        int.Parse(DropTipo.SelectedValue),
                        int.Parse(TxtStock.Text),
                        TxtDetalle.Text,
                        nombreImagen,
                        TxtLink.Text);
                    }
                    else
                    {
                        LbMensaje.Text = "La imagen ingresada no contiene el formato necesario. Ingrese imagenes formato .jpg o .png";
                    }
                }
                else
                {
                    nombreImagen = "predetermined.jpg";
                    //LbMensaje mostar el string que retorna al metodo del producto
                    LbMensaje.Text = ProductoController.AddProducto(int.Parse(TxtCodigo.Text),
                    TxtNombre.Text,
                    int.Parse(DropMarca.SelectedValue),
                    int.Parse(DropTipo.SelectedValue),
                    int.Parse(TxtStock.Text),
                    TxtDetalle.Text,
                    nombreImagen,
                    TxtLink.Text);
                }
            }
            else
            {
                LbMensaje.Text = "Ya existe un producto con ese código. Por favor, ingrese un código distinto.";
            }
        }

        protected void TxtDetalle_TextChanged(object sender, EventArgs e)
        {

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

        protected void DropMarca_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        protected void DropTipo_SelectedIndexChanged(object sender, EventArgs e)
        {

        }


    }
}