
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
    public static class UsuarioDao
    {
        private static string cadenaConexion;
        private static SqlCommand comando;
        private static SqlConnection conexion;

        static UsuarioDao()
        {
            cadenaConexion = @"Data Source =.;
                                Database = UTNFacultad;
                                Trusted_Connection = True";
            comando = new SqlCommand();
            conexion = new SqlConnection(cadenaConexion);
            comando.Connection = conexion;
            comando.CommandType = System.Data.CommandType.Text;

        }

        public static List<TipoUsuario> ListarUsuariosPorMateria(int idMateria)
        {

            List<TipoUsuario> list = new List<TipoUsuario>();

            try
            {
                comando.Parameters.Clear();
        
                conexion.Open();
                comando.Parameters.AddWithValue("@idMateria", idMateria);
                comando.CommandText = $"SELECT  b.ID, b.NAME,b.USERNAME, B.LASTNAME FROM DATE_GRADE x " +
                    $"INNER JOIN clase a " +
                    $"ON x.ID_CLASSROM = a.ID_CLASSROOM " +
                    $"INNER JOIN MATTERS c " +
                    $"ON a.ID_MATTER = c.ID_MATTER " +
                    $"INNER JOIN STUDENT b " +
                    $"ON X.ID_STUDENT = B.ID " +
                    $"WHERE a.ID_MATTER = @idMateria";


                using (SqlDataReader getList = comando.ExecuteReader())
                {
                    while (getList.Read())
                    {
                        list.Add(new TipoUsuario(
                            getList["NAME"].ToString(),
                            getList["LASTNAME"].ToString(),
                            getList["USERNAME"].ToString(),
                            Convert.ToInt32(getList["ID"])
                            ));
                    }

                }
            }
            catch (Exception e)
            {

            }
            finally
            {
                if (conexion.State == System.Data.ConnectionState.Open)
                {
                    conexion.Close();
                }
            }

            return list;
        }

        #region ABM
        public static void Modificar(TipoUsuario usr)
        {
            string tipo = TipoUsuario(usr.TipoUsuarix);
            try
            {
                comando.Parameters.Clear();
                conexion.Open();
                comando.Parameters.AddWithValue("@tipo", tipo);
                comando.Parameters.AddWithValue("@id", usr.Legajo);

                comando.CommandText = "UPDATE @tipo set" +
                    "NAME = @NOMBRE," +
                    "LASTNAME = @APELLIDO," +
                    "USERNAME = @USUARIO," +
                    "PASSWORD = @CONTRASEÑA ";

                comando.Parameters.AddWithValue("@NOMBRE", usr.Nombre);
                comando.Parameters.AddWithValue("@APELLIDO", usr.Apellido);
                comando.Parameters.AddWithValue("@USUARIO", usr.NombreUsuario);
                comando.Parameters.AddWithValue("@CONTRASEÑA", usr.Contraseña);

                comando.ExecuteNonQuery();
            }
            catch
            {

            }
            finally
            {
                if (conexion.State == System.Data.ConnectionState.Open)
                {
                    conexion.Close();
                }
            }
        }

        public static bool Insert(TipoUsuario usr)
        {
            bool retorno = false;
           
            try
            {
                string tipo = TipoUsuario(usr.TipoUsuarix);
                comando.Parameters.Clear();
                conexion.Open();
                comando.Parameters.AddWithValue("@tipo", tipo);
                comando.Parameters.AddWithValue("@NOMBRE", usr.Nombre);
                comando.Parameters.AddWithValue("@APELLIDO", usr.Apellido);
                comando.Parameters.AddWithValue("@USUARIO", usr.NombreUsuario);
                comando.Parameters.AddWithValue("@CONTRASEÑA", usr.Contraseña);

                comando.CommandText = "INSERT INTO @tipo(NAME, LASTNAME, USERNAME, PASSWORD)" +
                    "VALUES('@NOMBRE', '@APELLIDO', '@USUARIO', '@CONTRASEÑA')";

                comando.ExecuteNonQuery();
                retorno = true;
            }
            catch(Exception ex)
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
            return retorno;
        }

        private static string TipoUsuario(ETiposUsuarios tipoUsuario)
        {
            string tipo = null ;
            switch (tipoUsuario)
            {
                case ETiposUsuarios.Admin:
                    tipo = "ADMIN";
                    break;

                case ETiposUsuarios.Alumno:
                    tipo = "STUDENT";
                    break;

                case ETiposUsuarios.Profesor:
                    tipo = "TEACHERS";
                    break;
            }
            return tipo;
        }
        #endregion ABM

        public static List<Usuario> ListarTodosUsuarios()
        {
            List<Usuario> list = new List<Usuario>();

            try
            {
                comando.Parameters.Clear();
                conexion.Open();
                comando.CommandText = $"select * from teachers UNION select * from student UNION select * from admin " ;
            

                using (SqlDataReader getList = comando.ExecuteReader())
                {
                    while (getList.Read())
                    {

                        list.Add(new TipoUsuario(getList["NAME"].ToString(), getList["LASTNAME"].ToString(),
                                getList["USERNAME"].ToString(), getList["PASSWORD"].ToString(),
                                Convert.ToInt32(getList["ID"]),
                               Convert.ToInt32(getList["TIPE"]) ));

                    }

                }
            }
            catch(Exception e)
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

            return list;
        }




    }
}
