using System;

namespace Ejercicio9
{
    class Program
    {
        static void Main(string[] args)
        {
            /*9. Escribir un programa que imprima por pantalla una pirámide como
            la siguiente:
            *
            ***
            *****
            *******
            *********
            El usuario indicará cuál será la altura de la pirámide ingresando un número entero positivo. Para el
            ejemplo anterior la altura ingresada fue de 5.
            Nota: Utilizar estructuras repetitivas y selectivas.*/
            Console.Title = "Ejercicio 9";
            int ingresado;
            int resp = 1;
            
            do
            {
                Console.WriteLine("Ingrese numero");
                while (!int.TryParse(Console.ReadLine(), out ingresado))
                {
                    Console.WriteLine("ERROR. Reingrese.");
                }

                for(int i= 1; i <= ingresado; i++)
                {
                    for (int j = 1; j <= i; j++)
                    {
                        Console.Write("*");
                    }
                    Console.WriteLine();
                }

                Console.WriteLine("Desea continuar? SI 1 NO 2");
                while (!int.TryParse(Console.ReadLine(), out resp) || resp < 1 || resp > 2)
                {
                    Console.WriteLine("ERROR. Reingrese.");
                }
            } while (resp == 1);
            
            Console.ReadKey();
        }
    }
}
