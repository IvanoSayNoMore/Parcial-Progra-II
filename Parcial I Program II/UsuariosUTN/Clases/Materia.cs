using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UsuariosUTN.Usuarios
{
    public class Materia
    {
        private string _materia;
        private int _cuatrimestre;
        private bool _flagProfe = false;
        private string _mCorrelativa;
        private long _legajoProfesore;
        private string _apellidoProfe;
        private Dictionary<long, int> _AsistenciaAlumnos;
       
        private Materia()
        {
            _AsistenciaAlumnos = new Dictionary<long,int>();
        }
        
        public Materia(string nombreMateria,int cuatrimestre,string mCarroletaiva):this()
        {
            _materia = nombreMateria;
            _cuatrimestre = cuatrimestre;
            _mCorrelativa = mCarroletaiva;
            
        }
       
        public static bool DarAsistencia(Materia mat, long legajoAlumno)
        {
            bool retorno = false;
            if(mat == legajoAlumno)
            {
                mat._AsistenciaAlumnos[legajoAlumno] += 1;
                retorno = true;
            }  
            return retorno;
        }

        public string MostrarDatosDeMateria()
        {
            
            StringBuilder sb = new StringBuilder();
            sb.AppendLine($"Materia: {_materia}");
            sb.AppendLine($"Cuatrimestre: {_cuatrimestre}");
            sb.AppendLine($"Correlativa: {_mCorrelativa}");
            
            sb.AppendLine("/******************************/");
           
            return sb.ToString();
        }
    
        public string Nombre_De_Materia
        {
            get { return this._materia; }
            set { this._materia = value; }
        }
        public long Legajo_Profesor
        {
            get { return _legajoProfesore; }
            set { _legajoProfesore = value; }
        }
        public string Apellido_Profesor
        {
            get { return _apellidoProfe; }
        }
        public string Correlativa
        {
            get { return _mCorrelativa; }
        }
        public int Cuatrimestre
        {
            get { return _cuatrimestre; }
        }
        public bool FlagProfe
        {
            get { return _flagProfe; }
        }

        public static bool operator +(Materia materia, long legajoAlumno)
        {
            bool retorno = false;
            if(materia is not null && legajoAlumno != 0)
            {
                if(materia!=legajoAlumno)
                {                    
                    materia._AsistenciaAlumnos.Add(legajoAlumno,0);
                    retorno = true;
                }
            }
            return retorno;
        }
        public static bool operator ==(Materia materia, long legajoAlumno)
        {         
            bool retorno = false;
            if(materia is not null && legajoAlumno != 0)
            {
                if (materia._AsistenciaAlumnos.ContainsKey(legajoAlumno))
                {
                    retorno = true;
                }
            }
            return retorno;
        }
        public static bool operator !=(Materia materia, long legajoAlumno)
        {
            return !(materia== legajoAlumno);   
        }
        public static bool operator+(Materia materia, Usuario profesor)
        {
            bool retorno = false;
            if(materia is not null && profesor is not null)
            {
                if(materia != profesor)
                {
                    if (materia._flagProfe == false)
                    {
                        materia._flagProfe = true;
                        materia._apellidoProfe = profesor.Apellido;
                        materia.Legajo_Profesor = profesor.Legajo;
                        retorno = true;
                    }
                }

            }
            return retorno;
        }
        public static bool operator ==(Materia materia, Usuario profesor)
        {
            bool retorno = false;
            if(materia is not null && profesor is not null)
            {
                if(materia._legajoProfesore == profesor.Legajo)
                {
                    retorno = true;
                }
            }
            return retorno;
        }
        public static bool operator !=(Materia materia, Usuario profesor)
        {
            return !(materia == profesor);
        }

    }
}
