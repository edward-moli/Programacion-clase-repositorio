using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Ejercicio_11
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btncotizar_Click(object sender, EventArgs e)
        {
            
            double costo = 0.0;
            string cotizacion = "";
            cotizacion = "Cotizacion de auto para " + txtnombre.Text+"\r\n";
            //Obteer costo inicial
            costo = Convert.ToDouble(txtcosto.Text);

            //verificar segurpos
            if (rnbasico.Checked == true)
            {
                costo = costo + 500.0;
                cotizacion += "Lleva seguro basico de $500\r\n";
            }
            if (rbnterceros.Checked == true)
            {
                costo += 700.0;
                
                cotizacion += "LLeva seguro a terceros de $700 \r\n";
            }
            if (rbntotal.Checked == true)
            {
                costo += 1000.0;
                cotizacion += "LLeva seguro total de $1000\r\n";

            }
            //Verificar equipo
            if (chkaire.Checked == true)
            {
                costo += 700;
                cotizacion += "Con sistema de audio de $700";

            }
            //Mostrar total
            cotizacion += "El total a pagar es de " + costo.ToString(); 

            txtcotizacion.Text = cotizacion;

        }
    }
}

       
     
       

    

