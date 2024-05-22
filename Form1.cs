using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics.Eventing.Reader;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace tokorotianyar
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

        private void cmbjenis_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (comboBox1.SelectedItem == "Roti Ciabatta")
            {
                textBox1.Text = "Ciabatta";
                txtharga.Text = "45000";
            }
            else if (comboBox1.SelectedItem == "Roti Focaccia")
            {
                textBox1.Text = "Focaccia";
                txtharga.Text = "50000";
            }
            else if (comboBox1.SelectedItem == "Roti Pumpernickel")
            {
                textBox1.Text = "Pumpernickel";
                txtharga.Text = "70000";
            }
        }

        private void btnhitung_Click(object sender, EventArgs e)
        {
            double tyy, ggd, hde;

            tyy = double.Parse(txtjumlah.Text);
            ggd = double.Parse(txtharga.Text);

            hde = ggd * tyy;

            txttotal1.Text = hde.ToString();






        }

        private void btnbatal_Click(object sender, EventArgs e)
        {
            double bhf, hdf, dyh;

            bhf = double.Parse(txttotal1.Text);
            hdf = double.Parse(txtpotongan.Text);

            dyh = hdf - bhf;

            txtkembalian.Text = dyh.ToString();
        }
    }
}
