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
    public partial class Resultados : Form
    {
        public Resultados()
        {
            InitializeComponent();
            llenarLista();
        }
        private void llenarLista()
        {
            listView1.Items.Add(Datos.Preg1);
            listView1.Items.Add(Datos.Resp1);
            listView1.Items.Add(Datos.Preg2);
            listView1.Items.Add(Datos.Resp2);
            listView1.Items.Add(Datos.Preg3);
            listView1.Items.Add(Datos.Resp3);
            listView1.Items.Add(Datos.Preg4);
            listView1.Items.Add(Datos.Resp4);
        }
        private void Preguntas_Load(object sender, EventArgs e)
        {
        }
        private void btnTerminar_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }
    }
}
