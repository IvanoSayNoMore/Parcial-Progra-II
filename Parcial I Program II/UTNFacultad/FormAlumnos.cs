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
using UsuariosUTN.Usuarios;

namespace UTNFacultad
{
    public partial class FormAlumnos : Form
    {
        [DllImport("user32.dll", EntryPoint = "ReleaseCapture")]
        private extern static void ReleaseCapture();
        [DllImport("user32.dll", EntryPoint = "SendMessage")]
        private extern static void SendMessage(IntPtr hWnd, int Msg, int wParam, int lParam);

        private static int _idClassroom;
        Usuario usuario;
        List<Clase> clasesDisponibles;
        List<Materia> materias;
        List<Examen> examenes;
        List<Materia> listaMaterias;

        public FormAlumnos()
        {
            InitializeComponent();
            LogicaUTNAvellaneda.HardCode();
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
            //  examenes = ExamenDao.ListaExamenes(usuario.Legajo);// para cambiar
            examenes = LogicaUTNAvellaneda.ListaExamenesDeUnAlumno(usuario.Legajo);
            materias = LogicaUTNAvellaneda.ListaMateriasDeUnAlumno(usuario.Legajo);

            StringBuilder sb = new StringBuilder();

            if (materias is not null)
            {
                sb.AppendLine("Estas inscripto a estas materias: ");
                sb.AppendLine("__________________________________");
                foreach (Materia materia in materias)
                {                            
                    sb.Append(materia.ToString());
                }
       
            }
            if(examenes is not null)
            {
                sb.AppendLine("Tus Notas: ");
                sb.AppendLine("__________________________________");
                foreach (Examen examen in examenes)
                {
                    sb = sb.Append(examen.ToString());
                }
                dtaGV_materias.Visible = false;
                dtaGV_asistencias.Visible = false;
                
               
            }
            rch_datosMaterias.Text = sb.ToString();
            rch_datosMaterias.Visible = true;

        }

        private void btn_salir_Click(object sender, EventArgs e)
        {

            this.Close();
            
        }

        private void btn_Inscripciones_Click(object sender, EventArgs e)
        {
            clasesDisponibles = LogicaUTNAvellaneda.ListarClasesParaAlumno();

            if (clasesDisponibles is not null)
            {                   
                rch_datosMaterias.Visible = false;
                dtaGV_asistencias.Visible = false;
                dtaGV_materias.Visible = true;
      
                dtaGV_materias.DataSource = clasesDisponibles;
                dtaGV_materias.Columns["IdClassroom"].Visible = false;
                dtaGV_materias.Columns["IdMateria"].Visible = false;
                dtaGV_materias.Columns["IdProfesor"].Visible = false;
                dtaGV_materias.Columns["EstadoMateria"].Visible = false;
                dtaGV_materias.BackgroundColor = Color.Black;
                dtaGV_materias.ForeColor = Color.Black;
            }
      
        }

        private void dtaGV_materias_CellClick(object sender, DataGridViewCellEventArgs e)
        {
             
            int _idMateria;
            int _idClassroom;         
            Materia auxMateria;

            _idMateria = Convert.ToInt32(dtaGV_materias.Rows[e.RowIndex].Cells[5].Value);
            _idClassroom = Convert.ToInt32(dtaGV_materias.Rows[e.RowIndex].Cells[0].Value);            
                
            auxMateria = LogicaUTNAvellaneda.BuscaMateriaPorId(_idMateria);

            if(LogicaUTNAvellaneda.BuscaSiAlumnoCursaMateria(usuario.Legajo,_idMateria))
            {
                if (LogicaUTNAvellaneda.ValidaCorrelativaAprobada(auxMateria, usuario.Legajo))
                {
                    try
                    {
                        if (DatosAlumnoDao.InsertDate_Grade(usuario.Legajo, _idClassroom))
                        {
                            MessageBox.Show($"Se ha inscripto a la materia {auxMateria.Materia_} ");
                            dtaGV_materias.Visible = false;
                        }
                        else
                        {

                            MessageBox.Show("Ya esta inscripto a la materia seleccionada");
                            dtaGV_materias.Visible = false;
                        }
                    }
                    catch(Exception ex)
                    {
                        MessageBox.Show($"Se ha producido un error en la base de datos {ex.Message}");
                    }


                }
                else
                {
                    MessageBox.Show("No tiene aprobada la materia correlativa");
                    dtaGV_materias.Visible = false;

                }
            }
            else
            {
                MessageBox.Show("Usted ya esta inscripto en esta materia");
            }                
            

        }

        private void btn_Asistencia_Click(object sender, EventArgs e)
        {     
          
            listaMaterias = LogicaUTNAvellaneda.ListaMateriasDeUnAlumno(usuario.Legajo);
            if(listaMaterias is not null)
            {
                BindingSource bS = new();
                rch_datosMaterias.Visible = false;
                dtaGV_materias.Visible = false;
                dtaGV_asistencias.Visible = true;
                dtaGV_asistencias.DataSource = listaMaterias;
                dtaGV_asistencias.Columns["IdClassroom"].Visible = false;
                dtaGV_asistencias.Columns["IdMateria"].Visible = false;
                dtaGV_asistencias.Columns["IdAlumno"].Visible = false;
                dtaGV_asistencias.Columns["Id_Correlativa"].Visible = true;
            }

        }

        private void dtaGV_asistencias_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int idClassRoom;
            Materia auxMateria;

            dtaGV_asistencias.AllowUserToAddRows = false;
            dtaGV_asistencias.AllowUserToDeleteRows = false;
            dtaGV_asistencias.ReadOnly = true;

            idClassRoom = Convert.ToInt32(dtaGV_asistencias.Rows[e.RowIndex].Cells[3].Value);
            try
            {
                if (DatosAlumnoDao.DarAsistencia(idClassRoom, usuario.Legajo))
                {
                    MessageBox.Show($"Se ha dado la asistencia ");
                    dtaGV_asistencias.Visible = false;
                }
            }
            catch(Exception ex)
            {
                MessageBox.Show($"Error al dar asistencia");
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

        private void tbx_NombreUsuario_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
