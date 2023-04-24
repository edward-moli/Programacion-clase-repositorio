using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Media;

namespace prgrama0803
{
    public partial class Form1 : Form
    {
        private string ruta = "";
        public Form1()
        {
            InitializeComponent();
        }

        private void btnbeep_Click(object sender, EventArgs e)
        {
            Console.Beep();
        }

        private void btntono_Click(object sender, EventArgs e)
        {
            int freq = Convert.ToInt32(btntono.Text);
            int dura= Convert.ToInt32(btntono.Text);
            Console.Beep(freq,dura);
        }

        private void btnsistema_Click(object sender, EventArgs e)
        {
            SystemSounds.Exclamation.Play();
        }

        private void btncargar_Click(object sender, EventArgs e)
        {
            if(openFileDialog1.ShowDialog() == DialogResult.OK)
            { 
            ruta = openFileDialog1.FileName;
                lblruta.Text = ruta;
            }
        }

        private void btntocar_Click(object sender, EventArgs e)
        {
            try
            {
                SoundPlayer player = new SoundPlayer();
                player.SoundLocation = ruta;
                player.Load();
                player.Play();
            }
            catch(Win32Exception ex 
            {
                MessageBox.Show("No se pudo tocar el audio");
            }
        }
    }
}
