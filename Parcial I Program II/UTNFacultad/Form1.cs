using System.Runtime.InteropServices;
using UsuariosUTN.Usuarios;

namespace UTNFacultad
{
    public partial class formLogIn : Form
    {
        
        public formLogIn()
        {
            InitializeComponent();
        }
        [DllImport("user32.dll", EntryPoint = "ReleaseCapture")]
        private extern static void ReleaseCapture();
        [DllImport("user32.dll", EntryPoint = "SendMessage")]
        private extern static void SendMessage (IntPtr hWnd, int Msg, int wParam, int lParam);

        private void txtUsr_Enter(object sender, EventArgs e)
        {
            if (txtUsr.Text == "USUARIO")
            {
                txtUsr.Text = "";
                txtUsr.ForeColor = Color.Black;
            }
        }
        private void txtUsr_Leave(object sender, EventArgs e)
        {
            if(txtUsr.Text == "")
            {
                txtUsr.Text = "USUARIO";
                txtUsr.ForeColor = Color.DimGray;
            }
        }
        private void txtPas_Leave(object sender, EventArgs e)
        {
            if(txtPas.Text == "")
            {
                txtPas.Text = "CONTRASEÑA";
                txtPas.ForeColor = Color.DimGray;
                txtPas.UseSystemPasswordChar = false;

            }
        }
        private void txtPas_Enter(object sender, EventArgs e)
        {
            if (txtPas.Text == "CONTRASEÑA")
            {
                txtPas.Text = "";
                txtPas.ForeColor = Color.Black;
                txtPas.UseSystemPasswordChar = true;

            }
        }
        private void btnIn_Click(object sender, EventArgs e)
        {
            long legajoAlumno;
            TipoUsuario auxUsuario = LogicaUTNAvellaneda.logUsr(txtUsr.Text, txtPas.Text);
            
            if(auxUsuario is not null)
            {
                legajoAlumno = auxUsuario.Legajo;
                if (auxUsuario.TipoUsuarix == UsuariosUTN.Enums.ETiposUsuarios.Alumno)
                {                   
                    FormAlumnos formAlumnos = new FormAlumnos();
                    formAlumnos.setUsuario = auxUsuario;
                    formAlumnos.Show();                    
                    txtUsr.Text = ""; txtPas.Text = "";
                }
                if (auxUsuario.TipoUsuarix == UsuariosUTN.Enums.ETiposUsuarios.Profesor)
                {
                    FormProfesor formProfesor = new FormProfesor();
                    formProfesor.setUsuario = auxUsuario;
                    formProfesor.Show();
                    txtUsr.Text = ""; txtPas.Text = "";
                }
                if (auxUsuario.TipoUsuarix == UsuariosUTN.Enums.ETiposUsuarios.Admin)
                {
                    FormAdmin formAdmin= new FormAdmin();
                  //  formProfesor.setUsuario = auxUsuario;
                    formAdmin.Show();
                    txtUsr.Text = ""; txtPas.Text = "";
                }
            }
            else
            {
                MessageBox.Show("Error al ingresar ");
            }
           //. this.Hide();
             
        }
        private void btnCanc_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void formLogIn_MouseDown(object sender, MouseEventArgs e)
        {
            ReleaseCapture();
            SendMessage(this.Handle, 0x112, 0xf012, 0);
        }

        private void panel1_MouseDown(object sender, MouseEventArgs e)
        {
            ReleaseCapture();
            SendMessage(this.Handle, 0x112, 0xf012, 0);
        }

        private void radioAlumno_CheckedChanged(object sender, EventArgs e)
        {
            txtUsr.Text = "a";
            txtPas.Text = "a";
            txtPas.UseSystemPasswordChar = true;
        }

        private void radioProfe_CheckedChanged(object sender, EventArgs e)
        {

            txtUsr.Text = "c";
            txtPas.Text = "c";
            txtPas.UseSystemPasswordChar = true;
        }

        private void radioAdmin_CheckedChanged(object sender, EventArgs e)
        {
            txtUsr.Text = "z";
            txtPas.Text = "z";
            txtPas.UseSystemPasswordChar = true;
        }
    }
}