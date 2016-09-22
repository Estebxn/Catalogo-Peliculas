using Datos;
using Datos.DSAlquilerTableAdapters;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Windows.Forms;

namespace Login
{
    public partial class Login : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void btnIngresar_Click(object sender, EventArgs e)
        {
            if (CADUsuarios.ValidarUsuario(txtUser.Text, txtPassword.Text))
            {

                MessageBox.Show("usuario o clave no validos", "Error", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);

                txtUser.Text = "";
                txtPassword.Text = "";
                txtUser.Focus();
                return;
            }
        }
    }
}