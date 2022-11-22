using ServiceStack.Text;
using System;
using System.Runtime.Serialization;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Text.Json;
using System.Threading.Tasks;
using JsonSerializer = System.Text.Json.JsonSerializer;
using UsuariosUTN.Clases;
using System.Reflection;
using LINQtoCSV;
using UsuariosUTN.Usuarios;
using ServiceStack;

namespace UsuariosUTN.Serializadores
{
    public class ClaseSerializadora<T>   
    {
        static string ruta;
        static ClaseSerializadora()//ATENCION AL STATIC
        {
            ruta = Environment.GetFolderPath(Environment.SpecialFolder.Desktop);
            ruta += @"\Archivos_SerializadorJson";
        }
        #region Escribir
        public static void EscribirCSV(T datos, string archivo)
        {
            string rutaCompleta = ruta + @"\SerializadorCsv" + archivo + ".csv ";
      
            //try
            //{
            //    if (!Directory.Exists(ruta))
            //    {
            //        Directory.CreateDirectory(ruta);
            //    }
            //    StreamWriter sw = new StreamWriter(rutaCompleta);
            //    foreach (var item in datos)
            //    {
            //        sw.WriteLine(item);
            //    }

            //    File.WriteAllText(rutaCompleta, sw.ToString());
            //}
            //catch (Exception)
            //{
            //    throw;
            //}
        }

        public static void Escribir(T datos, string archivo)
        {
            string rutaCompleta = ruta + @"\SerializadorJson" + archivo + ".json ";

            try
            {
                if (!Directory.Exists(ruta))
                {
                    Directory.CreateDirectory(ruta);
                }

                string objJason = JsonSerializer.Serialize(datos);

                File.WriteAllText(rutaCompleta, objJason);

            }
            catch (Exception)
            {
                throw;
            }
        }

        #endregion Escribir

        #region Leer 

        public static T Leer(string nombreReferencia)//string rutaCompleta
        {
            string archivo = string.Empty;
            T date = default;
            bool ok = false;
            try
            {
                if (Directory.Exists(ruta))
                {
                    string[] archivosDeDirectorio = Directory.GetFiles(ruta);

                    foreach (string item in archivosDeDirectorio)
                    {
                        if (item.Contains(nombreReferencia))
                        {
                            archivo = item;
                            ok = true;
                            break;
                        }
                    }

                    if (ok == true)
                    {
                        string archivoJson = File.ReadAllText(archivo);
                        date = JsonSerializer.Deserialize<T>(archivoJson);

                    }
                    else
                    {
                        Console.WriteLine("No hay coincidencias");
                    }


                }

            }
            catch (Exception)
            {
                throw;
            }
            return date;
        }


        #endregion


    }
}
