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
    public partial class Form2 : Form
    {
        private string Comentario;
        public Form2(string pMensaje)
        {
            InitializeComponent();

            lblmensage.Text = pMensaje;
        }
        public string comentario
        {
            set
            {
                Comentario = value;
                lnlComentario.Text = Comentario;
            }
        }
    }
}
