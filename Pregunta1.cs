using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ER
{
    public partial class Pregunta1 : Form
    {
        public Pregunta1()
        {
            InitializeComponent();
            CenterToScreen();

        }
        private void btnValidar_Click(object sender, EventArgs e)
        {
           

            if (txtCond1.Text!="" && txtVar1.Text!="")
            {
                Datos.Preg1= label2.Text;
                Datos.Resp1 = txtVar1.Text;
                Datos.Preg2 = label3.Text;
                Datos.Resp2 = txtCond1.Text;

                _Pregunta2 pre2 = new _Pregunta2();
                pre2.Show();          
                this.Hide();
            }
            else
            {
                MessageBox.Show("Complete las preguntas.");
            }
        }

        private void lb1_Click(object sender, EventArgs e)
        {

        }
    }
}
