using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Ejercicio28
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        // 4 hola
        // 3 chau
        // 2 que
        // 1 programacion segundo adios
        // hola hola hola hola chau que que programacion segundo adios chau chau
        private void btnCalcular_Click(object sender, EventArgs e)
        {
            Dictionary<string, int> contadorPalabras = ObtenerContadorPalabras();
            List<KeyValuePair<string, int>> podio = ObtenerPodio(contadorPalabras);
            MostrarPodio(podio);
        }

        private List<KeyValuePair<string, int>> ObtenerPodio(Dictionary<string, int> contadorPalabras)
        {
            List<KeyValuePair<string, int>> podio = contadorPalabras.ToList();
            podio.Sort(CompararCantidadRepeticiones);

            return podio;
        }
         
           
        private void MostrarPodio(List<KeyValuePair<string, int>> podio)
        {
            StringBuilder sb = new StringBuilder();

            if(podio.Count == 0)
            {
                sb.AppendLine("No se ingresaron palabras.");
            }
            else
            {
                for(int i = 0; i < 3 && i < podio.Count; i++)
                {
                    KeyValuePair<string, int> par = podio[i];
                    sb.AppendLine($"Palabra: {par.Key} - Cantidad: {par.Value}");
                }
                //foreach (KeyValuePair<string, int> par in podio)
                //{
                //    sb.AppendLine($"Palabra: {par.Key} - Cantidad: {par.Value}");
                //}
            }            
            MessageBox.Show(sb.ToString(), "Podio");
        }

        private int CompararCantidadRepeticiones(KeyValuePair<string, int> primerElemento, 
            KeyValuePair<string, int> segundoElemento)
        {
            /*if(primerElemento.Value < segundoElemento.Value)
            {
                return -1;
            }

            if (primerElemento.Value > segundoElemento.Value)
            {
                return 1;
            }

            return 0;*/
            return segundoElemento.Value - primerElemento.Value;
        }

        private Dictionary<string, int> ObtenerContadorPalabras()
        {
            string texto = rtxtContadorPalabras.Text;
            string[] palabras = texto.Split(' ', StringSplitOptions.RemoveEmptyEntries);
            Dictionary<string, int> contadorPalabras = new Dictionary<string, int>();

            foreach (string palabra in palabras)
            {
                if (contadorPalabras.ContainsKey(palabra))
                {
                    contadorPalabras[palabra]++;
                }
                else
                {
                    contadorPalabras.Add(palabra, 1);
                }
            }
            return contadorPalabras;
        }
    }
}
