using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics.Eventing.Reader;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace calculadora
{
    public partial class Form1 : Form
    {
        double numero1 = 0, numero2 = 0;
        char Operador;
        public Form1()
        {
            InitializeComponent();
        }
       
        private void agregarNumero(object sender, EventArgs e)
        {
            var boton = ((Button)sender);
            if (textresultado.Text =="0")
                textresultado.Text = "";
            
            textresultado.Text += boton.Text;
        }

        private void btnresultado_Click(object sender, EventArgs e)
        {
            numero2 = Convert.ToDouble(textresultado.Text);

            if(Operador =='+')

            {
                textresultado.Text = (numero1 + numero2).ToString();
                numero1 = Convert.ToDouble(textresultado.Text);
            }
            else if (Operador =='-')
            {
                textresultado.Text = (numero1 - numero2).ToString();
                numero1 = Convert.ToDouble(textresultado.Text);
            }

            else if (Operador == 'x')
            {
                textresultado.Text = (numero1 * numero2).ToString();
                numero1 = Convert.ToDouble(textresultado.Text);
            }
            else if (Operador == '/')
            {
                
                {
                    textresultado.Text = (numero1 / numero2).ToString();
                    numero1 = Convert.ToDouble(textresultado.Text);
                }
               
          
            }
            

        }
        private void btnborrartodo_click(object sender, EventArgs e)
        {
            numero1 = 0;
            numero2 = 0;
            Operador = '\0';
            textresultado.Text = "0";
        }
        private void btnborrar_click(object sender, EventArgs e)
        {
            textresultado.Text = "0";
        }


            private void btnquitar_click(object sender, EventArgs e)
        {
                if(textresultado.Text.Length > 1)
            {
                textresultado.Text = textresultado.Text.Substring(0, textresultado.Text.Length - 1);
            }
        }
        private void btnpunto_click(object sender, EventArgs e)
        {
            if (!textresultado.Text.Contains("."))
                textresultado.Text += ".";
        }
        private void btnsigno_click(object sender, EventArgs e)
        {

        }
        private void ClikOperador(object sender, EventArgs e)
        {
            var boton = ((Button)sender);

            numero1 = Convert.ToDouble(textresultado.Text);
            Operador = Convert.ToChar(boton.Tag);

            if (Operador== '²')
            {
                numero1 = Math.Pow(numero1, 2);
                textresultado.Text = numero1.ToString();
            }
            else if (Operador =='√')
            {
                numero1 = Math.Sqrt(numero1);
                textresultado.Text = numero1.ToString();
            }
            else
            {
              
                textresultado.Text = "0";
            }
        }

    }
}
