using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Entidades21;

namespace Ejercicio24
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnFahrenheitA_Click(object sender, EventArgs e)
        {
            double tempIng;

            if(double.TryParse(this.textBox1.Text, out tempIng))
            {
                Fahrenheit fahrenheit = new Fahrenheit(tempIng);
                textBox10.Text = Convert.ToString(fahrenheit.GetTemperatura);

                Celsius celsius = (Celsius)fahrenheit;
                textBox8.Text = Convert.ToString(celsius.GetTemperatura);

                Kelvin kelvin = ((Kelvin)fahrenheit).GetTemperatura;
                textBox6.Text = Convert.ToString(kelvin.GetTemperatura);
            }
        }

        private void btnCelsiusA_Click(object sender, EventArgs e)
        {
            double tempIng;

            if (double.TryParse(this.textBox12.Text, out tempIng))
            {

                Celsius celsius = new Celsius(tempIng);
                textBox7.Text = Convert.ToString(celsius.GetTemperatura);

                Fahrenheit fahrenheit = (Fahrenheit)celsius;
                textBox9.Text = Convert.ToString(fahrenheit.GetTemperatura);

                Kelvin kelvin = ((Kelvin)celsius).GetTemperatura;
                textBox5.Text = Convert.ToString(kelvin.GetTemperatura);
            }
        }

        private void btnKelvinA_Click(object sender, EventArgs e)
        {
            double tempIng;

            if (double.TryParse(this.textBox11.Text, out tempIng))
            {
                Kelvin kelvin = new Kelvin(tempIng);
                textBox2.Text = Convert.ToString(kelvin.GetTemperatura);

                Celsius celsius = (Celsius)kelvin;
                textBox3.Text = Convert.ToString(celsius.GetTemperatura);

                Fahrenheit fahrenheit = ((Fahrenheit)kelvin).GetTemperatura;
                textBox4.Text = Convert.ToString(fahrenheit.GetTemperatura);
            }
        }
    }
}
