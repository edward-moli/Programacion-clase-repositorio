﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Programa0502
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            cmbalimentos.Items.Add("Lechuga");
            cmbalimentos.Items.Add("Leche");
        }

        private void btnadicionar_Click(object sender, EventArgs e)
        {
            cmbalimentos.Items.Add(txtalimento.Text);
        }

        private void cmbalimentos_SelectedIndexChanged(object sender, EventArgs e)
        {
            int indice= cmbalimentos.SelectedIndex;

            ldlindice.Text = indice.ToString(); 
            ldltexto.Text = cmbalimentos.Items[indice].ToString();
        }
    }
}
