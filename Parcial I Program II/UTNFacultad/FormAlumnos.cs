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
using UsuariosUTN.Usuarios;

namespace UTNFacultad
{
    public partial class FormAlumnos : Form
    {
        [DllImport("user32.dll", EntryPoint = "ReleaseCapture")]
        private extern static void ReleaseCapture();
        [DllImport("user32.dll", EntryPoint = "SendMessage")]
        private extern static void SendMessage(IntPtr hWnd, int Msg, int wParam, int lParam);
       
        
        Usuario usuario;
        public FormAlumnos()
        {
             InitializeComponent();
        }

        public Usuario setUsuario
        {
            set { usuario = value; }
        }

        private void FormAlumnos_Load(object sender, EventArgs e)
        {
            tbx_NombreUsuario.Text = $"Bienvenido {usuario.Nombre}";
            lbl_usuario.Text = usuario.NombreUsuario;
        }

        private void btn_MostrarMateriasCursadas_Click(object sender, EventArgs e)
        {        
            List<Materia> materias;
            materias = LogicaUTNAvellaneda.ListarMarteriasAlumno(usuario.Legajo);
            StringBuilder sb = new StringBuilder();

            if (materias is not null)
            {
                sb.AppendLine("Estas inscripto a estas materias: ");
                sb.AppendLine("__________________________________");
                foreach (Materia materia in materias)
                {                            
                    sb.Append(materia.MostrarDatosDeMateria());
                }
                sb.AppendLine("Tus Notas: ");
                sb.AppendLine("__________________________________");
               // sb.AppendLine(LogicaUTNAvellaneda.MostrarExamenPorAlumno(usuario));
                
                sb.AppendLine(LogicaUTNAvellaneda.MostrarNotasPorAlumno(usuario));



                dtaGV_materias.Visible = false;
                dtaGV_asistencias.Visible = false;
                rch_datosMaterias.Visible = true;
                rch_datosMaterias.Text = sb.ToString();
            }
            
        }

        private void btn_salir_Click(object sender, EventArgs e)
        {

            this.Close();
            
        }

        private void btn_Inscripciones_Click(object sender, EventArgs e)
        {
            List<Materia> listaMaterias ;
            listaMaterias = LogicaUTNAvellaneda.ListaMaterias();
            if(listaMaterias is not null)
            {
                //BindingSource bS = new();
                rch_datosMaterias.Visible = false;
                dtaGV_asistencias.Visible = false;
                dtaGV_materias.Visible = true;
                dtaGV_materias.DataSource = listaMaterias;
                
            }
      
        }

        private void dtaGV_materias_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            string materia;
            Materia auxMateria;         
            if ((materia = dtaGV_materias.Rows[e.RowIndex].Cells[0].Value.ToString()) is not null)
            {
                auxMateria = LogicaUTNAvellaneda.BuscaMateriaPorNombre(materia);
                if (auxMateria is not null)
                {
                    if (auxMateria + usuario.Legajo)
                    {
                        MessageBox.Show($"Se ha inscripto a la materia {auxMateria.Nombre_De_Materia} ");
                        dtaGV_materias.Visible = false;
                    }
                    else
                    {
                        MessageBox.Show("Ya esta inscripto a la materia seleccionada");
                        dtaGV_materias.Visible = false;
                    }
                }
               
            }

        }

        private void btn_Asistencia_Click(object sender, EventArgs e)
        {
           
            List<Materia> listaMaterias;
            listaMaterias = LogicaUTNAvellaneda.ListarMarteriasAlumno(usuario.Legajo);
            if(listaMaterias is not null)
            {
                BindingSource bS = new();
                rch_datosMaterias.Visible = false;
                dtaGV_materias.Visible = false;
                dtaGV_asistencias.Visible = true;
                dtaGV_asistencias.DataSource = listaMaterias;
            }

        }

        private void dtaGV_asistencias_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            string materia;
            Materia auxMateria;
            dtaGV_asistencias.AllowUserToAddRows = false;
            dtaGV_asistencias.AllowUserToDeleteRows = false;
            dtaGV_asistencias.ReadOnly = true;
            if ((materia = dtaGV_asistencias.Rows[e.RowIndex].Cells[0].Value.ToString()) is not null)
            {
                auxMateria = LogicaUTNAvellaneda.BuscaMateriaPorNombre(materia);
                if (auxMateria != null)
                {
                    if(Materia.DarAsistencia(auxMateria, usuario.Legajo))
                    {
                        MessageBox.Show($"Se ha dado la asistencia {auxMateria.Nombre_De_Materia} ");
                       dtaGV_asistencias.Visible = false;
                    }
                }

            }
        }

        private void FormAlumnos_MouseDown(object sender, MouseEventArgs e)
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
