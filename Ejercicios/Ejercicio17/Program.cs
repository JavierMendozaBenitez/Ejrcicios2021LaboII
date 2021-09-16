using System;
using Entidades17;

namespace Ejercicio17
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Title = "Ejercicio 17";
            string dibu1;
            string dibu2;
            Boligrafo bo1 = new Boligrafo(100, ConsoleColor.Blue);
            Boligrafo bo2 = new Boligrafo(3, ConsoleColor.Red);

            ConsoleColor colorReal = Console.ForegroundColor;

            bo1.Pintar(10, out dibu1);
            Console.ForegroundColor = bo1.GetColor();
            Console.WriteLine(dibu1);
            Console.WriteLine("Nivel de tinta de boligrafo 1 después de gastarlo {0}", bo1.GetTinta());
            

            bo2.Pintar(2, out dibu2);
            Console.ForegroundColor = bo2.GetColor();
            Console.WriteLine(dibu2);
            Console.WriteLine("Nivel de tinta de boligrafo 2 después de gastarlo {0}", bo2.GetTinta());

            Console.ForegroundColor = colorReal;

            bo1.Recargar();
            Console.WriteLine("Nivel de tinta de boligrafo 1 después de recargarlo {0}", bo1.GetTinta());
            bo2.Recargar();
            Console.WriteLine("Nivel de tinta de boligrafo 2 después de recargarlo {0}", bo2.GetTinta());
                        
            Console.ReadKey();
        }
    }
}
