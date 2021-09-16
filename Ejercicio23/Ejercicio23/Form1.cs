using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Billetes;

namespace Ejercicio23
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnCandado_Click(object sender, EventArgs e)
        {
            
            if (this.btnCandado.ImageIndex == 0)
            {
                this.btnCandado.ImageIndex = 1;
                txtCotizacionDolar.Enabled = false;
                txtCotizacionEuro.Enabled = false;
                txtCotizacionPesos.Enabled = false;                
            }
            else
            {
                txtCotizacionDolar.Enabled = true;
                txtCotizacionEuro.Enabled = true;
                txtCotizacionPesos.Enabled = true;
                this.btnCandado.ImageIndex = 0;
            }          
        }                
        
        private void Form1_Load(object sender, EventArgs e)
        {
            txtCotizacionEuro.Text =Convert.ToString(Euro.GetCotizacion);
            txtCotizacionPesos.Text = Convert.ToString(Pesos.GetCotizacion);

            txtEuroAEuro.Enabled = false;
            txtDolarAEuro.Enabled = false;
            txtPesosAEuro.Enabled = false;
            txtDolarADolar.Enabled = false;
            txtEuroADolar.Enabled = false;
            txtPesosADolar.Enabled = false;
            txtPesosAPeso.Enabled = false;
            txtEuroAPeso.Enabled = false;
            txtDolarAPeso.Enabled = false;
        }

        private void txtCotizacionEuro_Leave(object sender, EventArgs e)
        {
            double cotiEuro;

            if (double.TryParse(txtCotizacionEuro.Text, out cotiEuro))
            {
                Euro.SetCotizacion(cotiEuro);
                MessageBox.Show("Cotización Euro " + Euro.GetCotizacion);
            }
        }

        private void txtCotizacionPesos_Leave(object sender, EventArgs e)
        {
            double cotiPeso;
                        
            if(double.TryParse(txtCotizacionPesos.Text, out cotiPeso))
            {
                Pesos.SetCotizacion(cotiPeso);
                MessageBox.Show("Cotización Peso " + Pesos.GetCotizacion);
            }            
        }

        private void txtCotizacionPesos_KeyPress(object sender, KeyPressEventArgs e)
        {
            if(char.IsLetter(e.KeyChar) || char.IsSymbol(e.KeyChar) || char.IsWhiteSpace(e.KeyChar) || char.IsSeparator(e.KeyChar))
            {
                e.Handled = true;
                MessageBox.Show("Solo numeros", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void txtCotizacionEuro_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (char.IsLetter(e.KeyChar) || char.IsSymbol(e.KeyChar) || char.IsWhiteSpace(e.KeyChar) || char.IsSeparator(e.KeyChar))
            {
                e.Handled = true;
                MessageBox.Show("Solo numeros", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void txtCotizacionDolar_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = true;
            MessageBox.Show("No se puede modificar", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }

        private void btnConvertEuro_Click_1(object sender, EventArgs e)
        {
            double cantEuro;

            if (double.TryParse(this.txtEuro.Text, out cantEuro))
            {
                Euro euro = new Euro(cantEuro);
                txtEuroAEuro.Text = Convert.ToString(euro.GetCantidad);

                Dolar dolar = (Dolar)euro;
                txtDolarAEuro.Text = Convert.ToString(dolar.GetCantidad);

                Pesos peso = (Pesos)euro;
                txtPesosAEuro.Text = Convert.ToString(peso.GetCantidad);
            }
        }

        private void btnConvertDolar_Click(object sender, EventArgs e)
        {
            double cantDolar;

            if (double.TryParse(this.txtDolar.Text, out cantDolar))
            {
                Dolar dolar = new Dolar(cantDolar);
                txtDolarADolar.Text = Convert.ToString(dolar.GetCantidad);

                Euro euro = (Euro)dolar;
                txtEuroADolar.Text = Convert.ToString(euro.GetCantidad);

                Pesos peso = (Pesos)dolar;
                txtPesosADolar.Text = Convert.ToString(peso.GetCantidad);
            }
        }

        private void btnConvertPeso_Click(object sender, EventArgs e)
        {
            double cantPesos;

            if (double.TryParse(this.txtPeso.Text, out cantPesos))
            {
                Pesos peso = new Pesos(cantPesos);
                txtPesosAPeso.Text = Convert.ToString(peso.GetCantidad);

                Euro euro = (Euro)(peso);
                txtEuroAPeso.Text = Convert.ToString(euro.GetCantidad);

                Dolar dolar = (Dolar)peso;
                txtDolarAPeso.Text = Convert.ToString(dolar.GetCantidad);
            }
        }

    }
}
