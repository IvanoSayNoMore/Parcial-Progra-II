
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UsuariosUTN.Enums;
using UsuariosUTN.Usuarios;
using static Microsoft.EntityFrameworkCore.DbLoggerCategory.Database;

namespace UsuariosUTN.Clases
{
    public static class MateriasDao
    {
        private static string cadenaConexion;
        private static SqlCommand comando;
        private static SqlConnection conexion;

        static MateriasDao()
        {
            cadenaConexion = @"Data Source =.;
                                Database = UTNFacultad;
                                Trusted_Connection = True";
            comando = new SqlCommand();
            conexion = new SqlConnection(cadenaConexion);
            comando.Connection = conexion;
            comando.CommandType = System.Data.CommandType.Text;
        }

        public static bool Insert(Materia materia)
        {
            bool retorno = false;
            try
            {
                comando.Parameters.Clear();
                conexion.Open();
                comando.Parameters.AddWithValue("@NAME", materia.Materia_);               
                comando.Parameters.AddWithValue("@CORRELATIVA", materia.Id_Correlativa);
                comando.CommandText = "INSERT INTO MATTERS(NAME_MATTER,ID_CORRELATIVE) " +
                    "VALUES(@id, @NAME, @CORRELATIVA)";

                comando.ExecuteNonQuery();
                retorno = true;
            }
            catch
            {
                throw new Exception("Error al dar de alta Materia");
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

        public static List<Materia> ListaMaterias()
        {
            List<Materia> materias = new List<Materia>();
            try
            {
                comando.Parameters.Clear();
                conexion.Open();
                comando.CommandText = $"SELECT * FROM MATTERS ";         

                using (SqlDataReader getList = comando.ExecuteReader())
                {
                    while (getList.Read())
                    {
                        materias.Add(new Materia(Convert.ToInt32(getList["ID_MATTER"]), 
                        getList["NAME_MATTER"].ToString(),
                        Convert.ToInt32(getList["ID_CORRELATIVE"]) ));
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

        public static List<Materia> ListaMateriasDeAlumnos()
        {
            List<Materia> materias = new List<Materia>();
            try
            {
                comando.Parameters.Clear();
                conexion.Open();
                comando.CommandText = $"SELECT x.ID_STUDENT,x.ID_CLASSROM,b.NAME_MATTER " +
                    $"FROM DATE_GRADE x " +
                    $"INNER JOIN CLASE a " +
                    $"ON a.ID_CLASSROOM = x.ID_CLASSROM " +
                    $"INNER JOIN MATTERS b " +
                    $"ON b.ID_MATTER = a.id_matter " +
                    $"INNER JOIN STUDENT c " +
                    $"ON x.ID_STUDENT = c.ID " +
                    $"WHERE a.STATUS = 1";

                using (SqlDataReader getList = comando.ExecuteReader())
                {
                    while (getList.Read())
                    {
                        materias.Add(new Materia(
                            Convert.ToInt32(getList["ID_CLASSROM"]),
                            Convert.ToInt32(getList["ID_STUDENT"]),
                            getList["NAME_MATTER"].ToString()));
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
