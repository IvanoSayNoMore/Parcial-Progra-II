using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
namespace UsuariosUTN.Clases
{
    public static class TiposParcialesDao
    {
        private static string cadenaConexion;
        private static SqlCommand comando;
        private static SqlConnection conexion;

        static TiposParcialesDao()
        {
            cadenaConexion = @"Data Source =.;
                                Database = UTNFacultad;
                                Trusted_Connection = True";
            comando = new SqlCommand();
            conexion = new SqlConnection(cadenaConexion);
            comando.Connection = conexion;
            comando.CommandType = System.Data.CommandType.Text;
        }

        public static List<TiposParciales> ListarTipos()
        {
            List<TiposParciales> tiposParciales = new List<TiposParciales>();
            try
            {
                comando.Parameters.Clear();
                conexion.Open();
                comando.CommandText = $"SELECT * FROM TYPE_TEST";

                using (SqlDataReader getList = comando.ExecuteReader())
                {
                    while (getList.Read())
                    {
                        tiposParciales.Add(new TiposParciales(
                            Convert.ToInt32(getList["ID"]),
                            getList["NAME"].ToString() ));
                    }

                }
            }
            catch
            {
                throw new Exception("Error al dar de alta");

            }
            finally
            {
                if (conexion.State == System.Data.ConnectionState.Open)
                {
                    conexion.Close();
                }
            }


            return tiposParciales;
        }

    }
}
