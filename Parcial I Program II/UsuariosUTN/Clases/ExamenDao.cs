
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UsuariosUTN.Usuarios;
using static Microsoft.EntityFrameworkCore.DbLoggerCategory.Database;

namespace UsuariosUTN.Clases
{
    public static class ExamenDao
    {
        private static string cadenaConexion;
        private static SqlCommand comando;
        private static SqlConnection conexion;

        static ExamenDao()
        {
            cadenaConexion = @"Data Source =.;
                                Database = UTNFacultad;
                                Trusted_Connection = True";
            comando = new SqlCommand();
            conexion = new SqlConnection(cadenaConexion);
            comando.Connection = conexion;
            comando.CommandType = System.Data.CommandType.Text;
        }

        public static List<Examen> ListaExamenes()
        {
            List<Examen> examenes = new List<Examen>();
            try
            {
                comando.Parameters.Clear();
                conexion.Open();
                comando.CommandText = $"SELECT " +        
                    $"a.ID as idEstudiante, " +
                    $"a.LASTNAME as Apellido," +
                    $"a.NAME as NombreEstudiante, " +
                    $"b.NAME_MATTER as Materia, " +
                    $"c.NAME as Cuatrimestre, " +
                    $"x.DATE_FECHA as Fecha, " +
                    $"x.NOTE as nota," +
                    $"x.ID_TYPE as TIPOP " +
                    $"FROM TESTS x " +
                    $"INNER JOIN STUDENT a " +
                    $"ON x.ID_STUDENT = a.ID " +
                    $"INNER JOIN MATTERS b " +
                    $"ON x.ID_MATTER = b.ID_MATTER " +
                    $"INNER JOIN PERIOD c " +
                    $"ON x.ID_PERIOD = c.ID " +
                    $"INNER JOIN TYPE_TEST d " +
                    $"ON X.ID_TYPE = d.ID";

                using (SqlDataReader getList = comando.ExecuteReader())
                {
                    while (getList.Read())
                    {
                        examenes.Add(new Examen(
                            Convert.ToInt32(getList["idEstudiante"]),
                            getList["Apellido"].ToString(),
                            getList["NombreEstudiante"].ToString(),
                            getList["Materia"].ToString(),
                            getList["Cuatrimestre"].ToString(),
                            Convert.ToDateTime(getList["Fecha"]),
                            Convert.ToDecimal(getList["nota"]),
                            Convert.ToInt32(getList["TIPOP"])
                            ));
                    }

                }
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


            return examenes;
        }

        public static bool Insert(Examen examen)
        {
            bool retorno = false;
            try
            {
                comando.Parameters.Clear();
                conexion.Open();
                comando.Parameters.AddWithValue("@idAlumno", examen.IdAlumno);
                comando.Parameters.AddWithValue("@fecha", examen.Fecha);
                comando.Parameters.AddWithValue("@idPeriodo", examen.IdPeriodo);
                comando.Parameters.AddWithValue("@nota", examen.Nota);
                comando.Parameters.AddWithValue("@idMatter", examen.IdMatter);
                comando.Parameters.AddWithValue("@idTipoParcial", examen.TipoParcial);
                comando.CommandText = "INSERT INTO TESTS(ID_STUDENT,DATE_FECHA,ID_PERIOD,NOTE,ID_MATTER,ID_TYPE)" +
                    "VALUES(@idAlumno, @fecha, @idPeriodo,@nota,@idMatter,@idTipoParcial)";

                comando.ExecuteNonQuery();
                retorno = true;
            }
            catch
            {
                throw new Exception("Error al dar de alta examen");
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
