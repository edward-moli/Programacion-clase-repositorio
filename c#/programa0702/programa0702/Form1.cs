using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace programa0702
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnmostrar_Click(object sender, EventArgs e)
        {
            lblmensaje.Text= mtxtdato.Text;
        }

        private void mtxtdato_MaskInputRejected(object sender, MaskInputRejectedEventArgs e)
        {
            lblmensaje.Text = "Error a introducir el dato";

        }
    }
}
