using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UsuariosUTN.Clases
{
    public class Periodos
    {
        private int _idPeriodo;
        private string _nombre;
        private DateTime inicio;
        private DateTime fin;

        public Periodos(string nombre, DateTime inicio, DateTime fin)
        {
            _nombre = nombre;
            this.inicio = inicio;
            this.fin = fin;
        }

        public Periodos(int idPeriodo, string nombre, DateTime inicio, DateTime fin):this(nombre,inicio,fin)
        {
            _idPeriodo = idPeriodo;
      
        }

        public override string ToString()
        {
            return $"{Nombre}";
        }

        public int IdPeriodo { get => _idPeriodo;  }
        public string Nombre { get => _nombre; }
        public DateTime Inicio { get => inicio; }
        public DateTime Fin { get => fin; }
    }
}
