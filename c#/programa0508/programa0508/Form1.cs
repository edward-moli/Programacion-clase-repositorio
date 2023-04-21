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

namespace programa0508
{
    public partial class Form1 : Form
    {
        private ListViewGroup frutas = new ListViewGroup("Frutas", HorizontalAlignment.Center);
        private ListViewGroup carnes = new ListViewGroup("Carnes", HorizontalAlignment.Left);
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            //creamos un imalist
            ImageList misImagenes = new ImageList();
            misImagenes.ImageSize = new Size (100, 100);

            //obtener ellistado de imagenes
            string[] archivos = Directory.GetFiles("New folder");
           ;

           
            ListViewGroup frutas = new ListViewGroup("Frutas", HorizontalAlignment.Center);
            ListViewGroup carnes = new ListViewGroup("Carnes", HorizontalAlignment.Left);

            lsvalimentos.Items.Add(new ListViewItem("manzana",0,frutas));
            lsvalimentos.Items.Add(new ListViewItem("Pera",1, frutas));
            lsvalimentos.Items.Add(new ListViewItem("Sandia",2, frutas));
            lsvalimentos.Items.Add(new ListViewItem("Banana",3, frutas));
            lsvalimentos.Items.Add(new ListViewItem("Melon",4, frutas));
            lsvalimentos.Items.Add(new ListViewItem("Ciruela",5, frutas));

            ListViewItem mielemento = new ListViewItem("Pollo", carnes);
            lsvalimentos.Items.Add(mielemento);
            lsvalimentos.Items.Add(new ListViewItem("Res",carnes));
            lsvalimentos.Items.Add(new ListViewItem("pescado", carnes));
            lsvalimentos.Items.Add(new ListViewItem("cerdo", carnes));
            lsvalimentos.Items.Add(new ListViewItem("codoniz", carnes));

            lsvalimentos.Groups.Add(frutas);
            lsvalimentos.Groups.Add(carnes);


        }

        private void btnadicionar_Click(object sender, EventArgs e)
        {
            if(rbtfrutas.Checked==true)
            {
                lsvalimentos.Items.Add(new ListViewItem(txtelemento.Text, frutas));
           
                if(rbtcarne.Checked==true)
                {
                    lsvalimentos.Items.Add(new ListViewItem(txtelemento.Text, carnes));

                }
            
            }
        }
    }
}
