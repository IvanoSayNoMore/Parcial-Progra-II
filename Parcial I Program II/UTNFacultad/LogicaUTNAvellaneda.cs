using Microsoft.VisualBasic.ApplicationServices;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UsuariosUTN.Clases;
using UsuariosUTN.Enums;
using UsuariosUTN.Generics;
using UsuariosUTN.Usuarios;

namespace UTNFacultad
{
    static class LogicaUTNAvellaneda
    {
        static List<Clase> _aulas;
        static List<Usuario> _listaUsuarios;
        static List<Materia> _materias;
        static List<Examen> _examenes;
        static List<DatosAlumno> _datosAlumnos;
        static List<Materia> _materiasDeAlumnos;
        static UsuariosGeneric<TipoUsuario> _usuariosGeneric;

        public static UsuariosGeneric<TipoUsuario> UsuariosGeneric { get => _usuariosGeneric; set => _usuariosGeneric = value; }

        static LogicaUTNAvellaneda()
        {
            _listaUsuarios = new List<Usuario>();
            _materias = new List<Materia>();
            _materiasDeAlumnos = new List<Materia>();
            _examenes = new List<Examen>();
            _datosAlumnos = new List<DatosAlumno>();
            _aulas = new List<Clase>();
            HardUsr();
           
        }

        public static void HardUsr()
        {
            _listaUsuarios = UsuarioDao.ListarTodosUsuarios();
            _usuariosGeneric = _listaUsuarios;// public static implicit operator UsuariosGeneric<T>(List<Usuario> v)

        }

        public static void HardCodeAulas()
        {
            try
            {
                _aulas = ClaseDao.ListarClasesMateriasDisponibles();
            }
            catch(Exception ex)
            {
                MessageBox.Show($"Error al cargar las materias{ex.Message}");
            }
            
        }

        public static void HardCode()
        {
            try
            {
                _materias = MateriasDao.ListaMaterias();//nombre y id

                _materiasDeAlumnos = MateriasDao.ListaMateriasDeAlumnos();

                _datosAlumnos = DatosAlumnoDao.ListarHistoriasAlumnos();

                _examenes = ExamenDao.ListaExamenes();
            }
            catch(Exception ex)
            {
                MessageBox.Show($"Error al cargar listas ");
            }

        }
        
        public static bool ValidaIngresoExamen(Examen examen,int idClassroom)
        {
            bool retorno = false;
            if(examen is not null && idClassroom >0)
            {
                foreach (DatosAlumno item in _datosAlumnos)
                {
                    if (item.LegajoAlumno == examen.IdAlumno
                        && item.IdMateria == examen.IdMatter
                        && item.EstadoMateria == 0
                        && item.IdClassroom == idClassroom)
                    {
                        foreach (Examen itemE in _examenes)
                        {
                            if (itemE.TipoParcial != examen.TipoParcial)
                            {
                                retorno = true;
                                break;
                            }
                        }
                        break;

                    }
                }
            }


            return retorno;

        }

        public static TipoUsuario logUsr(string nombre, string pass)
        {
            TipoUsuario usr = null;
            
            if(ValidarDosCampos(nombre, pass))
            {
                foreach (TipoUsuario usuario in _listaUsuarios)
                {
                    if (usuario.NombreUsuario == nombre && usuario.Contraseña == pass)
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

        public static Materia BuscaMateriaPorId(int id)
        {
            Materia materia = null;
            foreach (Materia item in _materias)
            {
                if (item.IdMateria == id)
                {
                    materia = item;
                    break;
                }
            }
            return materia;
        }

        public static bool ValidaCorrelativaAprobada(Materia mat, int legajoAlumno)
        {
            bool retorno = false;

            if(mat.Id_Correlativa == 0)
            {
                retorno=true;
            }
            else
            {
                foreach (DatosAlumno item in _datosAlumnos)
                {
                    if (item.LegajoAlumno == legajoAlumno
                        && item.IdMateria == mat.Id_Correlativa
                        && item.EstadoMateria == 1)
                    {
                        retorno = true;
                    }

                }
            }
            return retorno;
        }

        public static List<Clase> ListarClasesParaAlumno()
        {
            List<Clase> clases = new List<Clase>();

            if (_aulas != null)
            {
                foreach (Clase item in _aulas)
                {
                    clases.Add(new Clase(
                        item.IdMateria,
                        item.IdProfesor,
                        item.IdClassroom,
                        item.Classroom,
                        item.Materia,
                        item.Profesor,
                        item.Period));
                }
            }
            return clases;

        }

        public static List<Clase> ListarClasesDeProfesor(TipoUsuario usuario)
        {
            List<Clase> clases = new List<Clase>();

            if (_aulas != null)
            {
                foreach (Clase item in _aulas)
                {
                    if(item.IdProfesor == usuario.Legajo || (usuario.TipoUsuarix == ETiposUsuarios.Admin))
                    {
                        clases.Add(new Clase(
                                item.IdMateria,
                                item.IdProfesor,
                                item.IdClassroom,
                                item.Classroom,
                                item.Materia,
                                item.Profesor,
                                item.Period));
                    }

                }
            }
            return clases;

        }

        public static List<Examen> ListaExamenesDeUnAlumno(int id)
        {
            List<Examen> examenes = new List<Examen>();
            foreach(Examen item in _examenes)
            {
                if(item.IdEstudiante == id)
                {
                    examenes.Add(item);
                }
            }
            return examenes;
        }

        public static List<Materia> ListaMateriasDeUnAlumno(int idAlumno)
        {
            List<Materia> listaMateriasAlumno = new List<Materia>();

            foreach(Materia item in _materiasDeAlumnos)
            {
                if (item.IdAlumno == idAlumno)
                { 
                    
                    listaMateriasAlumno.Add(item);
                }
            }
            return listaMateriasAlumno;
        }

        public static bool BuscaSiAlumnoCursaMateria(int idAlumno,int idMateria)
        {
            bool retorno = false;
            foreach (Materia item in _materiasDeAlumnos)
            {
                if (item.IdMateria==idMateria && item.IdAlumno == idAlumno)
                {
                    retorno = true;
                    break;
                }
            }
            return retorno;
        }


        public static bool CrearMateria(string nombreMateria,
                                int mCarroletaiva)
        {
            bool retorno = true;
            Materia mat = new Materia(nombreMateria, mCarroletaiva);
            if (nombreMateria != null)
            {
                if(_materias.Contains(mat))
                {
                    retorno = false;
                }
                if(retorno)
                {
                    try
                    {
                        MateriasDao.Insert(new Materia(nombreMateria, mCarroletaiva));
                    }
                    catch
                    {
                        MessageBox.Show("Error en BD al cargar materias");
                    }
               
                }
            }
            return retorno;
        }


        public static bool AgregaExamenALista(Examen nuevoExamen)
        {
            bool retorno = false;
            if(nuevoExamen != null)
            {
                ExamenDao.Insert(nuevoExamen);
                retorno = true;
            }      

            return retorno;
        }

        public static bool AgregarUsuarioALista(TipoUsuario usr)
        {
            bool retorno = false;
            bool bandera = true;

            foreach(TipoUsuario item in _listaUsuarios)
            {
                if(item.NombreUsuario == usr.NombreUsuario && item.Apellido == usr.Apellido)
                {
                    bandera = false;
                }
            }
            if(bandera)
            {                
                retorno = UsuarioDao.Insert(usr);
            }
            return retorno;
        }
 

    }
}
