using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace prgrama0203
{
    public partial class Form1 : Form
    {
        Form2 miform2 = new Form2("Saludos");

        public Form1()
        {
            InitializeComponent();
        }

        private void btnenvio1_Click(object sender, EventArgs e)
        {
            //Creamos la instancia de la forma 2
            

            miform2.comentario = txtmensage.Text;
            //Mostramos la forma
            miform2.Show();


        }

        private void btnenvio2_Click(object sender, EventArgs e)
        {
            miform2.comentario =txtmensage.Text;
        }
    }
}
