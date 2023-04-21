using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Rdibotton_video8
{
    public partial class Gboxoperaciones : Form
    {
        public Gboxoperaciones()
        {
            InitializeComponent();
        }

        private void btncalcular_Click(object sender, EventArgs e)
        {
            double r = 0.0;
            double a = 0.0;
            double b = 0.0;

            a= Convert.ToDouble(txtA.Text);
            b= Convert.ToDouble(txtB.Text); 

            if(rbsuma.Checked ==true) 
                r= a+b;

            if (rbresta.Checked == true)
                r = a - b;

            if (rbmultiplicacion.Checked == true)
                r = a * b;

            if (rbdivicion.Checked == true)
                r = a / b;

            lblresultado.Text = r.ToString();
        }
    }
}
