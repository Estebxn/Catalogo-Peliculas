using Datos;
using Presentacion;
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
            if(oAdap.spr_Autenticacion(txtUser.Text, txtPassword.Text).ToString() == "Administrador")
            {
                PeliculasPrestadas PelisPres = new PeliculasPrestadas();
                PelisPres.Show();
                MessageBox.Show("Bienvenido Administrador", "Accedio Correctamente", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                if(oAdap.spr_Autenticacion(txtUser.Text, txtPassword.Text).ToString() == "Cliente")
                {
                    PeliculasDisponibles PelisDispo = new PeliculasDisponibles();
                    PelisDispo.Show();
                    MessageBox.Show("Bienvenido Señor Usuario", "Accedio Correctamente", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
        }
    }
}