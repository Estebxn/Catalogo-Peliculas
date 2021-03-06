﻿using Datos.DSAlquilerTableAdapters;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Logica
{
    public class Usuarios
    {
        long IdUsuario;
        string Nombres;
        string Apellidos;
        string Correo;
        string Direccion;
        long Telefono;
        string Usuario;
        string Contraseña;
        string TipoUsuario;

        private static UsuariosTableAdapter Adaptador = new UsuariosTableAdapter();

        public long IdUsuario1
        {
            get
            {
                return IdUsuario;
            }

            set
            {
                IdUsuario = value;
            }
        }

        public string Nombres1
        {
            get
            {
                return Nombres;
            }

            set
            {
                Nombres = value;
            }
        }

        public string Apellidos1
        {
            get
            {
                return Apellidos;
            }

            set
            {
                Apellidos = value;
            }
        }

        public string Correo1
        {
            get
            {
                return Correo;
            }

            set
            {
                Correo = value;
            }
        }

        public string Direccion1
        {
            get
            {
                return Direccion;
            }

            set
            {
                Direccion = value;
            }
        }

        public long Telefono1
        {
            get
            {
                return Telefono;
            }

            set
            {
                Telefono = value;
            }
        }

        public string Usuario1
        {
            get
            {
                return Usuario;
            }

            set
            {
                Usuario = value;
            }
        }

        public string Contraseña1
        {
            get
            {
                return Contraseña;
            }

            set
            {
                Contraseña = value;
            }
        }

        public string TipoUsuario1
        {
            get
            {
                return TipoUsuario;
            }

            set
            {
                TipoUsuario = value;
            }
        }

        public void AgregarUsuario(long IdUsuario, string Nombres, string Apellidos, string Telefono, string Direccion, string Correo, string Usuario, string Contraseña, string TipoUsuario)
        {
            Adaptador.spr_AgregarUsuarios(IdUsuario, Nombres, Apellidos, Telefono, Correo, Direccion, Usuario, Contraseña, TipoUsuario);
        }

        public void ActualizarDatos(long IdUsuario, string Nombres, string Apellidos, string Telefono, string Direccion, string Correo, string Usuario, string Contraseña)
        {
            Adaptador.spr_ActualizarDatos(Nombres, Apellidos, Correo, Telefono, Direccion, Usuario, Contraseña, IdUsuario);
        }

        public void EliminarUsuarios(long IdUsuario)
        {
            Adaptador.spr_EliminarUsuarios(IdUsuario);
        }
    }
}
