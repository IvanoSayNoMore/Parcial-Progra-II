using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UsuariosUTN.Clases
{
    public  class NotasAlumno
    {
        private long _legajoAlumno;
        private string _materia;
        static private decimal _pParcial = -1;
        static private decimal _sParcial = -1;
        static private decimal _recuPParcial;
        static private decimal _recuSParcial;
        static private EEstadoCursada _eEstadoCursada;
        static private EEstadoMateria _estadoMateria;
        private decimal _promedio ;

          
        public NotasAlumno(string materia,long legajoAlumno )
        {
            _materia = materia;
            _legajoAlumno = legajoAlumno;
            _eEstadoCursada = EEstadoCursada.Regular;
        }

        public bool AgregarNota(decimal nota, EParcialesPromedio tipoParcial)
        {
            bool retorno = false;
            if(tipoParcial == EParcialesPromedio.pParcial)
            {   
                if(_pParcial == -1)
                {
                    _pParcial = nota;
                    retorno = true;
                }                
            }
        
            if(tipoParcial == EParcialesPromedio.sParcial 
                &&_sParcial == -1 
                && _eEstadoCursada == EEstadoCursada.Regular)
            {
                _sParcial = nota;
                _promedio = (_pParcial + _pParcial) / 2;
                if(_promedio>4)
                {
                    _estadoMateria = EEstadoMateria.Aprobada;
                    retorno = true;
                }
                else
                {
                    _estadoMateria = EEstadoMateria.Recursa;
                    retorno = true;
                }
            }
            return retorno;
        }

        public decimal PrimerParcial
        {
            get { return _pParcial; }
        }

        public decimal SegundoParcial
        {
            get { return _sParcial; }
        }

        public decimal Promedio
        {
            get { return _promedio; }
        }
        public EEstadoCursada estadoCursada
        {
            get { return _eEstadoCursada; }
            set { _eEstadoCursada = value; }
        }

        public long LegajoAlumno
        {
            get { return _legajoAlumno; }
        }

        public string Materia
        {
            get { return _materia; }
        }

        public static bool operator ==(NotasAlumno notas, string materia)
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

        public static bool operator !=(NotasAlumno notas, string materia)
        {      
            return !(notas==materia);
        }

        public static bool operator ==(NotasAlumno notas, decimal legajoAlumno)
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

        public static bool operator !=(NotasAlumno notas, decimal legajoAlumno)
        {
            return !(notas == legajoAlumno);
        }

    }
}
