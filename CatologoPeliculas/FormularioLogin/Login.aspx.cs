using Datos.DSAlquilerTableAdapters;
using Logica;
using Presentacion;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Windows.Forms;

namespace FormularioLogin
{
    public partial class Login : System.Web.UI.Page
    {
        UsuariosTableAdapter oAdapter = new UsuariosTableAdapter();
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void btnIngresar_Click(object sender, EventArgs e)
        {
            if (oAdapter.spr_Autenticacion(txtUser.Text, Encriptacion.GetMD5(txtPassword.Text).ToString()) == "Administrador")
            {
               // PeliculasPrestadas PelisPre = new PeliculasPrestadas();
               // PelisPre.Show();
                MessageBox.Show("Bienvenido Señor Administrador", "Accedio Exitosamente", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                if (oAdapter.spr_Autenticacion(txtUser.Text, Encriptacion.GetMD5(txtPassword.Text).ToString()) == "Cliente")
                {
                   // PeliculasDisponibles PelisPre = new PeliculasDisponibles();
                   // PelisPre.Show();
                    MessageBox.Show("Bienvenido Señor Administrador", "Accedio Exitosamente", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
        }
    }
}