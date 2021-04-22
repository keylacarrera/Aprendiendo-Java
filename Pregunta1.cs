using System;
using System.Collections;
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
        ArrayList l1, l2;
        public Pregunta1()
        {
            InitializeComponent();
            CenterToScreen();
            l1 = new ArrayList();
            l2 = new ArrayList();

        }
        
        private void btnValidar_Click(object sender, EventArgs e)
        {      

            if (txtCond1.Text!="" && txtVar1.Text!="")
            {
                //asignamos valor a variables globales
                Datos.Preg1= label2.Text;
                Datos.Resp1 = txtVar1.Text;
                Datos.Preg2 = label3.Text;
                Datos.Resp2 = txtCond1.Text;

                //quitamos espacios en blanco de las cadenas
               // Datos.Resp1 = Datos.Resp1.Replace(" ", String.Empty);
               // Datos.Resp2 = Datos.Resp2.Replace(" ", String.Empty);

                //validamos las cadenas/respuestas
                ValidarResp1(Datos.Resp1);
                ValidarResp2(Datos.Resp2);

                //pasamos a la segunda pregunta

                /* _Pregunta2 pre2 = new _Pregunta2();
                 pre2.Show();          
                 this.Hide();*/
            }
            else
            {
                MessageBox.Show("Complete las preguntas.");
            }
        }
        private void ValidarResp1(string cad)
        {
            //l1.Add(cad);
            string pal1, stri;
            int i;

            do
            {
                for (i = 0; i < cad.Length; i++)
                {
                    stri = Char.ToString(cad[i]);

                    if (stri == " ")
                    {
                        pal1 = cad.Substring(0, i);
                        listBox1.Items.Add("\r" +pal1);

                        //cad = cad.Remove(0, i);
                        //listBox1.Items.Add(cad);


                        // break;

                    }
                    //cad = cad.Remove(0, i);

                }
                cad = cad.Remove(0, i);
            }
            while  (cad!="");
        }
        private void ValidarResp2(string cad)
        {
            l2.Add(cad);
            for (int i = 0; i < l2.Count; i++)
            {
                //comparar cada caracter de la cadena con otra
            }
        }


        private void lb1_Click(object sender, EventArgs e)
        {

        }
    }
}
