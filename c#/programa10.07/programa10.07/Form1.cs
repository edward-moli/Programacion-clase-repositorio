using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace programa10._07
{
    public partial class splash : Form
    {
        public splash()
        {
            InitializeComponent();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            //ingrementamos la barra
            progressBar1.Increment(1);

            //Si llega al maximo paramos el timer
            if (progressBar1.Value == 100)
                timer1.Stop();
        }
    }
}
