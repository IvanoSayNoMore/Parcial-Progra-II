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
        private int _legajo;

        protected Usuario(string nombre,string apellido,string usuario,int legajo)
        {
            _nombre = nombre;
            _apellido = apellido;
            _usuario = usuario;
            _legajo = legajo;
        }

        protected Usuario(string nombre,string apellido,string usuario,string contrasenia,int legajo):this(nombre,apellido,usuario,legajo)
        {            
            _contrasenia = contrasenia;
       
        }

        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.AppendLine($"{_nombre} ");
            sb.AppendLine($"{_apellido} ");
            sb.AppendLine($" {_legajo} ");
            return sb.ToString();
        }


        #region
        public string Contraseña
        {
            get { return _contrasenia; }
        }
        public string NombreUsuario
        {
            get { return _usuario; }
            set { _usuario = value; }
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

        public int Legajo
        {
            get { return _legajo; }
        }
        #endregion


    }
}
