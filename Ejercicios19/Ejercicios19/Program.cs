using System;
using Entidades19;

namespace Ejercicios19ParaArriba
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Title = "Ejercicio 19";

            Sumador suma1 = new Sumador();
            Sumador suma2 = new Sumador();

            Console.WriteLine(suma2.Sumar(1,5));
            Console.WriteLine("Suma de float {0}", (int)suma1.Sumar(10, 8));

            Console.WriteLine("Suma de string {0}", suma1.Sumar("Hola", "Casa"));

            Console.WriteLine(suma1.Sumar(10, 33) + suma2.Sumar(10, 33));
            Console.WriteLine(suma1.Sumar(10, 33) == suma2.Sumar(10, 33));
            Console.WriteLine(suma1.Sumar(10, 33) == suma2.Sumar(10, 38));

            Console.ReadKey();
        }
    }
}
