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
    public partial class FormProfesor : Form
    {
        [DllImport("user32.dll", EntryPoint = "ReleaseCapture")]
        private extern static void ReleaseCapture();
        [DllImport("user32.dll", EntryPoint = "SendMessage")]
        private extern static void SendMessage(IntPtr hWnd, int Msg, int wParam, int lParam);


        Usuario profesor;
        private static int _cuatrimestre = -1;
        EParcialesPromedio eParciales = EParcialesPromedio.vacio;
        
        List<Materia> listaMaterias;

        public FormProfesor()
        {
            InitializeComponent();
        }

        public Usuario setUsuario
        {
            set { profesor = value; }
        }

        private void btn_salir_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btn_crearExamen_Click(object sender, EventArgs e)
        {
            StringBuilder sb = new StringBuilder();

            listaMaterias = LogicaUTNAvellaneda.ListarMarteriasProfesor(profesor);
            if(listaMaterias is not null)
            {
                sb.AppendLine("Materias Asignadas: ");
                foreach (Materia materia in listaMaterias)
                {
                    sb.AppendLine(materia.Nombre_De_Materia);
                }
                CambiaVistaMateriasAsignadas(true);

               
                rtb_materiasAsignadas.Text = sb.ToString();
            }
        }

        private void btn_Concretar_Click(object sender, EventArgs e)
        {            
            Examen auxExamen;
            NotasAlumno auxNotasAllumno;   
           

            if (txb_materia.Text != "MATERIA" && eParciales != EParcialesPromedio.vacio && txt_fecha.Text != "FECHA"
                && _cuatrimestre != -1)
            {
                          
                if(LogicaUTNAvellaneda.BuscaMateriaEnLista(txb_materia.Text, _cuatrimestre,
                    LogicaUTNAvellaneda.ListarMarteriasProfesor(profesor) ) is not null)
                {
                    if (LogicaUTNAvellaneda.BuscaAlumnoPorLegajo((long)nm_legajoAlumno.Value))
                    {

                        auxExamen = new Examen(txt_fecha.Text, txb_materia.Text, profesor.Legajo,
                             (long)nm_legajoAlumno.Value, nm_Nota.Value, eParciales);

                        auxNotasAllumno = LogicaUTNAvellaneda.RetornaNotasAlumnoMateria(txb_materia.Text, (long)nm_legajoAlumno.Value);

                        if (auxNotasAllumno is not null)
                        {
                            if (auxNotasAllumno.AgregarNota(nm_Nota.Value, eParciales))
                            {
                                MessageBox.Show("Se agrego la nota parcial al alumno");
                            }
                            else
                            {
                                MessageBox.Show("El alumno ya tiene una nota para este parcial");
                            }
                        }
                        else
                        {
                            auxNotasAllumno = new NotasAlumno(txb_materia.Text, (long)nm_legajoAlumno.Value);
                            if (LogicaUTNAvellaneda.AgregaNotasAlumno(auxNotasAllumno))
                            {
                                MessageBox.Show("Se agrego la materia a la lista de examenes del alumno");
                            }
                        }

                        if (LogicaUTNAvellaneda.AgregaExamenALista(auxExamen))
                        {
                            MessageBox.Show("Se agrego el examen a la lista de examenes");
                        } 
                        
                        MessageBox.Show($"Se dio de alta el examen para la materia {txb_materia.Text} " +
                           $"Del  {StringTipoParcial(eParciales)} con fecha {txt_fecha.Text}");

                        CambiaVistaMateriasAsignadas(false);
                    }
                    else
                    {
                        MessageBox.Show("No se encontraron alumnos con el legajo ingresado");
                    }
                }
                else
                {
                    MessageBox.Show("Ingreso una materia inexistente o no asignada");
                }
               
            }
            else
            {
                MessageBox.Show($"Faltan cargar datos");
            }

            
        }
        
        private string StringTipoParcial(EParcialesPromedio tipo)
        {
            string parcialString;
            if (tipo == EParcialesPromedio.sParcial)
            {
                parcialString = "Segundo Parcial";
            }
            else
            {
                parcialString = "Primer Parcial";
            }

            return parcialString;
        }

        private void CambiaVistaMateriasAsignadas(bool condicion)
        {
            LEGAJO.Visible = condicion;
            NOTA.Visible = condicion;
            rtb_materiasAsignadas.Visible = condicion;
            btn_Concretar.Visible = condicion;
            rdb_pParcial.Visible = condicion;
            rdb_Sparcial.Visible = condicion;
            chk_PrimerCuatr.Visible = condicion;
            chk_SegundoCuatrimestre.Visible = condicion;
            txt_fecha.Visible = condicion;
            txb_materia.Visible = condicion;
            nm_Nota.Visible = condicion;
            nm_legajoAlumno.Visible = condicion;
        }
       
        private void rdb_pParcial_CheckedChanged(object sender, EventArgs e)
        {
            eParciales = EParcialesPromedio.pParcial;
        }

        private void rdb_Sparcial_CheckedChanged(object sender, EventArgs e)
        {
            eParciales = EParcialesPromedio.sParcial;
        }
       
        private void txt_fecha_Enter(object sender, EventArgs e)
        {
            if (txt_fecha.Text == "FECHA")
            {
                txt_fecha.Text = "";
                txt_fecha.ForeColor = Color.Black;
            }
        }
        private void txt_fecha_Leave(object sender, EventArgs e)
        {
            if (txt_fecha.Text == "")
            {
                txt_fecha.Text = "FECHA";
                txt_fecha.ForeColor = Color.DimGray;
            }
        }
        private void txb_materia_Enter(object sender, EventArgs e)
        {
            if (txb_materia.Text == "MATERIA")
            {
                txb_materia.Text = "";
                txb_materia.ForeColor = Color.Black;
            }
        }
        private void txb_materia_Leave(object sender, EventArgs e)
        {
            if (txb_materia.Text == "")
            {
                txb_materia.Text = "MATERIA";
                txb_materia.ForeColor = Color.DimGray;
            }
        }
        private void chk_PrimerCuatr_CheckedChanged(object sender, EventArgs e)
        {
            _cuatrimestre = 1;
            chk_SegundoCuatrimestre.Checked = false;

        }

        private void chk_SegundoCuatrimestre_CheckedChanged(object sender, EventArgs e)
        {

            _cuatrimestre = 2;
            chk_PrimerCuatr.Checked = false;
        }
        private void FormProfesor_MouseDown(object sender, MouseEventArgs e)
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
