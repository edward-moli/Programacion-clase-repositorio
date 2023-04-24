﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace programa0901
{
    public partial class Form1 : Form
    {
        private int x=0, y=0;
        public Form1()
        {
            InitializeComponent();
        }
        private void Form1_Paint(object sender, PaintEventArgs e)
        {
            //Obtenemos el objeto graphics
            Graphics g = e.Graphics;

            //Creamos una fuente 
            Font fuente = new Font("Times New Roman", 35);

            //Dibujamos un texto 
            g.DrawString("Hola a todos", fuente, Brushes.Red, x, y);
        }
        private void btndibujar_Click(object sender, EventArgs e)
        {
            //obtenemos el objeto graphics por medio del handle de la ventana

            Graphics g =  Graphics.FromHwnd(this.Handle);

            //Creamos una fuente
            Font fuente = new Font("Times New Roman", 35);

            //Dibujamos un texto

            g.DrawString("En metodo", fuente, Brushes.Green, 50, 75);

            //tenemos que liberar los recuersos no administrado
            //Si lo creamos directamente hacemos dispose
            //Si es una referencia a un objeto graphics ya existente

            g.Dispose();
        }

        private void btninvalidar_Click(object sender, EventArgs e)
        {
            x += 5;
            y += 17;

           Invalidate(new Rectangle(0,0,100,120));
        }

       
    }
}
