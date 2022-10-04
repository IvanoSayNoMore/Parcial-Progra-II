using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UsuariosUTN.Enums;

namespace UsuariosUTN.Usuarios
{
    public abstract class Usuario
    {
        private string _nombre;
        private string _apellido;
        private string _contrasenia;
        private string _usuario;
        private long _legajo;

        protected Usuario(string nombre,string apellido,string usuario,string contrasenia,long legajo)
        {
            _nombre = nombre;
            _apellido = apellido;
            _contrasenia = contrasenia;
            _usuario = usuario;
            _legajo = legajo;
        }

        public virtual string MostrarDatosUsr()
        {
            StringBuilder sb = new StringBuilder();
            sb.AppendLine("---Usuario---");
            sb.AppendLine($"Nombre : {_nombre}");
            sb.AppendLine($"Apellido: {_apellido}");
            sb.AppendLine($"Legajo : {_legajo}");


            return sb.ToString();
        }

        #region
        public string NombreUsuario
        {
            get { return _usuario; }
            set { _usuario = value; }
        }
        public string Contrasenia
        {
            get { return _contrasenia; }
            set { _contrasenia = value; }
        }
        public string Nombre
        {
            get { return _nombre; }
            set { _nombre = value; }
        }

        public string Apellido
        {
            get { return _apellido; }
            set { _apellido = value; }
        }

        public long Legajo
        {
            get { return _legajo; }
        }
        #endregion


    }
}
