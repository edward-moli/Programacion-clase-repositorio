using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace timer_vd21
{
    public partial class Form1 : Form
    {
        private int conteo;
        public Form1()
        {
            
            InitializeComponent();
            conteo = 0;
        }

        private void timer1_Tick_1(object sender, EventArgs e)
        {
            conteo++;
            lblvalor.Text = conteo.ToString();

            if (Pbrtrabajo.Value < 100)
                Pbrtrabajo.Value++;
            if(Pbrtrabajo.Value ==100)
                timer1.Enabled = false;
        }
        

        private void btninicio_Click(object sender, EventArgs e)
        {
           
            timer1.Start();
            Pbrtrabajo.Value = 0;
        }


        private void btndetener_Click(object sender, EventArgs e)
        {
            timer1.Enabled=false;
            tbrintervalo.Value = tbrintervalo.Minimum;
            lblvalor.Text= tbrintervalo.Value.ToString();
            timer1.Interval = tbrintervalo.Value;
        }

        private void Form1_FormClosing(object sender, FormClosingEventArgs e)
        {
            timer1.Enabled = false;
        }

        private void tbrintervalo_Scroll(object sender, EventArgs e)
        {
            lblvalor.Text=tbrintervalo.Value.ToString();
            timer1.Interval = tbrintervalo.Value;
        }

        private void btncalculo_Click(object sender, EventArgs e)
        {
            for (int n = 0; n < 100000; n++) 
            {
                //aqui algun proceso
                if (n % 1000 == 0)
                    Pbrtrabajo.PerformStep();
            
            }
        }
    }
}
