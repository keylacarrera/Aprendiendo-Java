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
            listView1.Items.Add("Pregunta 1:  " + Datos.Preg1);
            listView1.Items.Add("Respuesta:   " + Datos.Resp1);
            listView1.Items.Add("Pregunta 2:  " + Datos.Preg2);
            listView1.Items.Add("Respuesta:   " + Datos.Resp2);
            listView1.Items.Add("Pregunta 3:  " + Datos.Preg3);
            listView1.Items.Add("Respuesta:   " + Datos.Resp3);
            listView1.Items.Add("Pregunta 4:  " + Datos.Preg4);
            listView1.Items.Add("Respuesta:   " + Datos.Resp4);
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
