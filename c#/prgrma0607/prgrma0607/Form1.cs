using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace prgrma0607
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            //Font mifuente = new Font("Arial", 16.0f,FontStyle.Bold|FontStyle.Italic);
            //lblmensajes.Font = mifuente;
        }

        private void btnfuente_Click(object sender, EventArgs e)
        {
            if(fontDialog1.ShowDialog() == DialogResult.OK) 
            {
                lblmensajes.Font = fontDialog1.Font;
            }
        }
    }
}
