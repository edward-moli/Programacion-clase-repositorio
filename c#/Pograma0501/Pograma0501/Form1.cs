using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Pograma0501
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            chkboxelementos.Items.Add("Carne");
            chkboxelementos.Items.Add("Pescado", true);

        }

        private void btnadd_Click(object sender, EventArgs e)
        {
            chkboxelementos.Items.Add(txtalimento.Text);

        }

        private void chkboxelementos_SelectedIndexChanged(object sender, EventArgs e)
        {
            int indice = chkboxelementos.SelectedIndex;
            if (indice == -1) 
            {
            lblNombre.Text = chkboxelementos.Items[indice].ToString();
            }

            if (chkboxelementos.GetItemChecked(3) == true)
                MessageBox.Show("El pescado es bueno");
        }
    }
}
