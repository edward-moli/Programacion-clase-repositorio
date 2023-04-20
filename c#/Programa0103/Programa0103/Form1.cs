using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Programa0103
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void lblresultado_Click(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {
            lblresultado.Text = "";
            txtA.Text = "0";
            txtB.Text = "0";
        }

        private void btnsuma_Click(object sender, EventArgs e)
        {
            double a = Convert.ToDouble(txtA.Text);
            double b = Convert.ToDouble(txtB.Text);

            double r = a + b;
            lblresultado.Text=r.ToString();
        }

        private void btnresta_Click(object sender, EventArgs e)
        {
            double a = Convert.ToDouble(txtA.Text);
            double b = Convert.ToDouble(txtB.Text);

            double r = a - b;
            lblresultado.Text = r.ToString();
        }

        private void btnmultiplcacion_Click(object sender, EventArgs e)
        {
            double a = Convert.ToDouble(txtA.Text);
            double b = Convert.ToDouble(txtB.Text);

            double r = a * b;
            lblresultado.Text = r.ToString();
        }

        private void btndivicion_Click(object sender, EventArgs e)
        {
            double a = Convert.ToDouble(txtA.Text);
            double b = Convert.ToDouble(txtB.Text);

            double r = a / b;
            lblresultado.Text = r.ToString();
        }
    }
}
