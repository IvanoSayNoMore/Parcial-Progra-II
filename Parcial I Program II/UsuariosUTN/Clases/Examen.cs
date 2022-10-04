using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UsuariosUTN.Usuarios
{
    public class Examen
    {
        private string _materia;
        private EParcialesPromedio _parcialesPromedio;
        private decimal _nota;
        private long _legajoALumno;
        private long _legajoProfesor;
        string _fecha;
        public Examen(string fecha,string materia,long legajoProfesor, long legajoAlumno,decimal nota,
            EParcialesPromedio tipo) 
        {
            _parcialesPromedio = tipo;            
            _materia = materia;
            _legajoProfesor = legajoProfesor;
            _legajoALumno = legajoAlumno;
            _nota = nota;
            _fecha = fecha;
        }
     
        public EParcialesPromedio TipoParcial
        {
            get { return _parcialesPromedio; }           
        }
        public long LegajoAlumno
        {
            get { return _legajoALumno; }
        }
        public long LegajoProfesor
        {
            get { return _legajoProfesor; }
        }
        public decimal Nota
        {
            get { return _nota; }
             
        }
        public string Materia
        {
            get { return _materia; }
        }
        public string Fecha
        {
            get { return _fecha; }
        }
 
    }
}
