using System;
using Ejercicio13;

namespace Ejercicio13
{
    class Program
    {
        static void Main(string[] args)
        {
            /*3. Desarrollar una clase llamada Conversor, que posea dos métodos de clase (estáticos):
            string DecimalBinario(int). Convierte un número de entero a binario.
            int BinarioDecimal(string). Convierte un número binario a entero.
            NOTA: no utilizar los atajos del lenguaje, hacerlo mediante estructuras repetitivas y de control.*/
            Console.Title = "Ejercicio 13";
            int numeroIngDecimal;
            int convertDecimal;
            string convertBinario = string.Empty;
            string numeroIngBinario = string.Empty;

            Console.WriteLine("Ingrese un numero a convertir de decimal a binario.");
            while(!int.TryParse(Console.ReadLine(), out numeroIngDecimal))
            {
                Console.WriteLine("ERROR");

            }
            convertBinario = Conversor.DecimalBinario(numeroIngDecimal);
            Console.WriteLine("Binario {0}", convertBinario);


            Console.WriteLine("ingrese el numero en Binario a convertir a decimal: ");
            numeroIngBinario = Console.ReadLine();
            convertDecimal = Conversor.BinarioDecimal(numeroIngBinario);
            Console.WriteLine("Decimal {0}", convertDecimal);
            Console.ReadKey();
        }
    }
}
