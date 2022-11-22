
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
    public static class ClaseDao
    {
        private static string cadenaConexion;
        private static SqlCommand comando;
        private static SqlConnection conexion;

        static ClaseDao()
        {
            cadenaConexion = @"Data Source =.;
                                Database = UTNFacultad;
                                Trusted_Connection = True";
            comando = new SqlCommand();
            conexion = new SqlConnection(cadenaConexion);
            comando.Connection = conexion;
            comando.CommandType = System.Data.CommandType.Text;
        }

        public static bool Insert(int idProfesoir,int idAula,int idPeriodo,int idMateria)
        {
            bool retorno = false;
            try
            {
                comando.Parameters.Clear();
                conexion.Open();
                comando.Parameters.AddWithValue("@idProfesor", idProfesoir);
                comando.Parameters.AddWithValue("@idAula", idAula);
                comando.Parameters.AddWithValue("@idPeriodo", idPeriodo);
                comando.Parameters.AddWithValue("@idMateria", idMateria);
                comando.CommandText = $"INSERT INTO CLASE (ID_TEACHER,ID_CLASSROOM,ID_PERIOD,ID_MATTER,STATUS)" +
                    $"VALUES(@idProfesor,@idAula,@idPeriodo,@idMateria,1)";
                comando.ExecuteNonQuery();
                retorno = true;
                
            }
            catch(Exception ex)
            {
                throw new Exception("Error al dar de alta clase");
            }
            finally
            {
                if (conexion.State == System.Data.ConnectionState.Open)
                {
                    conexion.Close();
                }
                
            }
            return retorno = true;
        }

        public static List<Clase> ListarClasesMateriasDisponibles()
        {
            List<Clase> materias = new List<Clase>();
            try
            {
                comando.Parameters.Clear();
                conexion.Open();
                comando.CommandText = $"SELECT " +
                                            $"a.ID, " +
                                            $"d.ID_MATTER, " +
                                            $"b.ID_CLASSROOM, " +
                                            $"b.DESCRIPTION_GRAD," +
                                            $"d.NAME_MATTER, " +
                                            $"a.LASTNAME, " +
                                            $"c.NAME " +                           
                                            $"FROM CLASE x " +
                                            $"INNER JOIN TEACHERS a " +
                                            $"ON x.ID_TEACHER = a.ID " +
                                            $"INNER JOIN CLASSROOM b " +
                                            $"ON x.ID_CLASSROOM = b.ID_CLASSROOM " +
                                            $"INNER JOIN PERIOD c " +
                                            $"ON x.ID_PERIOD = c.ID " +
                                            $"INNER JOIN MATTERS d " +
                                            $"ON x.ID_MATTER = d.ID_MATTER  " +
                                            $"WHERE x.status = 1 ";

                using (SqlDataReader getList = comando.ExecuteReader())
                {
                    while (getList.Read())
                    {
                        materias.Add(new Clase(
                            Convert.ToInt32(getList["ID_MATTER"]),
                            Convert.ToInt32(getList["ID"]),
                            Convert.ToInt32(getList["ID_CLASSROOM"]),
                            getList["DESCRIPTION_GRAD"].ToString(),
                            getList["NAME_MATTER"].ToString(),
                            getList["LASTNAME"].ToString(),
                            getList["NAME"].ToString()                                    
                            ));
                    }
                }
            }
            catch (Exception e)
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

            return materias;

        }


    }
}
