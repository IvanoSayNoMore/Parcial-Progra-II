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

        public TipoUsuario(string nombre, string apellido, string usuario, string contrasenia,
                 long legajo, ETiposUsuarios tipo) : base(nombre, apellido, usuario, contrasenia, legajo)

        {
            _tipoUsuario = tipo;
        }
        public override string MostrarDatosUsr()
        {
            StringBuilder sb = new StringBuilder();
            sb.AppendLine(base.MostrarDatosUsr());
            return sb.ToString();
        }
        public ETiposUsuarios TipoUsuarix
        {
            get { return _tipoUsuario; }
            
        }     
 


    }
}
