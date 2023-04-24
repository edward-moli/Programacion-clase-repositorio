using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace programa10._03
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void txtcontenido_DragEnter(object sender, DragEventArgs e)
        {
             e.Effect = DragDropEffects.All;
        }

        private void txtcontenido_DragDrop(object sender, DragEventArgs e)
        {
            txtcontenido.Text = "";
            //Obtenemos el arreglo con los archivos
            string[] archivos = (string[])e.Data.GetData(DataFormats.FileDrop, false);
            string linea = "";
            lblArchivo.Text = archivos[0];

            //leemos el archivo
            StreamReader lector = File.OpenText(archivos[0]);

            while ((linea =lector.ReadLine()) != null)
            { txtcontenido.Text += linea + "\r\n"; }

            lector.Close();
        }
    }
}
