using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Aplicacion__video_7
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btncalcular_Click(object sender, EventArgs e)
        {
            int total = 0;
            if (chkmonitor.Checked == true)
                total = total + 250;

            if (thkteclado.Checked == true)
                total = total + 15;

            if (chkmouse.Checked == true)
                total = total + 20;

            MessageBox.Show(" El total es" + total.ToString());
        }

        private void chkmonitor_CheckedChanged(object sender, EventArgs e)
        {
            if (chkmonitor.Checked == true)
                lnlmensage.Text = "";
            else lnlmensage.Text = "";
        }
    }
}
