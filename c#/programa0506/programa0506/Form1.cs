using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace programa0506
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btncargar_Click(object sender, EventArgs e)
        {
            Image miimagen = Image.FromFile("embase foto.jpg");
            picimagen.Image = miimagen;
        }
    }
}
