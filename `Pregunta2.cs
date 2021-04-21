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
    public partial class _Pregunta2 : Form
    {
        public _Pregunta2()
        {
            InitializeComponent();
            CenterToScreen();
        }
        private void btnValidar_Click(object sender, EventArgs e)
        {

            if (txtCond2.Text != "" && txtFor1.Text != "")
            {
                Datos.Preg3 = label5.Text;
                Datos.Resp3 = txtCond2.Text;
                Datos.Preg4 = label3.Text;
                Datos.Resp3 = txtFor1.Text;
                /* _Pregunta3 pre3 = new _Pregunta3();
                 pre3.Show();
                 this.Hide();*/
                MessageBox.Show("Preguntas completadas.");
                Resultados re = new Resultados();
                re.Show();
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
