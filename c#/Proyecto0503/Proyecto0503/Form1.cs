using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Proyecto0503
{
    public partial class Form1 : Form
    {
        private int n;
        public Form1()
        {
            InitializeComponent();
        }

        private void btnadicionar_Click(object sender, EventArgs e)
        {
            //Adiciones nuevo renglon

            int n = dygProductos.Rows.Add();

            //Colocamos la informacion
            dygProductos.Rows[n].Cells[0].Value = txtcodigo.Text;
            dygProductos.Rows[n].Cells[1].Value = txtnombre.Text;
            dygProductos.Rows[n].Cells[2].Value =txtprecio.Text;

            //Limpiamos los txt
            txtcodigo.Text = "";
            txtnombre.Text = "";
            txtprecio.Text = "";
        }

        private void dygProductos_CellClick(object sender, DataGridViewCellEventArgs e)
        {
             n = e.RowIndex;

            if(n!=-1)
            {
                lblinformacion.Text = (string)dygProductos.Rows[n].Cells[1].Value; ;
            }
        }

        private void btnborrar_Click(object sender, EventArgs e)
        {
            if(n!=-1)
            {
                dygProductos.Rows.RemoveAt(n);
            }
        }
    }
}
