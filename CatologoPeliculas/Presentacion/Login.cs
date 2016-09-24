using Datos;
using Datos.DSAlquilerTableAdapters;
using Logica;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Presentacion
{
    public partial class Login : Form
    {
        public Login()
        {
            InitializeComponent();
        }

        ValidacionCampos oVal = new ValidacionCampos();

        private void btnIngresar_Click(object sender, EventArgs e)
        {
            UsuariosTableAdapter Adaptador = new UsuariosTableAdapter();
            if (txtUser.Text == "")
            {
                errorProvider1.SetError(txtUser, "Debe ingresar un Usuario");
                txtUser.Focus();
                return;
            }
            errorProvider1.SetError(txtUser, "");

            if (txtPassword.Text == "")
            {
                errorProvider2.SetError(txtPassword, "Debe ingresar una Clave");
                txtPassword.Focus();
                return;
            }
            errorProvider2.SetError(txtPassword, "");

            if (!CADUsuarios.ValidarUsuario(txtUser.Text, txtPassword.Text))
            {

                MessageBox.Show("usuario o clave no validos", "Error", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);

                txtUser.Text = "";
                txtPassword.Text = "";
                txtUser.Focus();
                return;
            }
            else
            {
                if (Adaptador.spr_Autenticacion(txtUser.Text, txtPassword.Text).ToString() == "Administrador")
                {
                    Peliculas oPelis = new Peliculas();
                    oPelis.Show();
                    this.Hide();
                }
                else
                {
                    if (Adaptador.spr_Autenticacion(txtUser.Text, txtPassword.Text).ToString() == "Doctor")
                    {
                        PeliculasDisponibles oPelisDispo  = new PeliculasDisponibles();
                        oPelisDispo.Show();
                        this.Hide();
                    }
                }
            }
        }

        private void textBox1_KeyPress(object sender, KeyPressEventArgs e)
        {
            oVal.LetrasNumeros(e);
        }

        private void textBox2_KeyPress(object sender, KeyPressEventArgs e)
        {
            oVal.LetrasNumeros(e);
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
