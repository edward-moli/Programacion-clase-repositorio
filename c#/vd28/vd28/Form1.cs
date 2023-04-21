using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace vd28
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            dupfrutas.Items.Add("Melon");
            dupfrutas.Items.Add("Manzana");

        }

        private void btnadicionar_Click(object sender, EventArgs e)
        {
            dupfrutas.Items.Add(txtfruta.Text);
            txtfruta.Text = "";

        }

        private void dupfrutas_SelectedItemChanged(object sender, EventArgs e)
        {
            string fruta = (string)dupfrutas.SelectedItem;
            lblmensaje.Text = string.Format("Tu fruta favorita es {0}, muy sabrosa", fruta);

        }

        private void btnborrar_Click(object sender, EventArgs e)
        {
            int indice = dupfrutas.SelectedIndex;
            dupfrutas.Items.RemoveAt(indice);
            dupfrutas.SelectedIndex = 0;
        }
    }
}
