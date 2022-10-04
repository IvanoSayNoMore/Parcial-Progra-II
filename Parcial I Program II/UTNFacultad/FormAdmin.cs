using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.InteropServices;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using UsuariosUTN.Enums;
using UsuariosUTN.Usuarios;


namespace UTNFacultad
{
    public partial class FormAdmin : Form
    {
        private static ETiposUsuarios tipoUsuario = ETiposUsuarios.vacio;
        private static int cuatrimestre = -1;
        private static EEstadoCursada estadoCursada = EEstadoCursada.vacio;
        private static  int legajo = 1007;
        private static Materia materia;

        [DllImport("user32.dll", EntryPoint = "ReleaseCapture")]
        private extern static void ReleaseCapture();
        [DllImport("user32.dll", EntryPoint = "SendMessage")]
        private extern static void SendMessage(IntPtr hWnd, int Msg, int wParam, int lParam);

        public FormAdmin()
        {
            InitializeComponent();
        }
        
        private void FormAdmin_Load(object sender, EventArgs e)
        {

        }

        private int GeneraLegajo()
        {
            return legajo++;
        }

        private void btn_AltaUsuario_Click(object sender, EventArgs e)
        {
            OpcionesAltaMateria(false);
            OpcionesCambioEstadoAlumno(false);
            OpcionesAsignarMateria(false);
            OpcionesAltaUsuario(true);
        }

        private void btn_AltaMateria_Click(object sender, EventArgs e)
        {
            OpcionesAltaUsuario(false);
            OpcionesAsignarMateria(false);
            OpcionesCambioEstadoAlumno(false);
            OpcionesAltaMateria(true);
        }

        private void btn_AsignarMateria_Click(object sender, EventArgs e)
        {
            OpcionesAltaMateria(false);
            OpcionesAltaUsuario(false);
            OpcionesCambioEstadoAlumno(false);
            OpcionesAsignarMateria(true);
            List<Materia> materias ;
            List<Usuario> Profesores;

            materias = LogicaUTNAvellaneda.ListaMateriasSinProfesor();
            Profesores = LogicaUTNAvellaneda.ListarProfesores();

            StringBuilder muestraMaterias = new StringBuilder();
            StringBuilder muestraProfesores = new StringBuilder();
           
            foreach (Materia item in materias)
            {
                muestraMaterias.AppendLine(item.MostrarDatosDeMateria());
            }
            foreach(Usuario item in Profesores)
            {
                muestraProfesores.AppendLine(item.MostrarDatosUsr());
            }
            rch_MateriasSinProfesor.Text = muestraMaterias.ToString();
            rch_ListaProfesores.Text = muestraProfesores.ToString();

        }

        private void btn_cambioEstadoAlumno_Click(object sender, EventArgs e)
        {
            OpcionesAltaMateria(false);
            OpcionesAltaUsuario(false);
            OpcionesAsignarMateria(false);
            OpcionesCambioEstadoAlumno(true);
        }

        private void btn_ConcretarUsr_Click(object sender, EventArgs e)
        {
            int nuevoLegajo;
            if(txb_Apellido.Text != "APELLIDO" && txb_Usuario.Text != "USUARIO"
                && txb_nombreRealUsr.Text != "NOMBRE" && txb_Contraseña.Text != "CONTRASEÑA"
                && tipoUsuario != ETiposUsuarios.vacio)
            {
                if(!LogicaUTNAvellaneda.BuscarUsuarioEnLista(txb_nombreRealUsr.Text))
                {
                    nuevoLegajo = GeneraLegajo();
                    Usuario usr = new TipoUsuario(txb_nombreRealUsr.Text, txb_Apellido.Text,
                        txb_Usuario.Text, txb_Contraseña.Text, nuevoLegajo, tipoUsuario);
                    LogicaUTNAvellaneda.AgregarUsuarioALista(usr);
                    MessageBox.Show($"OK legajo {nuevoLegajo} ");
                    OpcionesAltaUsuario(false);

                }
                else
                {
                    MessageBox.Show("Ya existe ese usuario ");
                    OpcionesAltaUsuario(false);
                }
            }
            else 
            {
                MessageBox.Show("Faltan cargar datos ");
                OpcionesAltaUsuario(false);
            }
        }

        private void btn_ConcretarNuevaMateria_Click(object sender, EventArgs e)
        {

            if(txb_NombreMateria.Text != "MATERIA" && txb_correlativa.Text != "CORRELATIVA"
                && cuatrimestre != -1)
            {
               if( LogicaUTNAvellaneda.CrearMateria(txb_NombreMateria.Text, cuatrimestre, txb_correlativa.Text))
               {
                    MessageBox.Show("Materia creada con exito ");
                    OpcionesAltaMateria(false);
               }
               else 
               {
                    MessageBox.Show("Ya existe una materia con ese nombre");
               }
                
            }
            else
            {
                MessageBox.Show("Faltan cargar datos");
            }
            
        }

        private void btn_ConcretarAsignarMateria_Click(object sender, EventArgs e)
        {
            List<Materia> listaMaterias = new List<Materia>();
            Usuario profesor;
            Materia materiaAsignar;
            if (txb_NombreMateria.Text != "MATERIA" && cuatrimestre != -1 && nm_legajoProfesor is not null)
            {
                listaMaterias = LogicaUTNAvellaneda.ListaMateriasSinProfesor();
                if(listaMaterias!= null)
                {
                    materiaAsignar = LogicaUTNAvellaneda.BuscaMateriaEnLista(txb_NombreMateria.Text
                        , cuatrimestre, listaMaterias);

                    if (materiaAsignar is not null)
                    {
                        profesor = LogicaUTNAvellaneda.BuscaProfesorPorLegajo((long)nm_legajoProfesor.Value);
                        if(profesor is not null)
                        {
                            if(materiaAsignar+profesor)
                            {
                                MessageBox.Show("Se asigno con exito");
                                OpcionesAsignarMateria(false);
                            }
                        }
                        else
                        {
                            MessageBox.Show("Legajo incorrecto");
                        }

                    }
                    else
                    {
                        MessageBox.Show("No se encontro la materia seleccionada. ");
                    }
                }
            }
            else
            {
                MessageBox.Show("Faltan cargar datos");
            }
        }

        private void btn_CambiarEstado_Click(object sender, EventArgs e)
        {
            if(txb_NombreMateria.Text != "MATERIA" && estadoCursada != EEstadoCursada.vacio)
            {
                if(LogicaUTNAvellaneda.CambiaEstadoNotasAlumnoMateria(txb_NombreMateria.Text,
                    (long)nm_legajoProfesor.Value, estadoCursada))
                {
                    MessageBox.Show("Se ha cambiado el estado correctamente");
                }
                else
                {
                    MessageBox.Show("Ocurrio un error al cambiar el estado");
                    OpcionesCambioEstadoAlumno(false);
                }
            }
        }


        private void OpcionesCambioEstadoAlumno(bool condicion)
        {
            rdb_Regular.Visible = condicion;
            rdb_Libre.Visible = condicion;
            txb_NombreMateria.Visible = condicion;
            lbl_legajo.Visible = condicion;
            nm_legajoProfesor.Visible = condicion;
            btn_CambiarEstado.Visible = condicion;
        }

        private void OpcionesAsignarMateria(bool condicion)
        {
            rch_MateriasSinProfesor.Visible = condicion;
            rch_ListaProfesores.Visible = condicion;
            btn_ConcretarAsignarMateria.Visible = condicion;
            txb_NombreMateria.Visible = condicion;
            lbl_Profesores.Visible = condicion;
            lbl_TituloMaterias.Visible = condicion;
            nm_legajoProfesor.Visible = condicion;
            lbl_legajo.Visible = condicion;
            rdb_SegundoCuatri.Visible = condicion;
            rdb_PrimerCuatri.Visible = condicion;
        }

        private void OpcionesAltaUsuario(bool condicion)
        {
            txb_Apellido.Visible = condicion;
            txb_Contraseña.Visible = condicion;
            txb_nombreRealUsr.Visible = condicion;
            txb_Usuario.Visible = condicion;
            rdb_Admin.Visible = condicion;
            rdb_Alumno.Visible = condicion;
            rdb_profesor.Visible = condicion;
            btn_ConcretarUsr.Visible = condicion;
        }

        private void OpcionesAltaMateria(bool condicion)
        {
            txb_correlativa.Visible= condicion;
            txb_NombreMateria.Visible = condicion;
            rdb_PrimerCuatri.Visible= condicion;
            rdb_SegundoCuatri.Visible = condicion;
            btn_ConcretarNuevaMateria.Visible = condicion;
        }
       
        private void TITULO_Click(object sender, EventArgs e)
        {

        }

        private void rdb_Libre_CheckedChanged(object sender, EventArgs e)
        {
            estadoCursada = EEstadoCursada.Libre;
        }

        private void rdb_Regular_CheckedChanged(object sender, EventArgs e)
        {
            estadoCursada = EEstadoCursada.Regular;
        }

        private void rdb_Alumno_CheckedChanged(object sender, EventArgs e)
        {
            tipoUsuario = ETiposUsuarios.Alumno;
        }

        private void rdb_profesor_CheckedChanged(object sender, EventArgs e)
        {
            tipoUsuario = ETiposUsuarios.Profesor;
        }

        private void rdb_Admin_CheckedChanged(object sender, EventArgs e)
        {
            tipoUsuario = ETiposUsuarios.Admin;
        }

        private void rdb_PrimerCuatri_CheckedChanged(object sender, EventArgs e)
        {
            cuatrimestre = 1;
        }

        private void rdb_SegundoCuatri_CheckedChanged(object sender, EventArgs e)
        {
            cuatrimestre = 2;
        }

        private void btn_Salir_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void txb_nombreRealUsr_Leave(object sender, EventArgs e)
        {
            if (txb_nombreRealUsr.Text == "")
            {
                txb_nombreRealUsr.Text = "NOMBRE";
                txb_nombreRealUsr.ForeColor = Color.DimGray;
                
            }
        }

        private void txb_nombreRealUsr_Enter(object sender, EventArgs e)
        {
            if (txb_nombreRealUsr.Text == "NOMBRE")
            {
                txb_nombreRealUsr.Text = "";
                txb_nombreRealUsr.ForeColor = Color.DimGray;
                
            }
        }

        private void txb_Apellido_Enter(object sender, EventArgs e)
        {
            if (txb_Apellido.Text == "APELLIDO")
            {
                txb_Apellido.Text = "";
                txb_Apellido.ForeColor = Color.DimGray;
               
            }
        }

        private void txb_Apellido_Leave(object sender, EventArgs e)
        {
            if (txb_Apellido.Text == "")
            {
                txb_Apellido.Text = "APELLIDO";
                txb_Apellido.ForeColor = Color.DimGray;
                
            }
        }

        private void txb_Usuario_Leave(object sender, EventArgs e)
        {
            if (txb_Usuario.Text == "")
            {
                txb_Usuario.Text = "USUARIO";
                txb_Usuario.ForeColor = Color.DimGray;
                
            }
        }

        private void txb_Usuario_Enter(object sender, EventArgs e)
        {
            if (txb_Usuario.Text == "USUARIO")
            {
                txb_Usuario.Text = "";
                txb_Usuario.ForeColor = Color.DimGray;
                 
            }
        }

        private void txb_Contraseña_Enter(object sender, EventArgs e)
        {
            if (txb_Contraseña.Text == "CONTRASEÑA")
            {
                txb_Contraseña.Text = "";
                txb_Contraseña.ForeColor = Color.DimGray;
               
            }

        }

        private void txb_Contraseña_Leave(object sender, EventArgs e)
        {
            if (txb_Contraseña.Text == "")
            {
                txb_Contraseña.Text = "CONTRASEÑA";
                txb_Contraseña.ForeColor = Color.DimGray;
              
            }
        }

        private void txb_NombreMateria_Leave(object sender, EventArgs e)
        {
            if (txb_NombreMateria.Text == "")
            {
                txb_NombreMateria.Text = "MATERIA";
                txb_NombreMateria.ForeColor = Color.DimGray;

            }
        }

        private void txb_NombreMateria_Enter(object sender, EventArgs e)
        {
            if (txb_NombreMateria.Text == "MATERIA")
            {
                txb_NombreMateria.Text = "";
                txb_NombreMateria.ForeColor = Color.DimGray;

            }
        }

        private void txb_correlativa_Enter(object sender, EventArgs e)
        {
            if (txb_correlativa.Text == "CORRELATIVA")
            {
                txb_correlativa.Text = "";
                txb_correlativa.ForeColor = Color.DimGray;

            }
        }

        private void txb_correlativa_Leave(object sender, EventArgs e)
        {
            if (txb_correlativa.Text == "")
            {
                txb_correlativa.Text = "CORRELATIVA";
                txb_correlativa.ForeColor = Color.DimGray;

            }
        }

        private void FormAdmin_MouseDown(object sender, MouseEventArgs e)
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
