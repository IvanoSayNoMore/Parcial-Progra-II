using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using UsuariosUTN.Clases;
using UsuariosUTN.Generics;
using UsuariosUTN.Usuarios;

namespace UTNFacultad
{
    public partial class AltaClase : Form
    {

        [DllImport("user32.dll", EntryPoint = "ReleaseCapture")]
        private extern static void ReleaseCapture();
        [DllImport("user32.dll", EntryPoint = "SendMessage")]
        private extern static void SendMessage(IntPtr hWnd, int Msg, int wParam, int lParam);

        UsuariosGeneric<TipoUsuario> _usuariosGeneric;

        private UsuariosGeneric<TipoUsuario> UsuariosGeneric
        {
            get => _usuariosGeneric; 
            set => _usuariosGeneric = value;
        }

        public AltaClase()
        {
            InitializeComponent();
            LogicaUTNAvellaneda.HardUsr();
            UsuariosGeneric = LogicaUTNAvellaneda.UsuariosGeneric;
        }

        private void AltaClase_Load(object sender, EventArgs e)
        {
            try
            {
                cbx_Profesores.DataSource = UsuariosGeneric.RetornaListaUsuarios(UsuariosUTN.Enums.ETiposUsuarios.Profesor);
                cb_Aulas.DataSource = ClassroomDao.ListarAulas();
                cb_Materias.DataSource = MateriasDao.ListaMaterias();
                cb_Periodos.DataSource = PeriodoDao.ListarPeriodos();
            }
            catch(Exception ex)
            {
                MessageBox.Show($"Ocurrio un error al cargar las listas{ex.Message} ");
            }


        }

        private void btn_Guardar_Click(object sender, EventArgs e)
        {
            try
            {
                ClaseDao.Insert(
                    ((Usuario)cbx_Profesores.SelectedItem).Legajo,
                    ((Classroom)cb_Aulas.SelectedItem).IdClassroom,
                    ((Periodos)cb_Periodos.SelectedItem).IdPeriodo,
                    ((Materia)cb_Materias.SelectedItem).IdMateria);
                MessageBox.Show($"Se ha dado de alta la clase ");
            }
            catch(Exception ex)
            {
                MessageBox.Show($"Error al guardar {ex.Message}");
            }
            finally
            {
                this.Close();
            }
        }

        private void btn_Cancelar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void AltaClase_MouseDown(object sender, MouseEventArgs e)
        {
            ReleaseCapture();
            SendMessage(this.Handle, 0x112, 0xf012, 0);
        }

        private void panel1_MouseDown(object sender, MouseEventArgs e)
        {
            ReleaseCapture();
            SendMessage(this.Handle, 0x112, 0xf012, 0);
        }


    }
}
