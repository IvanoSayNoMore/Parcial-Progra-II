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
using UsuariosUTN.Enums;
using UsuariosUTN.Usuarios;
using UsuariosUTN.Clases;

namespace UTNFacultad
{
    public partial class AltaUsuario : Form
    {
        [DllImport("user32.dll", EntryPoint = "ReleaseCapture")]
        private extern static void ReleaseCapture();
        [DllImport("user32.dll", EntryPoint = "SendMessage")]
        private extern static void SendMessage(IntPtr hWnd, int Msg, int wParam, int lParam);


        private void AltaUsuario_Load(object sender, EventArgs e)
        {
            List<ETiposUsuarios> _listaTipos = Enum.GetValues(typeof(ETiposUsuarios)).Cast<ETiposUsuarios>().ToList();
            cbx_TipoUsuario.DataSource = _listaTipos;
            txb_Apellido.Text = null;
        }

        private void AltaUsuario_MouseDown(object sender, MouseEventArgs e)
        {
            ReleaseCapture();
            SendMessage(this.Handle, 0x112, 0xf012, 0);
        }


        public AltaUsuario()
        {
            InitializeComponent();
        }
        private void btn_concretar_Click(object sender, EventArgs e)
        {

            if (txb_Apellido.Text != "APELLIDO"
                && txb_Contraseña.Text != "CONTRASEÑA"
                && txb_Nombre.Text != "NOMBRE"
                && txb_Usuario.Text != "USUARIO")
            {
                try
                {
                    LogicaUTNAvellaneda.AgregarUsuarioALista(new TipoUsuario(
                        txb_Nombre.Text,
                        txb_Apellido.Text,
                        txb_Usuario.Text,
                        txb_Contraseña.Text,
                        0,
                         Convert.ToInt32(cbx_TipoUsuario.SelectedItem) + 1));
                                        this.Close();
                }
                catch(Exception ex)
                {
                    MessageBox.Show("Ocurrio un error al validar los datos ingresados. Reintente");
                }
            }
            else
            {
                MessageBox.Show("Error en datos ingresados");
            }
        }


        

        private void txb_Apellido_Enter(object sender, EventArgs e)
        {
            if (txb_Apellido.Text == "APELLIDO")
            {
                txb_Apellido.Text = "";
                txb_Apellido.ForeColor = Color.Gray;
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

        private void txb_Nombre_Leave(object sender, EventArgs e)
        {
            if (txb_Nombre.Text == "")
            {
                txb_Nombre.Text = "NOMBRE";
                txb_Nombre.ForeColor = Color.DimGray;
            }
        }
        private void txb_Nombre_Enter(object sender, EventArgs e)
        {
            if (txb_Nombre.Text == "NOMBRE")
            {
                txb_Nombre.Text = "";
                txb_Nombre.ForeColor = Color.Gray;
            }
        }

        private void txb_Usuario_Enter(object sender, EventArgs e)
        {
            if (txb_Usuario.Text == "USUARIO")
            {
                txb_Usuario.Text = "";
                txb_Usuario.ForeColor = Color.Gray;
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

        private void txb_Contraseña_Leave(object sender, EventArgs e)
        {
            if (txb_Contraseña.Text == "")
            {
                txb_Contraseña.Text = "CONTRASEÑA";
                txb_Contraseña.ForeColor = Color.DimGray;
            }
        }

        private void txb_Contraseña_Enter(object sender, EventArgs e)
        {
            if (txb_Contraseña.Text == "CONTRASEÑA")
            {
                txb_Contraseña.Text = "";
                txb_Contraseña.ForeColor = Color.Gray;
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
