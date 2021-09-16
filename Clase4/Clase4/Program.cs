using System;
using Entidades;

namespace Clase4
{
    class Program
    {
        static void Main(string[] args)
        {
            Automoviles au0 = new Automoviles();
            Automoviles au1 = new Automoviles(new Marca("Chevrolet"), 11);

            //au0.Acelerar();
            //au0.Acelerar();
            au0 += 1;
            au0 = au0 +1;
            Console.WriteLine(au0.velocidadActual);
            Console.ReadKey();

            au0 = au0 + 10;
            Console.WriteLine((int)au0);
            Console.WriteLine(au0);

            Console.WriteLine(au0 == 10);
            Console.WriteLine(au0 == 13 ? "SI" : "NO");

            Console.ReadKey();
        }
    }
}
