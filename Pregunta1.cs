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
       public int intentos = 0;
       public string ultimo;

        private void btnValidar_Click(object sender, EventArgs e)
        {      

            if (txtAcceso.Text!="" && txtTDato.Text!="" && txtVar.Text!="")
            {
                //asignamos valor a variables globales
                Datos.PregA = label2.Text;
                Datos.Resp1A = txtAcceso.Text;
                Datos.Resp2A = txtTDato.Text;
                Datos.Resp3A = txtVar.Text;
                //Datos.Preg2 = label3.Text;
                // Datos.Resp2 = txtCond1.Text;

                if (EspecificadorAcceso(Datos.Resp1A) == true && TipoDato(Datos.Resp2A) == true)
                {
                    if (contarPalabras(Datos.Resp3A)==true)
                    {
                        ultimo = Datos.Resp3A.Substring(Datos.Resp3A.Length - 1, 1);
                        if (ultimo == ";")
                        {
                            MessageBox.Show("Respuestas validadas.");
                        }
                       
                        
                    }
                    else
                  //  contarPalabras(Datos.Resp3A);
                    intentos += 1;

                    /* _Pregunta2 pre2 = new _Pregunta2();
                 pre2.Show();          
                 this.Hide();*/
                }
                else
                {              

                    if (EspecificadorAcceso(Datos.Resp1A) == false && TipoDato(Datos.Resp2A) == true)
                    {
                        MessageBox.Show("Respuesta no validada.");

                        txtAcceso.Text = "";
                        contarPalabras(Datos.Resp3A);
                    }else
                    if (EspecificadorAcceso(Datos.Resp1A) == true && TipoDato(Datos.Resp2A) == false)
                    {
                        MessageBox.Show("Respuesta no validada.");

                        txtTDato.Text = "";
                        contarPalabras(Datos.Resp3A);
                    }else
                    if (EspecificadorAcceso(Datos.Resp1A) == false && TipoDato(Datos.Resp2A) == false)
                    {
                        MessageBox.Show("Respuestas no validada.");
                        txtAcceso.Text = "";
                        txtTDato.Text = "";
                        contarPalabras(Datos.Resp3A);
                    }
                }
                
            }
            else
            {
                MessageBox.Show("Complete las preguntas.");
            }
        }
        
        private void ValidarResp2(string cad)
        {
            l2.Add(cad);
            for (int i = 0; i < l2.Count; i++)
            {
                //comparar cada caracter de la cadena con otra
            }
        }

        #region Metodos
        private bool EspecificadorAcceso(string cad)
        {
            bool acceso = false;
            cad = cad.Replace(" ", String.Empty);

            if (cad == "private") acceso = true;
            if (cad == "public") acceso = true;
            if (cad == "protected") acceso = true;
            return acceso;
        }
        private bool TipoDato(string cad)
        {
            bool dato = false;
            cad = cad.Replace(" ", String.Empty);

            if (cad == "int") dato = true;
            if (cad == "string") dato = true;
            if (cad == "float") dato = true;
            if (cad == "char") dato = true;
            if (cad == "boolean") dato = true;
            if (cad == "double") dato = true;
            if (cad == "byte") dato = true;
            if (cad == "short") dato = true;
            if (cad == "long") dato = true;
            return dato;
        }
        private bool contarPalabras(string cad)
        {
            //l1.Add(cad);
            string stri;
            int i, palabras = 0; 
            bool haypalabras = false;            

            for (i = 0; i < cad.Length; i++)
            {
                stri = Char.ToString(cad[i]);

                if (stri == "," || stri==";")
                {
                    palabras += 1;
                    haypalabras = true;

                    //cad = cad.Replace(" ", String.Empty);

                    ultimo = cad.Substring(cad.Length - 1, 1);
                    
                }
                else
                {
                    if (stri == ";" )
                    {
                        haypalabras = false;
                    }
                }
            }
            if (haypalabras == false)
            {
                MessageBox.Show("Debe separar cada variable con una coma .");
                
            }
            else
            {
                if (ultimo != ";")
                {
                    MessageBox.Show("Debe terminar con un punto y coma.");
                }
            }         
            MessageBox.Show("Numero de palabras:" + palabras);
            Datos.NumPal = palabras;
            return haypalabras;
        }
        #endregion

    }
}
