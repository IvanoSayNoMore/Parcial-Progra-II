
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UsuariosUTN.Usuarios;

namespace UsuariosUTN.Clases
{
    public static class DatosAlumnoDao
    {
        private static string cadenaConexion;
        private static SqlCommand comando;
        private static SqlConnection conexion;

        static DatosAlumnoDao()
        {
            cadenaConexion = @"Data Source =.;
                                Database = UTNFacultad;
                                Trusted_Connection = True";
            comando = new SqlCommand();
            conexion = new SqlConnection(cadenaConexion);
            comando.Connection = conexion;
            comando.CommandType = System.Data.CommandType.Text;
           
            
        }

        public static bool InsertDate_Grade(int idAlumno,int idClassroom)
        {
            bool retorno = false;
            try
            {
                comando.Parameters.Clear();
                conexion.Open();
                comando.Parameters.AddWithValue("@idAlumno", idAlumno);
                comando.Parameters.AddWithValue("@idClassroom", idClassroom);
 
                comando.CommandText = $"INSERT INTO DATE_GRADE(ID_CLASROOM,ID_STUDENT,STATUS_ASSIST,ASSIST,STATUS_MATTER) " +
                    "VALUES(@idClassroom, @idAlumno,0,0,0)";

                comando.ExecuteNonQuery();
                retorno = true;
               
            }
            catch
            {
                throw new Exception("Error al dar de alta datos");
            }
            finally
            {
                if (conexion.State == System.Data.ConnectionState.Open)
                {
                    conexion.Close();
                }

            }
            return retorno;
        }

        public static List<DatosAlumno> ListarHistoriasAlumnos()
        {
            List<DatosAlumno> datosAlumnoList = new List<DatosAlumno>();
            try
            {
                comando.Parameters.Clear();
                conexion.Open();
                comando.CommandText = $"SELECT " +
                    $"x.ID_STUDENT as idEstudiante," +
                    $"b.ID_MATTER as idMateria ," +
                    $"x.status_matter as estadoMateria, " +
                    $"x.ID_CLASSROM as idClassroom " +
                    $"from DATE_GRADE x " +
                    $"INNER JOIN CLASSROOM a " +
                    $"ON a.ID_CLASSROOM = x.ID_CLASSROM " +
                    $"INNER JOIN CLASE b " +
                    $"ON a.ID_CLASSROOM = b.ID_CLASSROOM ";

                using (SqlDataReader getList = comando.ExecuteReader())
                {
                    while (getList.Read())
                    {
                        datosAlumnoList.Add(new DatosAlumno(
                            Convert.ToInt32(getList["idEstudiante"]),
                            Convert.ToInt32(getList["idMateria"]),
                            Convert.ToInt32(getList["estadoMateria"]),
                             Convert.ToInt32(getList["idClassroom"])));
                    }
                }
            }
            catch (Exception e)
            {
                throw new Exception("Error al listar historias de alumnos");
            }
            finally
            {
                if (conexion.State == System.Data.ConnectionState.Open)
                {
                    conexion.Close();
                }
            }
            return datosAlumnoList;
        }

        public static bool DarAsistencia(int idClassroom,int idAlumno)
        {
            bool retorno = false;
            try
            {
                comando.Parameters.Clear();
                conexion.Open();
                comando.Parameters.AddWithValue("@idAlumno", idAlumno);
                comando.Parameters.AddWithValue("@idClassroom", idClassroom);

                comando.CommandText = $"UPDATE DATE_GRADE set ASSIST = ASSIST+1" +
                    $" WHERE ID_STUDENT = @idAlumno and ID_CLASSROM = @idClassroom ";
                comando.ExecuteNonQuery();
                retorno = true;

            }
            catch
            {

                throw;
            }
            finally
            {
                if (conexion.State == System.Data.ConnectionState.Open)
                {
                    conexion.Close();
                }

            }
            return retorno;



        }
    }
}
