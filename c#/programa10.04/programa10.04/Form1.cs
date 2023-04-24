using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace programa10._04
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnir_Click(object sender, EventArgs e)
        {
            //Navegar al URL indicado en el texbox
            webBrowser1.Navigate(txturl.Text);
        }

        private void btnatras_Click(object sender, EventArgs e)
        {
            //Vamos a la pagina anterior
            webBrowser1.GoBack();
        }

        private void btnsiguiente_Click(object sender, EventArgs e)
        {
            //Vamos a la pagina siguiente
            webBrowser1.GoForward();
        }

        private void btnrecargar_Click(object sender, EventArgs e)
        {
            webBrowser1.Refresh();
        }

        private void btnalto_Click(object sender, EventArgs e)
        {
            webBrowser1.Stop();

        }

        private void btnhome_Click(object sender, EventArgs e)
        {
            webBrowser1.GoHome();
        }
    }
}
