using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using UsuariosUTN.Usuarios;

namespace UsuariosUTN.Clases
{
    public static class PeriodoDao
    {
        private static string cadenaConexion;
        private static SqlCommand comando;
        private static SqlConnection conexion;

        static PeriodoDao()
        {
            cadenaConexion = @"Data Source =.;
                                Database = UTNFacultad;
                                Trusted_Connection = True";
            comando = new SqlCommand();
            conexion = new SqlConnection(cadenaConexion);
            comando.Connection = conexion;
            comando.CommandType = System.Data.CommandType.Text;
        }

        public static bool Insert(Periodos periodo)
        {
            bool retorno = false;
            try
            {
                comando.Parameters.Clear();
                conexion.Open();
                comando.Parameters.AddWithValue("@name", periodo.Nombre);
                comando.Parameters.AddWithValue("@InicioPeriodo",periodo.Inicio);
                comando.Parameters.AddWithValue("@FinPeriodo", periodo.Fin);
                comando.CommandText = "INSERT INTO PERIOD(NAME,DATA_INZ,DATE_END) " +
                    "VALUES(@name,@InicioPeriodo,@FinPeriodo)";
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

        public static List<Periodos> ListarPeriodos()
        {
            List<Periodos> periodo = new List<Periodos>();
            try
            {
                comando.Parameters.Clear();
                conexion.Open();
                comando.CommandText = $"SELECT * FROM PERIOD";

                using (SqlDataReader getList = comando.ExecuteReader())
                {
                    while (getList.Read())
                    {
                        periodo.Add(new Periodos(
                            Convert.ToInt32(getList["ID"]), 
                            getList["NAME"].ToString(),
                            Convert.ToDateTime(getList["DATA_INZ"]),
                            Convert.ToDateTime(getList["DATE_END"]) ));                        
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


            return periodo;
        }
    }
}
