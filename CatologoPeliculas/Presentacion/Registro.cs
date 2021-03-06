﻿using Logica;
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
    public partial class Registro : Form
    {
        public Registro()
        {
            InitializeComponent();
        }

        Usuarios oUsuarios = new Usuarios();


        ValidacionCampos oVal = new ValidacionCampos();
        private void textBox1_KeyPress(object sender, KeyPressEventArgs e)
        {
            oVal.Numeros(e);
        }

        private void txtNombres_KeyPress(object sender, KeyPressEventArgs e)
        {
            oVal.Letras(e);
        }

        private void txtApellidos_KeyPress(object sender, KeyPressEventArgs e)
        {
            oVal.Letras(e);
        }

        private void txtTelefono_KeyPress(object sender, KeyPressEventArgs e)
        {
            oVal.Numeros(e);
        }

        private void txtDireccion_KeyPress(object sender, KeyPressEventArgs e)
        {
            oVal.LetrasNumeros(e);
        }

        private void txtCorreo_KeyPress(object sender, KeyPressEventArgs e)
        {

        }

        private void txtUser_KeyPress(object sender, KeyPressEventArgs e)
        {
            oVal.LetrasNumeros(e);
        }

        private void txtPassword_KeyPress(object sender, KeyPressEventArgs e)
        {
            oVal.LetrasNumeros(e);
        }

        private void cbxTipoUsuario_KeyPress(object sender, KeyPressEventArgs e)
        {
            oVal.Letras(e);
        }

        private void btnRegistrar_Click(object sender, EventArgs e)
        {
            oUsuarios.AgregarUsuario(long.Parse(txtIdUsuario.Text), txtNombres.Text, txtApellidos.Text, txtTelefono.Text, txtDireccion.Text, txtCorreo.Text, txtUser.Text, Encriptacion.GetMD5(txtPassword.Text), cbxTipoUsuario.Text);
        }

        private void lblLimpiar_Click(object sender, EventArgs e)
        {
            txtIdUsuario.Clear();
            txtNombres.Clear();
            txtApellidos.Clear();
            txtTelefono.Clear();
            txtCorreo.Clear();
            txtUser.Clear();
            txtPassword.Clear();
        }

        private void Registro_Load(object sender, EventArgs e)
        {

        }

        private void btnVolver_Click(object sender, EventArgs e)
        {
            Login oLogin = new Login();
            oLogin.Show();
            this.Hide();
        }
    }
}
