using Datos.DSAlquilerTableAdapters;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Datos
{
    public class CADUsuarios
    {
        private static UsuariosTableAdapter adaptador = new UsuariosTableAdapter();
        public static bool ValidarUsuario(string Usuario, string Contraseña)
        {
            if (adaptador.spr_Autenticacion(Usuario, Contraseña) == null)
            {
                return false;
            }
            else
            {
                return true;
            }
        }
    }
}
