using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.ComponentModel;

namespace programa10._08
{
    class NCControl : Button
    {
        private bool gigante = true;

        [Description("Dice si el boton se pone gigante")]
        [Category("CosasGigantes")]
        [DefaultValue(true)]
        public bool Gigante
        {
            get { return gigante; }
            set { gigante = value; }
        }


    protected override void OnMouseEnter(EventArgs e)
        {
            if (gigante)
                this.Size = new System.Drawing.Size(150, 150);

            base.OnMouseEnter(e);
        }
        

        }
    }
}
