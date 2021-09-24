using System;
using System.Collections.Generic;
using System.Linq;
using Entidades33Libro;

namespace Ejercicio33LibroIndexado
{
    class Program
    {
        static void Main(string[] args)
        {
            Libro libro = new Libro();

            libro[2] = "HOLA";

            Console.WriteLine("Indice 0: {0}", libro[0]);
            Console.WriteLine("Indice 1: {0}", libro[1]);
            Console.WriteLine("Indice 2: {0}", libro[2]);
            Console.WriteLine("Indice 3: {0}", libro[3]);
            Console.WriteLine("Indice 4: {0}", libro[4]);

            Console.ReadKey();
        }
    }
}
