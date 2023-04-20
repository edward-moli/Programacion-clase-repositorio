using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace programa0101
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnsaludo_Click(object sender, EventArgs e)
        {
            lblmensaje.Text = "Hola a todos";
        }

        private void bntdespedidaClick(object sender, EventArgs e)
        {

        }

        private void btndespedida_Click(object sender, EventArgs e)
        {
            lblmensaje.Text = "Adios";
            this.Text = "bye!";
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            lblmensaje.Text = "";
        }
    }
}
