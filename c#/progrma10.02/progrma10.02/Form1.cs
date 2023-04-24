using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace progrma10._02
{
    public partial class Form1 : Form
    {
        private int y = 50, conteo = 0;
        public Form1()
        {
            InitializeComponent();
        }

        private void btnadicionar_Click(object sender, EventArgs e)
        {
            //Creamos la instancia del boton 
            Button temp= new Button();

            //Colocamos las propiedades
            temp.Height = 23;
            temp.Width = 200;
            temp.Location = new Point(50, y);
            y += 25;
            temp.Name = "btnboton" + conteo.ToString();
            temp.Text="Boton #" +conteo.ToString();
            conteo++;

            //Adicionar el handler
            temp.Click += new EventHandler(handlerComun_Click);
            //Adicionamos el boton a la forma
            Controls.Add(temp);



        
        }
        private void handlerComun_Click(object sender, EventArgs e)
        {
            Console.Beep(((Button)sender).Location.Y * 10, 000);
        }
    }
}
