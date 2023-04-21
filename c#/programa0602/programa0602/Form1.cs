using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace programa0602
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnoperaciones_Click(object sender, EventArgs e)
        {
            DateTime fecha =  DateTime.Today;
            string formato = "MM  ddd,  hh mm";
           
            lblfecha.Text = fecha.ToString(formato);

            
        }
    }
}
