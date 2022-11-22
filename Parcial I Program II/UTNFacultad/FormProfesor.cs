using Microsoft.IdentityModel.Tokens;
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


        TipoUsuario profesor;
        private static int _cuatrimestre = -1;
        EParcialesPromedio eParciales = EParcialesPromedio.vacio;        
        List<Materia> listaMaterias;
        List<Clase> listClases;

        public FormProfesor()
        {
            InitializeComponent();
            LogicaUTNAvellaneda.HardCode();
            LogicaUTNAvellaneda.HardCodeAulas();
 
        }


        private void FormProfesor_Load(object sender, EventArgs e)
        {
            StringBuilder sb = new StringBuilder();
            listClases = LogicaUTNAvellaneda.ListarClasesDeProfesor(setGetUsuario);
            if(listClases is not null)
            {
                sb.AppendLine("Materias Asignadas: ");
                foreach (Clase materia in listClases)
                {
                    sb.Append(materia.Classroom);
                    sb.AppendLine(materia.Materia);
                    
                }

                rtb_materiasAsignadas.Text = sb.ToString();
                rtb_materiasAsignadas.Visible = true;
            }
        }

        public TipoUsuario setGetUsuario
        {

            set { profesor = value; }
            get { return profesor; }
        }

        private void btn_salir_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btn_crearExamen_Click(object sender, EventArgs e)
        {
            CrearExamen crearExamen = new CrearExamen();
            crearExamen.setUsuario = setGetUsuario;
            crearExamen.Show();
        }

        private void btn_Concretar_Click(object sender, EventArgs e)
        {            
            //Examen auxExamen;
            //DatosAlumno auxNotasAllumno;
    
            //try
            //{
            //    auxExamen = new Examen(
            //        ((Usuario)cbAlumnos.SelectedItem).Legajo,
            //        Convert.ToDateTime(txt_fecha.Text),
            //        ((Periodos)cbPeriodo.SelectedItem).IdPeriodo,
            //        nm_Nota.Value,
            //        ((Clase)cbMaterias.SelectedItem).IdMateria,
            //        ((TiposParciales)cbTipoParcial.SelectedItem).Id);
                
            //    ExamenDao.Insert(auxExamen);

            //    MessageBox.Show($"Se dio de alta el examen para la materia {((Clase)cbMaterias.SelectedItem).Materia} " +
            //    $"Del  {StringTipoParcial(eParciales)} con fecha {txt_fecha.Text}");

            //    CambiaVistaMateriasAsignadas(false);

            //}
            //catch(Exception ex)
            //{
            //    MessageBox.Show($"Error. Faltan cargar datos");
            //}
            //finally
            //{

            //}         
            
        }
        
        //private string StringTipoParcial(EParcialesPromedio tipo)
        //{
        //    string parcialString;
        //    if (tipo == EParcialesPromedio.sParcial)
        //    {
        //        parcialString = "Segundo Parcial";
        //    }
        //    else
        //    {
        //        parcialString = "Primer Parcial";
        //    }

        //    return parcialString;
        //}

        //private void CambiaVistaMateriasAsignadas(bool condicion)
        //{
        //    MateriaComision.Visible = condicion;
        //    cbTipoParcial.Visible = condicion;  
        //    cbPeriodo.Visible = condicion;
        //    cbAlumnos.Visible = condicion;
        //    cbMaterias.Visible = condicion;
        //    LEGAJO.Visible = condicion;
        //    NOTA.Visible = condicion;
        //    rtb_materiasAsignadas.Visible = condicion;
        //    btn_Concretar.Visible = condicion;
        //    txt_fecha.Visible = condicion;
        //    cbAlumnos.Visible = condicion;
        //    nm_Nota.Visible = condicion;
        //    cbMaterias.Visible = condicion;
        //}


       
        //private void txt_fecha_Enter(object sender, EventArgs e)
        //{
        //    if (txt_fecha.Text == "FECHA")
        //    {
        //        txt_fecha.Text = "";
        //        txt_fecha.ForeColor = Color.Black;
        //    }
        //}
        //private void txt_fecha_Leave(object sender, EventArgs e)
        //{
        //    if (txt_fecha.Text == "")
        //    {
        //        txt_fecha.Text = "FECHA";
        //        txt_fecha.ForeColor = Color.DimGray;
        //    }
        //}

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
