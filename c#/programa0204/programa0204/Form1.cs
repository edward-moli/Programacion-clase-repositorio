using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace programa0204
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnabrirforma_Click(object sender, EventArgs e)
        {
            Form2 mifoma2 = new Form2();

            mifoma2.ShowDialog();
            lnlmensaje.Text = mifoma2.Mensaje;
            lblcontenido.Text = mifoma2.Contenido;
        }
    }
}
