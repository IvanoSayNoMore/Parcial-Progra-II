using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Intrinsics.X86;
using System.Text;
using System.Threading.Tasks;
using UsuariosUTN.Enums;

namespace UsuariosUTN.Usuarios
{
    public class TipoUsuario : Usuario
    {
        private ETiposUsuarios _tipoUsuario;

        public TipoUsuario(string nombre,string apellido,string usuario,int legajo) : base (nombre,apellido,usuario,legajo)
        {

        }
        public TipoUsuario(string nombre, string apellido, string usuario, string contrasenia,
                 int legajo, int tipo) : base(nombre, apellido, usuario, contrasenia, legajo)

        {
            _tipoUsuario = GetTipoDeUsuario(tipo);
        }
        public override string ToString()
        {
            return base.ToString();
        }

        public ETiposUsuarios TipoUsuarix
        {
            get { return _tipoUsuario; }

        }

        private static ETiposUsuarios GetTipoDeUsuario(int tipo)
        {
            ETiposUsuarios eTiposUsuarios = new ETiposUsuarios();
 

            switch (tipo)
            {
                case 1:
                    eTiposUsuarios = ETiposUsuarios.Admin;
                    break;
                case 3:
                    eTiposUsuarios = ETiposUsuarios.Alumno;
                    break;
                case 2:
                    eTiposUsuarios = ETiposUsuarios.Profesor;
                    break;

            }
            return eTiposUsuarios;

        }


    }
}
