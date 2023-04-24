using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace programa10._01
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Console.Beep();

            if (((Button)sender).Name == "Button1")
                MessageBox.Show("Es el boton uno");
            
            if(((Button)sender).Name == "Button2")
                lblmensaje.Text=("Es el boton dos");

            if(((Button)sender).Name == "Button3")
                lblmensaje.Text = ((Button)sender).Text;

        }

        
    }
}
