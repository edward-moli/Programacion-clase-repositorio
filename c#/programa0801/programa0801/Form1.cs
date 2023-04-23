using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace programa0801
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnabrirnotepad_Click(object sender, EventArgs e)
        {
            //Nos permitimos recibir eventos del notepad
            prcNotePad.EnableRaisingEvents = true;

            //Arracamos el proceso
            prcNotePad.Start();

            lblestado.Text = "Notepad Arracado";
        }

        private void btncerrarnotepad_Click(object sender, EventArgs e)
        {
            prcNotePad.Kill();
        }

        private void prcNotePad_Exited(object sender, EventArgs e)
        {
            //Este evento sucede cuando se cierra el proceso
            lblestado.Text = "Notepad cerrado";
           // notifyIcan1.ShowBallonTip(100,"Alerta","Notepad cerrado, tootpipcom.info);

        }

        private void mostrarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //Mostramos la forma
            this.Show();
        }

        private void esconderToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //escondemos la forma
            this.Hide();
        }
    }
}
