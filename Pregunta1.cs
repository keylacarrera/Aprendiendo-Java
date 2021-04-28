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
                    //quitamos espacios en blanco de inicio y fin.
                    Datos.Resp3A = Datos.Resp3A.Trim();

                    if (Datos.Resp3A.Length==1)
                    {
                        Datos.NumPal= contarVariable(Datos.Resp3A);
                                                                
                    }
                    else
                        ultimo = Datos.Resp3A.Substring(Datos.Resp3A.Length - 1, 1);
                    if(ultimo==";") Datos.NumPal = contarVariable(Datos.Resp3A);


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
        private bool esLetra(string cad)
        {
            bool letra = false;

            if (cad == "a") letra = true;
            if (cad == "b") letra = true;
            if (cad == "c") letra = true;
            if (cad == "d") letra = true;
            if (cad == "e") letra = true;
            if (cad == "f") letra = true;
            if (cad == "g") letra = true;
            if (cad == "h") letra = true;
            if (cad == "i") letra = true;
            if (cad == "j") letra = true;
            if (cad == "k") letra = true;
            if (cad == "l") letra = true;
            if (cad == "m") letra = true;
            if (cad == "n") letra = true;
            if (cad == "ñ") letra = true;
            if (cad == "o") letra = true;
            if (cad == "p") letra = true;
            if (cad == "q") letra = true;
            if (cad == "r") letra = true;
            if (cad == "s") letra = true;
            if (cad == "t") letra = true;
            if (cad == "u") letra = true;
            if (cad == "v") letra = true;
            if (cad == "w") letra = true;
            if (cad == "x") letra = true;
            if (cad == "y") letra = true;
            if (cad == "z") letra = true;
            return letra;
        }
        private bool esNumero(string cad)
        {
            bool num = false;

            if (cad == "0") num = true;
            if (cad == "1") num = true;
            if (cad == "2") num = true;
            if (cad == "3") num = true;
            if (cad == "4") num = true;
            if (cad == "5") num = true;
            if (cad == "6") num = true;
            if (cad == "7") num = true;
            if (cad == "8") num = true;
            if (cad == "9") num = true;
            return num;
        }
        /* private bool contarPalabras(string cad)
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
         }*/
        private bool contarPalabras(string cad)
        {
            //l1.Add(cad);
            string stri;
            int i, palabras = 0;
            bool haypalabras = false, coma = true, pcoma=true, signos=false;

            //quitamos espacion en blanco de inicio y fin.
            cad = cad.Trim();

            for (i = 0; i < cad.Length; i++)
            {
                stri = Char.ToString(cad[i]);
                ultimo = cad.Substring(cad.Length - 1, 1);

                //si el primer caracter es numero
                if (esNumero(stri)==true)
                {
                    MessageBox.Show("!Una variable no puede ser un numero¡");
                    haypalabras = false;                  
                }
                //si el primer caracter es letra y es un solo caracter de longitud
                if (esLetra(stri) == true && cad.Length == 1)
                {
                  
                  
                }            
                //si el primer caracter es letra y la lonfitud es mayor a 1 caracter
                if (esLetra(stri) == true && cad.Length > 1)
                {
                  //bool signos = false;
                    //verificar espacios en blanco y si termina con ';'                   

                    if (cad.Length > 2 && stri == "," && ultimo == ";")
                    {
                        //cad = cad.Replace(" ", String.Empty);
                        palabras += 1;
                        haypalabras = true;
                        signos = true;
                    }
                    else
                    {
                        signos = false;
                        haypalabras = false;
                    }
                    
                    if (cad.Length > 2 && stri != "," && ultimo == ";")
                    {
                        coma = false;
                        haypalabras = false;
                    }
                    if (cad.Length > 2 && stri == "," && ultimo != ";")
                    {
                        pcoma = false;
                        haypalabras = true;
                    }
                }
            }     
            if(pcoma==false) MessageBox.Show("Debe terminar con un punto y coma.");
            if(coma == false) MessageBox.Show("Debe separar cada variable con una coma.");
            if (signos == false) MessageBox.Show("Debe separar cada variable con una coma y terminar con un punto y coma.");
            else
            {
                MessageBox.Show("Numero de palabras:" + palabras);
                Datos.NumPal = palabras;
            }            
            return haypalabras;

            
        }

        private int contarVariable(string cad)
        {
            string stri;
            int palabras=0, fallos=0;
           // bool pcoma=true;

            //quitamos espacios en blanco de inicio y fin.
            cad = cad.Trim();

            for (int i = 0; i < cad.Length; i++)
            {
                stri = Char.ToString(cad[i]);
                ultimo = cad.Substring(cad.Length - 1, 1);
               

                //si el primer caracter es numero
                if (esNumero(stri) == true)
                {
                    MessageBox.Show("!Una variable no puede ser un numero¡");
                }
                //si el primer caracter es letra y es un solo caracter de longitud
                if (esLetra(stri) == true)
                {
                   
                    palabras = 1;
                   
                    if (cad == stri)
                    {
                        fallos += 1;
                       //pcoma = false;
                    }
                    else 
                        if(cad==stri+";")
                       fallos = 0 ; 
      
                }

            }
            if (fallos!=0) MessageBox.Show("Debe terminar con un punto y coma.");
            else { MessageBox.Show("Respuestas validadas. P: " + palabras); }
            

            return palabras;
        }
        #endregion

    }
}
