using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace programa0505
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            //adicionar elementos
            lsbfrutas.Items.Add("Banana");
            lsbfrutas.Items.Add("Durazno");

        }

        private void btnadicionar_Click(object sender, EventArgs e)
        {
            lsbfrutas.Items.Add(txtfruta.Text);
            txtfruta.Text= string.Empty;
        }

        private void lsbfrutas_SelectedIndexChanged(object sender, EventArgs e)
        {
            if(lsbfrutas.SelectedIndex!=-1)
            lblfruta.Text = lsbfrutas.Items[lsbfrutas.SelectedIndex].ToString();
            
        }

        private void btneliminar_Click(object sender, EventArgs e)
        {
            int indice = lsbfrutas.SelectedIndex;
            if (indice == -1) 
            {
                lsbfrutas.Items.RemoveAt(indice);
            }
        }
    }
}
