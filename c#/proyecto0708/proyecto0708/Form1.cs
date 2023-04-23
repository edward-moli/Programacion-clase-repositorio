using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace proyecto0708
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnadicionanodo_Click(object sender, EventArgs e)
        {
            treeView1.Nodes.Add(txtnodo.Text);
            txtnodo.Text = "";
        }

        private void btnadicionaelemento_Click(object sender, EventArgs e)
        {
            treeView1.SelectedNode.Nodes.Add(txteelemento.Text);
            txteelemento.Text = "";
        }

        private void btnlipiaArbol_Click(object sender, EventArgs e)
        {
            treeView1.Nodes.Clear();
        }

        private void btneleminarnodo_Click(object sender, EventArgs e)
        {
            treeView1.Nodes.Remove(treeView1.SelectedNode);
        }
    }
}
