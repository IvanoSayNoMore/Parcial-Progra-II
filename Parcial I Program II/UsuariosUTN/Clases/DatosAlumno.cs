using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UsuariosUTN.Clases
{
    public  class DatosAlumno
    {
        private int _legajoAlumno;
        private int _idMateria;
        private int _estadoMateria;
        private string _materia;
        private int _idClassroom;
        static private EEstadoCursada _eEstadoCursada;
        private decimal _promedio;

     
        private DatosAlumno(int idEstudiante)
        {
            _legajoAlumno = idEstudiante;
        }

        public DatosAlumno(int idEstudiante, int idMateria, int estadoMateria, int idClassRoom) :this(idEstudiante)
        {           
            _idMateria = idMateria;
            _estadoMateria = estadoMateria;
            _idClassroom = idClassRoom;
        }

        public DatosAlumno(int idEstudiante,int idClassRoom):this(idEstudiante)
        {
            _idClassroom =  idClassRoom;
        }


        public int LegajoAlumno { get => _legajoAlumno; }
        public int IdMateria { get => _idMateria; }
        public int EstadoMateria { get => _estadoMateria; }
        public int IdClassroom { get => _idClassroom; }

        public static bool operator ==(DatosAlumno notas, string materia)
        {
            bool retorno = false;
            if(notas is not null)
            {
                if(notas._materia == materia)
                {
                    retorno = true;
                }
            }

            return retorno;
        }

        public static bool operator !=(DatosAlumno notas, string materia)
        {      
            return !(notas==materia);
        }

        public static bool operator ==(DatosAlumno notas, decimal legajoAlumno)
        {
            bool retorno = false;

            if(notas is not null && legajoAlumno > 0)
            {
                if(notas._legajoAlumno==legajoAlumno)
                {
                    retorno = true;
                }
            }

            return retorno;
        }

        public static bool operator !=(DatosAlumno notas, decimal legajoAlumno)
        {
            return !(notas == legajoAlumno);
        }

    }
}
