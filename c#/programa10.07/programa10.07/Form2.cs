using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Threading;

namespace programa10._07
{
    public partial class Form2 : Form
    {
        public Form2()
        {
            //Creamos un hilo 
            Thread t = new Thread(new ThreadStart(SplashStart));

            //Arrancamos el hilo 
            t.Start();

            //Podemos a dormir la forma principal
            Thread.Sleep(5000);


            InitializeComponent();

            //Finalizamos el hilo
            t.Abort();
        }
        
        public void SplashStart()
        {

            Application.Run(new splash());

        }
    }
}
