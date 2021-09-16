 using System;
using Entidades16;

namespace Ejercicio16
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Title = "Ejercicio 16";
            Alumno a1 = new Alumno("Mendoza", 123, "Javier");
            Alumno a2 = new Alumno("Perez", 2030, "Maria");
            Alumno a3 = new Alumno("Gonzalez", 8899, "Ana");

            a1.Estudiar(10, 5);
            a2.Estudiar(8, 7);
            a3.Estudiar(2, 1);

            a1.CalcularFinal();
            a2.CalcularFinal();
            a3.CalcularFinal();
;
            Console.WriteLine("{0}", a1.Mostrar());
            Console.WriteLine("{0}", a2.Mostrar());
            Console.WriteLine("{0}", a3.Mostrar());

            Console.ReadKey();
        }
    }
}
