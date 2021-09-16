using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio13
{
    public static class Conversor
    {
        public static string DecimalBinario(int numero)
        {
            string valorBinario = string.Empty; //variable que vamos a retornar
            int resultDiv = numero;
            int restoDiv;
            //Generamos dos variables una para verificar si el resultado de la division es igual a 0 y otra para verificar el resto
            if (resultDiv >= 0)
            {
                do
                {
                    restoDiv = resultDiv % 2;
                    resultDiv /= 2;
                    valorBinario = restoDiv.ToString() + valorBinario; // lo hago de esta manera para ir dejando la ultima division en la primer posicion
                } while (resultDiv > 0);
            }

            return valorBinario;
        }
        public static int BinarioDecimal(string valorRecibido)
        {
            int resultado = 0; //Valor a retornar, lo inicializamos en cero dado que si la cadena recibida no corresponder a un binario, restornamos cero
            int cantidadCaracteres = valorRecibido.Length; // guardamos la longitud de la cadena para saber hasta donde tenemos que ir calculando
            foreach (char caracter in valorRecibido)
            {
                cantidadCaracteres--;
                if (caracter == '1')
                {
                    resultado += (int)Math.Pow(2, cantidadCaracteres);
                }
            }
            return resultado;
        }
    }
}
