using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using UsuariosUTN.Clases;

namespace UTNFacultad
{
    public partial class AltaPeriodo : Form
    {
        public AltaPeriodo()
        {
            InitializeComponent();
        }


        private void button2_Click_1(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btn_Aceptar_Click(object sender, EventArgs e)
        {
            try
            {
                if(txb_in is not null && txb_name is not null && txb_out is not null)
                {
                    PeriodoDao.Insert(new Periodos(
                        txb_name.Text, 
                        Convert.ToDateTime(txb_in.Text),
                        Convert.ToDateTime(txb_out.Text)));
                }
                MessageBox.Show($"El periodo {txb_name.Text} se dio de alta correctamente");
            }
            catch
            {

                MessageBox.Show($"Error. Faltan cargar datos");
            }
            finally
            {
                this.Close();
            }
        }
    }
}
