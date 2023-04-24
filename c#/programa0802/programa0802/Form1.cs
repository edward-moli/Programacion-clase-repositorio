using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using programa0802.Properties;

namespace programa0802
{
    
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            txtmensaje.Text = (string)Settings.Default["menzaje"];

            chkimportado.Checked = (bool)Settings.Default["importado"];
            chkorganico.Checked = (bool)Settings.Default["organico"];

            this.Size = (Size)Settings.Default["Tamaño"];

                switch ((int)Settings.Default["frutas"])
            {
                case 0:
                    rbtmanzana.Checked = true;
                    rbtciruela.Checked = false;
                    rbtpera.Checked = false;
                    break;
                case 1:
                    rbtmanzana.Checked = false;
                    rbtciruela.Checked = true;
                    rbtpera.Checked = false;
                    break;
                case 2:
                    rbtmanzana.Checked = false;
                    rbtciruela.Checked = false;
                    rbtpera.Checked = true;
                    break;

            }

        }

        private void txtmensaje_TextChanged(object sender, EventArgs e)
        {
            Settings.Default["menzaje"]=txtmensaje.Text;
            Settings.Default.Save();

        }

        private void chkimportado_CheckStateChanged(object sender, EventArgs e)
        {
            Settings.Default["importado"] = txtmensaje.Text;
            Settings.Default.Save();
        }

        private void rbtmanzana_CheckedChanged(object sender, EventArgs e)
        {
            if(rbtmanzana.Checked==true) 
            {
                Settings.Default["frutas"] = 0;
                Settings.Default.Save();
            }
        }

        private void rbtpera_CheckedChanged(object sender, EventArgs e)
        {
            if (rbtpera.Checked == true)
            {
                Settings.Default["frutas"] = 1;
                Settings.Default.Save();
            }
        }

        private void rbtciruela_CheckedChanged(object sender, EventArgs e)
        {
            if (rbtciruela.Checked == true)
            {
                Settings.Default["frutas"] = 2;
                Settings.Default.Save();
            }
        }

        private void Form1_ResizeEnd(object sender, EventArgs e)
        {
            Settings.Default["Tamaño"] = this.Size;
            Settings.Default.Save();
        }
    }
}
