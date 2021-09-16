using System;
using Entidades22;
using Ejercicio13;

namespace Ejercicio22
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Title = "Ejercicio 22";
            string suma;

            //implicito
            NumeroDecimal decimalIngresado = 8;
            NumeroBinario binarioIngresado = "101111";

            //Console.WriteLine(binarioIngresado.numero);
            //Console.WriteLine(decimalIngresado.numero);

            ////explicito
            //Console.WriteLine((string)binarioIngresado.numero);
            //Console.WriteLine((double)decimalIngresado.numero) ;

            //suma
            Console.WriteLine("SUMA");
            Console.WriteLine(decimalIngresado + binarioIngresado);
            Console.WriteLine(binarioIngresado + decimalIngresado);

            //resta
            decimalIngresado = 8;
            binarioIngresado = "101111";

            Console.WriteLine("RESTA");
            Console.WriteLine("decimal - binario {0}",(decimalIngresado - binarioIngresado));
            decimalIngresado = 8;
            binarioIngresado = "101111";
            Console.WriteLine("binario - decimal {0} ",(binarioIngresado - decimalIngresado));



            Console.ReadKey();
        }
    }
}
