using Microsoft.EntityFrameworkCore.Metadata;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UsuariosUTN.Clases
{ 

    public class Clase
    {
        private int _idClassroom;
        private string _classroom;
        private string _Profesor;
        private string _Period;
        private string _materia;
        private int _idMateria;
        private int _idProfesor;
    
        private int _estadoMateria;
        public Clase(int idClassroom, string clasroom, string materia, string profesor, string periodo)
        {
            _materia = materia;
            _classroom = clasroom;
            _Profesor = profesor;
            _Period = periodo;
            _idClassroom = idClassroom;
        }//constructor listas 

        public Clase(int idMateria,int idProfesor,int idClassroom, string clasroom, string materia, 
            string profesor, string periodo):this( idClassroom, clasroom,materia,profesor,periodo)
        {
            _idMateria = idMateria;
            _idProfesor = idProfesor;
        }//Constructor sql

        public int IdClassroom { get => _idClassroom;  } 
        public int EstadoMateria { get => _estadoMateria; }
        public string Classroom { get => _classroom;  }
        public string Profesor { get => _Profesor;  }
        public string Period { get => _Period; }
        public int IdMateria { get => _idMateria;  }
        public string Materia { get => _materia;  }
        public int IdProfesor { get => _idProfesor;  }

        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.AppendLine($"{Materia} {Classroom}");
            return sb.ToString();
        }


    }


}
