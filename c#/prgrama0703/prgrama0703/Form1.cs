using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace prgrama0703
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            monthCalendar1.BoldedDates = new DateTime[]
                {
            new DateTime(2023,2,23),
            new DateTime(2023,3,5),
            DateTime.Today.AddDays(5)

                };
        }

        private void btnfechas_Click(object sender, EventArgs e)
        {
            DateTime incio = monthCalendar1.SelectionStart;
            DateTime final= monthCalendar1 .SelectionEnd;

            lblinicion.Text = incio.ToString();
            lblfinal.Text = final.ToString();
        }

        private void monthCalendar1_DateChanged(object sender, DateRangeEventArgs e)
        {
            lblseleccion.Text = monthCalendar1.SelectionRange.ToString();

        }
    }
}
