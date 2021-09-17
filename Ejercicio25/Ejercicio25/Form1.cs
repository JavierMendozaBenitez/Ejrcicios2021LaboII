using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Entidades22;

namespace Ejercicio25
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnBinToDec_Click(object sender, EventArgs e)
        {
            this.txtResultadoDec.Text = ((NumeroDecimal)((NumeroBinario)txtBinario.Text)).Numero.ToString();
        }

        private void btnDecToBin_Click(object sender, EventArgs e)
        {
            double auxIngre;

            if(double.TryParse(this.txtDecimal.Text, out auxIngre))
            {
                this.txtResultadoBin.Text = ((NumeroBinario)((NumeroDecimal)auxIngre)).Numero;
            }
            else
            {
                MessageBox.Show("Error");
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            txtResultadoDec.Enabled = false;
            txtResultadoBin.Enabled = false;
        }

    }
}
