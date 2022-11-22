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
    public partial class CrearExamen : Form
    {
        [DllImport("user32.dll", EntryPoint = "ReleaseCapture")]
        private extern static void ReleaseCapture();
        [DllImport("user32.dll", EntryPoint = "SendMessage")]
        private extern static void SendMessage(IntPtr hWnd, int Msg, int wParam, int lParam);
       
        TipoUsuario usuario;
        EParcialesPromedio eParciales = EParcialesPromedio.vacio;
        UsuariosGeneric<TipoUsuario> _usuariosGeneric;

        private UsuariosGeneric<TipoUsuario> UsuariosGeneric
        {
            get => _usuariosGeneric;
            set => _usuariosGeneric = value;
        }
        public CrearExamen()
        {
            InitializeComponent();
            LogicaUTNAvellaneda.HardUsr();
            UsuariosGeneric = LogicaUTNAvellaneda.UsuariosGeneric;
        }

        public TipoUsuario setUsuario
        {
            set { usuario = value; }
        }
        private void CrearExamen_Load(object sender, EventArgs e)
        {
            try
            {
                cbAlumnos.DataSource = UsuariosGeneric.RetornaListaUsuarios(UsuariosUTN.Enums.ETiposUsuarios.Alumno);
                cbPeriodo.DataSource = PeriodoDao.ListarPeriodos();
                cbMaterias.DataSource = LogicaUTNAvellaneda.ListarClasesDeProfesor(usuario);
                cbTipoParcial.DataSource = TiposParcialesDao.ListarTipos();
            }
            catch
            {
                MessageBox.Show("Ocurrio un error al cargar los datos institucionales");
            }
        }

        private void btn_Concretar_Click(object sender, EventArgs e)
        {
            Examen auxExamen;
            try
            {
                auxExamen = new Examen(
                    ((Usuario)cbAlumnos.SelectedItem).Legajo,
                    Convert.ToDateTime(txt_fecha.Text),
                    ((Periodos)cbPeriodo.SelectedItem).IdPeriodo,
                    nm_Nota.Value,
                    ((Clase)cbMaterias.SelectedItem).IdMateria,
                    ((TiposParciales)cbTipoParcial.SelectedItem).Id);

                if(LogicaUTNAvellaneda.ValidaIngresoExamen(auxExamen, ((Clase)cbMaterias.SelectedItem).IdClassroom))
                {
                    LogicaUTNAvellaneda.AgregaExamenALista(auxExamen);
                   // ExamenDao.Insert(auxExamen);
                    MessageBox.Show($"Se dio de alta el examen para la materia {((Clase)cbMaterias.SelectedItem).Materia} " +
                    $"Del  {StringTipoParcial(eParciales)} con fecha {txt_fecha.Text} " +
                    $"para el alumno {((Usuario)cbAlumnos.SelectedItem).Apellido}");
                }
                else
                {
                    MessageBox.Show($"El alumno {((Usuario)cbAlumnos.SelectedItem).Apellido} no esta inscripto en la materia " +
                        $"o ya tiene una parcial del tipo {((TiposParciales)cbTipoParcial.SelectedItem).Name} ");
                }         

            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error al querer gravar examen");
            }
            finally
            {
                this.Close();
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

        private void btn_salir_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
