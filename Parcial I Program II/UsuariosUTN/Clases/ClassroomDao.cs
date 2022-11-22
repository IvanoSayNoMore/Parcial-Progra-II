
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UsuariosUTN.Usuarios;

namespace UsuariosUTN.Clases
{
    public static class ClassroomDao
    {
        private static string cadenaConexion;
        private static SqlCommand comando;
        private static SqlConnection conexion;

        static ClassroomDao()
        {
            cadenaConexion = @"Data Source =.;
                                Database = UTNFacultad;
                                Trusted_Connection = True";
            comando = new SqlCommand();
            conexion = new SqlConnection(cadenaConexion);
            comando.Connection = conexion;
            comando.CommandType = System.Data.CommandType.Text;
        }

        public static bool Insert(string nombre)
        {
            bool retorno = false;
            try
            {
                comando.Parameters.Clear();
                conexion.Open();
                comando.Parameters.AddWithValue("@nombre", nombre);

                comando.CommandText = $"INSERT INTO CLASSROOM(DESCRIPTION_GRAD)" +
                    $"VALUES(@nombre)";
                comando.ExecuteNonQuery();
                retorno = true;

            }
            catch (Exception ex)
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
            return retorno = true;
        }


        public static List<Classroom> ListarAulas()
        {
            List<Classroom> aulas = new List<Classroom>();
            try
            {
                comando.Parameters.Clear();
                conexion.Open();
                comando.CommandText = $"SELECT * FROM CLASSROOM";

                using (SqlDataReader getList = comando.ExecuteReader())
                {
                    while (getList.Read())
                    {
                        aulas.Add(new Classroom(
                            Convert.ToInt32(getList["ID_CLASSROOM"]),
                            getList["DESCRIPTION_GRAD"].ToString()
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

            return aulas;

        }
    }
}
