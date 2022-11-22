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
using UsuariosUTN.Clases;
using UsuariosUTN.Enums;
using UsuariosUTN.Usuarios;


namespace UTNFacultad
{
    public partial class FormAdmin : Form
    {
        [DllImport("user32.dll", EntryPoint = "ReleaseCapture")]
        private extern static void ReleaseCapture();
        [DllImport("user32.dll", EntryPoint = "SendMessage")]
        private extern static void SendMessage(IntPtr hWnd, int Msg, int wParam, int lParam);
        TipoUsuario usr;
        public FormAdmin()
        {
            InitializeComponent();
        }

        private void FormAdmin_Load(object sender, EventArgs e)
        {
            LogicaUTNAvellaneda.HardCodeAulas();
            LogicaUTNAvellaneda.HardCode();
        }

        public TipoUsuario setGetUsuario
        {
            set { usr = value; }get { return usr; } 
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

        private void btn_AltaUsuario_Click(object sender, EventArgs e)
        {
            AltaUsuario altaUsuario = new AltaUsuario();
            altaUsuario.Show();
            
        }

        private void btn_AltaClase_Click(object sender, EventArgs e)
        {
            AltaClase altaClase = new AltaClase();
        //    altaClase.UsuariosGeneric = LogicaUTNAvellaneda.UsuariosGeneric;
            altaClase.Show();   
        }

        private void btn_AltaAula_Click(object sender, EventArgs e)
        {
            AltaAula altaAula = new AltaAula();
            altaAula.Show();
        }

        private void btn_CreaExamen_Click(object sender, EventArgs e)
        {
         
            CrearExamen crearExamen = new CrearExamen();
            crearExamen.setUsuario = setGetUsuario;
            crearExamen.Show();
        }

        private void btn_altaPeriodo_Click(object sender, EventArgs e)
        {
            AltaPeriodo crearPeriodo = new AltaPeriodo();
            crearPeriodo.Show();
        }

        private void btn_exp_Click(object sender, EventArgs e)
        {
            ExportJSHTML export = new ExportJSHTML();
            export.Show();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

      
    }
}
