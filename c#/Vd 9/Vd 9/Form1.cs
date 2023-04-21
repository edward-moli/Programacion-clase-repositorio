using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Vd_9
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnmostrar_Click(object sender, EventArgs e)
        {
            // MessageBox.Show("hola a toddos");
            // MessageBox.Show("Hola a todos", "mi MESSAGEbox");

            DialogResult r= MessageBox.Show("probamos botones", "Diferentes botones", MessageBoxButtons.AbortRetryIgnore,MessageBoxIcon.Question);

            if (r == DialogResult.Abort)
                lblmensaje.Text = "anular";
            if (r == DialogResult.Retry)
                lblmensaje.Text = "Reintentar";
            if (r == DialogResult.Ignore)
                lblmensaje.Text = "Omitir";

        }
    }
}
