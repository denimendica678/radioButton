using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace radioButton
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void btnRezerviraj_Click(object sender, EventArgs e)
        {
            if (radioBtnAvion.Checked)
            {
                txtIspisOdabira.Text=("Odabrali ste Avion.");
            }
            if (radioBtnAutobus.Checked)
            {
                txtIspisOdabira.Text = ("Odabrali ste Autobus.");
            }
            if (radioBtnVlastitiPrijevoz.Checked)
            {
                txtIspisOdabira.Text = ("Odabrali ste Vlastiti prijevoz.");
            }



        }
    }
}
