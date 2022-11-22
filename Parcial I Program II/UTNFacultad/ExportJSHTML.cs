using ServiceStack;
using ServiceStack.Text;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using UsuariosUTN.Clases;
using UsuariosUTN.Serializadores;
using UsuariosUTN.Usuarios;

namespace UTNFacultad
{
    public partial class ExportJSHTML : Form
    {

        List<TipoUsuario> list = new List<TipoUsuario>();

        public ExportJSHTML()
        {
            InitializeComponent();
          
        }

        private void ExportJSHTML_Load(object sender, EventArgs e)
        {
            try
            {
                cb_Materias.DataSource = MateriasDao.ListaMaterias();
                list = UsuarioDao.ListarUsuariosPorMateria(((Materia)cb_Materias.SelectedItem).IdMateria);
            }
            catch
            {
                MessageBox.Show("Error al cargar listas");
            }
        }

        private void btn_cancelar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btn_concretar_Click(object sender, EventArgs e)
        {

            if(rdb_csv.Checked)
            {
                try
                {
                    if (((Materia)cb_Materias.SelectedItem).IdMateria == 0)
                    {
                        MessageBox.Show("Debe seleccionar materia ");
                    }
                    else
                    {
                        ClaseSerializadora<List<TipoUsuario>>.EscribirCSV(list, $"Lista de alumnos de la materia" +
                            $" {((Materia)cb_Materias.SelectedItem).Materia_}");

                        MessageBox.Show("Se ha serializado correctamente ");

                    }
                }
                catch 
                {
                }

               // list = UsuarioDao.ListarUsuariosPorMateria(((Materia)cb_Materias.SelectedItem).IdMateria);
            }
            if (rdb_json.Checked)
            {
                try
                {
                   // list = UsuarioDao.ListarUsuariosPorMateria(((Materia)cb_Materias.SelectedItem).IdMateria);

                    if (((Materia)cb_Materias.SelectedItem).IdMateria == 0)
                    {
                        MessageBox.Show("Debe seleccionar materia ");
                    }
                    else
                    {
                        ClaseSerializadora<List<TipoUsuario>>.Escribir(list, $"Lista de alumnos de la materia" +
                            $" {((Materia)cb_Materias.SelectedItem).Materia_}");

                        MessageBox.Show("Se ha serializado correctamente ");

                    }

                }
                catch (Exception ex)
                {
                    MessageBox.Show("Ocurrio un error al serializar.");
                }
            }
            else
            {
                MessageBox.Show("Debe seleccionar un tipo a convertir");
            }
            



        }
    }
}
