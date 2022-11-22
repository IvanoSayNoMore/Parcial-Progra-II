using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UsuariosUTN.Usuarios
{
    public class Examen
    {
     
        private string _apellidoEstudiante;
        private string _nombreEstudiante;
        private string _nombreMateria;
        private string _cuatrimestre;
        private DateTime _fecha;
        private decimal _nota;
        private int _idEstudiante;
        private int _idAlumno;
        private int _idPeriodo;
        private int _idMatter;
        private int _tipoParcial;


        public Examen(int idAlumno, DateTime fecha, int idPeriodo, decimal nota, int idMatter,int idTipoParcial)
        {
            _tipoParcial = idTipoParcial;
            _idAlumno = idAlumno;
            _fecha = fecha;
            _idPeriodo = idPeriodo;
            _nota = nota;
            _idMatter = idMatter;
        }//para insert


        public Examen(int idEstudiante,string apellidoEstudiante, 
            string nombreEstudiante, string nombreMateria, string cuatrimestre, DateTime fecha, decimal nota,int idTipoParcial)
        {
            _idEstudiante = idEstudiante;
            _apellidoEstudiante = apellidoEstudiante;
            _nombreEstudiante = nombreEstudiante;
            _nombreMateria = nombreMateria;
            _cuatrimestre = cuatrimestre;
            _fecha = fecha;
            _nota = nota;
            _tipoParcial = idTipoParcial;
        }

        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.AppendLine($"Materia: {NombreMateria}");
            sb.AppendLine($"Nota: {Nota}");

            return sb.ToString();
        }

        public string ApellidoEstudiante { get => _apellidoEstudiante;  }
        public string NombreEstudiante { get => _nombreEstudiante;  }
        public string NombreMateria { get => _nombreMateria;  }
        public string Cuatrimestre { get => _cuatrimestre;  }
        public DateTime Fecha { get => _fecha;}
        public decimal Nota { get => _nota; }
        public int IdEstudiante { get => _idEstudiante; set => _idEstudiante = value; }
        public int IdAlumno { get => _idAlumno;  }
        public int IdPeriodo { get => _idPeriodo;  }
        public int IdMatter { get => _idMatter; }
        public int TipoParcial { get => _tipoParcial;  }
    }
}
