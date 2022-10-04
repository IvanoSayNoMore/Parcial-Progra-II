using Microsoft.VisualBasic.ApplicationServices;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UsuariosUTN.Clases;
using UsuariosUTN.Enums;
using UsuariosUTN.Usuarios;

namespace UTNFacultad
{
    static class LogicaUTNAvellaneda
    {
        static List<Usuario> _listaUsuarios;
        static List<Materia> _materias;
        static List<Examen> _examenes;
        static List<NotasAlumno> _notasAlumnos;
        static LogicaUTNAvellaneda()
        {
            _listaUsuarios = new List<Usuario>();
            _materias = new List<Materia>();
            _examenes = new List<Examen>();
            _notasAlumnos = new List<NotasAlumno>();
            HardCode();
        }
        private static void HardCode()
        {
            bool aux;
            Usuario admin = new TipoUsuario("z", "z", "z", "z", 1005, ETiposUsuarios.Admin);
            Usuario ivan = new TipoUsuario("Ivan", "Fabella", "a", "a", 1001, ETiposUsuarios.Alumno);
            Usuario aldana = new TipoUsuario("Aldana", "Medina", "b", "b", 1002, ETiposUsuarios.Alumno);
            Usuario prof = new TipoUsuario("Profesor", "Profesor", "c", "c", 1003, ETiposUsuarios.Profesor);
            
            LogicaUTNAvellaneda.AgregarUsuarioALista(prof);
            LogicaUTNAvellaneda.AgregarUsuarioALista(ivan);
            LogicaUTNAvellaneda.AgregarUsuarioALista(aldana);
            LogicaUTNAvellaneda.AgregarUsuarioALista(admin);

            Examen exam = new Examen("19/04/1993","Ingles", prof.Legajo, ivan.Legajo, 10, EParcialesPromedio.pParcial);

            NotasAlumno nuevasNotas = new NotasAlumno(exam.Materia, ivan.Legajo);
            nuevasNotas.estadoCursada = EEstadoCursada.Regular;
            nuevasNotas.AgregarNota(exam.Nota, exam.TipoParcial);

            LogicaUTNAvellaneda.AgregaNotasAlumno(nuevasNotas);
            Materia mat0 = new Materia("Matematica", 1, "No tiene");
            Materia mat = new Materia("Matematica II", 1, "Matematica");
            Materia mat2 = new Materia("Ingles II", 1, "Ingles");
            Materia mat3 = new Materia("Laboratorio II", 1, "Laboratorio");
            //aux = mat + alum.Legajo;
            aux = mat2 + ivan.Legajo;//agrega alumno a materia 
            aux = mat2 + aldana.Legajo;

            if (mat+prof)
            {
                Console.WriteLine("Se agrego ok ");
            }

            //Materia.DarAsistencia(mat, ivan.Legajo);
            _materias.Add(mat0);
            _materias.Add(mat);
            _materias.Add(mat2);
            _materias.Add(mat3);
            _examenes.Add(exam);      
        }
     
        public static TipoUsuario logUsr(string nombre, string pass)
        {
            TipoUsuario usr = null;
            
            if(ValidarDosCampos(nombre, pass))
            {
                foreach (TipoUsuario usuario in _listaUsuarios)
                {
                    if (usuario.NombreUsuario == nombre && usuario.Contrasenia == pass)
                    {
                        usr = usuario;
                        break;
                    }
                }
            }            
            return usr;
        }
        
        private static bool ValidarDosCampos(string camp1, string camp2)
        {
            bool retorno = true;
            if (string.IsNullOrEmpty(camp1) || string.IsNullOrEmpty(camp2))
            {
                retorno = false;

            }
            return retorno;
        }
       
        public static bool CrearMateria(string nombreMateria, int cuatrimestre, 
                                        string mCarroletaiva)
        {
            bool retorno = false;
            if (nombreMateria != null)
            {

                if(BuscaMateriaEnLista(nombreMateria,cuatrimestre,_materias)is not null)
                {
                    _materias.Add(new Materia(nombreMateria, cuatrimestre, mCarroletaiva));
                    retorno = true;
                }             
            }
            return retorno;
        }


        public static bool AgregaExamenALista(Examen nuevoExamen)
        {
            bool retorno = false;
            if(!_examenes.Contains(nuevoExamen))
            {
                _examenes.Add(nuevoExamen);
                retorno = true;
            }
            return retorno;
        }

        public static bool AgregaNotasAlumno(NotasAlumno notaMateria)
        {
            bool retorno = false;

            if(!_notasAlumnos.Contains(notaMateria))
            {
                _notasAlumnos.Add(notaMateria);
                retorno = true;
            }
            return retorno;
        }

        public static bool AgregarUsuarioALista(Usuario usr)
        {
            bool retorno = false;

            if (!_listaUsuarios.Contains(usr))
            {
                _listaUsuarios.Add(usr);
                retorno = true;
            }
            return retorno;
        }

        public static string MostrarNotasPorAlumno(Usuario Alumno)
        {
            bool flagNota = false;
            StringBuilder sb = new StringBuilder();

            foreach(NotasAlumno item in _notasAlumnos)
            {
                if(item.LegajoAlumno == Alumno.Legajo)
                {
                    sb.AppendLine($"Materia {item.Materia}");

                    if (item.PrimerParcial != -1)
                    {
                        sb.AppendLine($"Primer Parcial{item.PrimerParcial}");
                    }
                    if(item.SegundoParcial != -1)
                    {
                        sb.AppendLine($"Segundo Parcial {item.SegundoParcial}");
                        sb.AppendLine($"Promedio {item.Promedio}");
                    }
                    
                    flagNota = true;
                }
            }
            if (!flagNota)
            {
                sb.AppendLine("No se encontraron examenes del alumno B");
            }
            return sb.ToString();
        }

        public static string MostrarExamenPorAlumno(Usuario Alumno)
        {
            bool flagNota = false;
            StringBuilder sb = new StringBuilder();
            
            foreach (Examen item in _examenes)
            {

                //Mostrar datos personales del alumno
                if (item.LegajoAlumno == Alumno.Legajo)
                {
                    sb.AppendLine($"Materia {item.Materia}");

                    if(item.TipoParcial.ToString() == "pParcial")
                    {
                        sb.Append("Primer Parcial");
                    }
                    else
                    {
                        if (item.TipoParcial.ToString() == "sParcial")
                        {
                            sb.Append("Segundo Parcial");
                        }
                        else
                        {
                            sb.Append("Promedio");
                        }
                    }
                    sb.AppendLine($", nota: {item.Nota}");
                    flagNota = true;
                }
            }
          
            if (!flagNota)
            {
                sb.AppendLine("No se encontraron examenes del alumno");
            }
            return sb.ToString();
        }
      
        public static List<Materia> ListarMarteriasAlumno(long legajousr)
        {
            List<Materia> auxLista = new List<Materia>();
            foreach(Materia item in _materias)
            {
                if (item==legajousr)
                {
                    auxLista.Add(item);
                }
            }       

            return auxLista;

        }

        public static List<Materia> ListarMarteriasProfesor(Usuario profesor)
        {
            List<Materia> auxLista = new List<Materia>();
            foreach (Materia item in _materias)
            {
                if (item == profesor)
                {
                    auxLista.Add(item);
                }
            }

            return auxLista;

        }
       
        public static List<Materia> ListaMaterias()
        {
            List<Materia> lista;
            if (_materias.Count > 0)
            {
                lista = _materias;
            }
            else
            {
                lista = null;
            }

            return lista;
        }

        public static List<Materia> ListaMateriasSinProfesor()
        {
            List<Materia> lista = new List<Materia>();
            foreach (Materia item in _materias)
            {
                if(item.FlagProfe == false)
                {
                    lista.Add(item);
                }
            }
            return lista;
        }
        
        public static List<Usuario> ListarProfesores()
        {
            List<Usuario> lista = new List<Usuario>();

            foreach(TipoUsuario item in _listaUsuarios)
            {
                if(item.TipoUsuarix == ETiposUsuarios.Profesor)
                {
                    lista.Add(item);
                }
            }
            return lista;
        }

        public static Usuario BuscaProfesorPorLegajo(long legajo)
        {
            Usuario usuario = null ;
            foreach(TipoUsuario item in _listaUsuarios)
            {
                if(item.Legajo == legajo && item.TipoUsuarix == ETiposUsuarios.Profesor)
                {
                    usuario = item;
                }
            }
            return usuario;
        }

        public static Materia BuscaMateriaPorNombre(string nombre)
        {
            Materia auxMateria = null;
            foreach (Materia materia in _materias)
            {
                if (materia.Nombre_De_Materia == nombre)
                {
                    auxMateria = materia;
                }
            }

            return auxMateria;
        }

        public static bool BuscarUsuarioEnLista(string user)// Verifica si el legajo ya existe en la lista de uusarios
        {
            bool retorno = false;

            if (user is not null)
            {
                foreach (Usuario item in _listaUsuarios)
                {
                    if (item.NombreUsuario == user)
                    {                        
                        retorno = true;
                        break;
                    }
                }
            }
            return retorno;
        }

        public static bool BuscaAlumnoPorLegajo(long legajo)
        {
            bool retorno = false;

            if(legajo > 0)
            {
                foreach (TipoUsuario item in _listaUsuarios)
                {
                    if (item.Legajo == legajo && item.TipoUsuarix == ETiposUsuarios.Alumno)
                    {
                        retorno=true;
                        break;
                    }
                }

            }

            return retorno;
        }

        public static Materia BuscaMateriaEnLista(string materia,int cuatrimestre, List<Materia> lista)
        {
            bool retorno = false;
            Materia auxMateria = null;
            foreach (Materia item in lista)
            {
                if (item.Nombre_De_Materia == materia && item.Cuatrimestre == cuatrimestre)
                {
                    auxMateria = item;
                    break;
                }
            }
            return auxMateria;
        }

        public static NotasAlumno RetornaNotasAlumnoMateria(string materia, long legajoAlumno)
        {
            NotasAlumno auxNotas = null;

            foreach(NotasAlumno item in _notasAlumnos)
            {
                if(item == legajoAlumno && item == materia)
                {
                    auxNotas = item;
                    break;
                }
            }

            return auxNotas;
        }

        public static bool CambiaEstadoNotasAlumnoMateria(string materia, long legajoAlumno, EEstadoCursada estado)
        {
            bool retorno = false;

            foreach (NotasAlumno item in _notasAlumnos)
            {
                if (item.LegajoAlumno == legajoAlumno && item.Materia == materia)
                {
                    item.estadoCursada = estado;
                    retorno = true;
                    break;
                }
            }

            return retorno;
        }

        public static bool ValidaCorrelativaAprobada(Materia mat, long legajoAlumno)
        {
            bool retorno = false;
            foreach(NotasAlumno item in _notasAlumnos)
            {
                if(item.LegajoAlumno == legajoAlumno
                    && item.Materia == mat.Correlativa && item.EstadoMateria == EEstadoMateria.Aprobada || mat.Correlativa == "No tiene")
                {
                    retorno = true;
                    break;
                }
            }

            return retorno;
        }
    }
}
