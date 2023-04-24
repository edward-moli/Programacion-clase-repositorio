using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace programa0906
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Paint(object sender, PaintEventArgs e)
        {
            //Obtenemos el objeto Graphics
            Graphics g = e.Graphics;

            //Cremaos un color
            Color micolor = Color.FromArgb(120, 150, 30);

            //Creamos la brocha solida 

            SolidBrush miBrocha = new SolidBrush(micolor);
            g.FillRectangle(miBrocha, new Rectangle(10,10,150,50));

            //Seleccionamos al entramado
            HatchStyle entramado =  HatchStyle.BackwardDiagonal;

            //Creamos brocha con entramado
            micolor = Color.FromArgb(200, 0, 30);
            HatchBrush brochaEnt= new HatchBrush(entramado,micolor);

            g.FillRectangle(brochaEnt,new Rectangle(10,70,150,50));

            //Creamos brocha con entramado A dos colores
            micolor = Color.FromArgb(200, 255, 150);
            Color micolor2 = Color.FromArgb(0, 200, 130);
            HatchBrush brochaEnt2 = new HatchBrush(entramado, micolor,micolor2);



        }
    }
}
