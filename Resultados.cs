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
            listView1.Items.Add("Pregunta 1: " + Datos.PregA);
            listView1.Items.Add("Especificador de acceso: " + Datos.Resp1A);
            listView1.Items.Add("Tipo de dato: " + Datos.Resp2A);
            listView1.Items.Add("Variables:   " + Datos.Resp3A);
            listView1.Items.Add("Cantidad de variables:  " + Datos.NumPal);
            //listView1.Items.Add("Respuesta:   " + Datos.Resp3);
            //listView1.Items.Add("Pregunta 4:  " + Datos.Preg4);
            //listView1.Items.Add("Respuesta:   " + Datos.Resp4);
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
