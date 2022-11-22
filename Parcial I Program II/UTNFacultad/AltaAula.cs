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

namespace UTNFacultad
{
    public partial class AltaAula : Form
    {
        [DllImport("user32.dll", EntryPoint = "ReleaseCapture")]
        private extern static void ReleaseCapture();
        [DllImport("user32.dll", EntryPoint = "SendMessage")]
        private extern static void SendMessage(IntPtr hWnd, int Msg, int wParam, int lParam);

        public AltaAula()
        {
            InitializeComponent();
        }


        private void panel1_MouseDown(object sender, MouseEventArgs e)
        {
            ReleaseCapture();
            SendMessage(this.Handle, 0x112, 0xf012, 0);
        }

        private void AltaAula_MouseDown(object sender, MouseEventArgs e)
        {
            ReleaseCapture();
            SendMessage(this.Handle, 0x112, 0xf012, 0);
        }

        private void btn_cancelar_Click(object sender, EventArgs e)
        {
            this.Close();   
        }

        private void btn_guardar_Click(object sender, EventArgs e)
        {
            try
            {
                ClassroomDao.Insert(txb_NuevaAula.Text);
                MessageBox.Show($"Se ha dado de alta el aula: {txb_NuevaAula.Text}");
                this.Close();
            }
            catch(Exception ex)
            {
                MessageBox.Show($"Ocurrio un error {ex.Message} ");
            }
 
        }
    }
    
}
