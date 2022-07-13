using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using TeleAntena.Controladores;

namespace TeleAntena
{
    public partial class Login : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            //AdministradorController.CrearUsuarios();
            //MarcaController.CrearMarca();
            //TipoProductoController.CrearTipo();
            //ProductoController.CrearProductos();        
        }

        protected void BtnLogin_Click(object sender, EventArgs e)
        {
            Usuarios u = LoginController.Login(TxtUser.Text, TxtContra.Text);
            if (u != null)
            {
                Session["ActiveUser"] = u;
                Response.Redirect("AgregarProducto.aspx");
            }
            else
            {
                LbMensaje.Text = "Credenciales incorrectas";
                Session["ActiveUser"] = null;
            }
        }
    }
}