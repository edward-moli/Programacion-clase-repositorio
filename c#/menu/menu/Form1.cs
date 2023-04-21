using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace menu
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void salirToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void acercaDeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Ejemplo para meno");
        }

        private void sumaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            double a= Convert.ToDouble(txtA.Text);
            double b= Convert.ToDouble(txtB.Text);

            double r = a + b;
            lblresultado.Text = r.ToString();
           
            slblvalores.Text = " A=" + a.ToString() + " B=" + b.ToString();
            slbloperacion.Text = "Suma";
            slblresultado.Text = "R=" + r.ToString();
        }

        private void restaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            double a = Convert.ToDouble(txtA.Text);
            double b = Convert.ToDouble(txtB.Text);

            double r = a - b;
            lblresultado.Text = r.ToString();

            slblvalores.Text = " A=" + a.ToString() + " B=" + b.ToString();
            slbloperacion.Text = "resta";
            slblresultado.Text = "R=" + r.ToString();
        }

        private void multiplicacionToolStripMenuItem_Click(object sender, EventArgs e)
        {
            double a = Convert.ToDouble(txtA.Text);
            double b = Convert.ToDouble(txtB.Text);

            double r = a * b;
            lblresultado.Text = r.ToString();
           
            slblvalores.Text = " A=" + a.ToString() + " B=" + b.ToString();
            slbloperacion.Text = "Multiplicacion";
            slblresultado.Text = "R=" + r.ToString();
        }

        private void divisionToolStripMenuItem_Click(object sender, EventArgs e)
        {
            double a = Convert.ToDouble(txtA.Text);
            double b = Convert.ToDouble(txtB.Text);

            double r = a / b;
            lblresultado.Text = r.ToString();

            slblvalores.Text = " A=" + a.ToString() + " B=" + b.ToString();
            slbloperacion.Text = "Division";
            slblresultado.Text="R="+r.ToString();
        }

       

        private void habilitarToolStripMenuItem_CheckedChanged(object sender, EventArgs e)
        {
            txtA.Enabled= habilitarToolStripMenuItem.Checked;
            txtB.Enabled= habilitarToolStripMenuItem.Checked;
        }

        private void borrarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            txtA.Text = "0";
        }

        private void aleatorioToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Random rnd = new Random();
            int valor=rnd.Next(0,100);
            txtA.Text = valor.ToString(); 

        }
    }
}
