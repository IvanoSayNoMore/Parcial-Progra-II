using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UsuariosUTN.Usuarios
{
    public class Materia
    {
        // nuevo

        private int _idMatter;
        private string _materia;
        private int _mCorrelativa;
        private int _idClassroom;
        private int _idAlumno;

        public int IdMateria { get => _idMatter;   }
        public string Materia_ { get => _materia;  }
        public int Id_Correlativa { get => _mCorrelativa;  }
        public int IdClassroom { get => _idClassroom; set => _idClassroom = value; }
        public int IdAlumno { get => _idAlumno;  }


        public Materia(string nombreMateria)
        {
            _materia = nombreMateria;
        }
        public Materia(string nombreMateria, int mCarroletaiva):this(nombreMateria)
        {
           
            _mCorrelativa = mCarroletaiva;
        }

        // para listar materias y comprar con correlativas
        public Materia(int id,string nombreMateria,int mCarroletaiva):this(nombreMateria, mCarroletaiva)
        {
            _idMatter = id;
           
        }

        public Materia(int idClassroom ,int idAlumno,string nombreMateria):this(nombreMateria)
        {
            _idAlumno = idAlumno;
            _idClassroom = idClassroom;
        }

        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.AppendLine($"{_materia}");


            return sb.ToString();
        }
    }
}
