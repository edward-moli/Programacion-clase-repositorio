﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics.Eventing.Reader;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace programa0604
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnprocesar_Click(object sender, EventArgs e)
        {
            bool error = false;

            foreach (char caracter in txtdato.Text)
                
            {
                if (char.IsDigit(caracter))
                {

                    error = true;
                    break;
                }
            }
            //Verificar por la condicion de error
            if (error)
            {
                errorProvider1.SetError(txtdato, "No se admiten numeros");
            }
            else
                errorProvider1.Clear();
        }

        private void txtdato_TextChanged(object sender, EventArgs e)
        {
            bool error = false;

            foreach (char caracter in txtdato.Text)

            {
                if (char.IsDigit(caracter))
                {

                    error = true;
                    break;
                }
            }
            //Verificar por la condicion de error
            if (error)
            {
                errorProvider1.SetError(txtdato, "No se admiten numeros");
            }
            else
                errorProvider1.Clear();

        }
    }
}
