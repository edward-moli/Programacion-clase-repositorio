using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace programa0204
{
    public partial class Form2 : Form
    {
        private string mensaje;
        private string contenido;
        public Form2()
        {
            InitializeComponent();
        }

        public string Mensaje
        { 
            get { return mensaje; } 
        }
        public string Contenido
        { 
            get { return contenido; } 
        }
        private void btnsalir_Click(object sender, EventArgs e)
        {
            mensaje = txtmensaje.Text;
            contenido = txtcontenido.Text;
            this.Close();
        }
    }
}
