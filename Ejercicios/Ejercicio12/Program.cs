using System;
using Ejercicio12;

namespace Ejercicio12
{
    class Program
    {
        static void Main(string[] args)
        {
            /*12. Realizar un programa que sume números enteros hasta que el usuario lo determine, por medio de
            un mensaje "¿Continuar? (S/N)".
            En el método estático ValidaS_N(char c) de la clase ValidarRespuesta, se validará el ingreso de
            opciones.
            El método devolverá un valor de tipo booleano, TRUE si se ingresó una 'S' y FALSE si se ingresó
            cualquier otro valor.*/
            Console.Title = "Ejercicio 12";
            string respuesta;
            int numero;
            int acumulador = 0;
            bool continuar = false;

            do
            {
                Console.WriteLine("Ingrese un numero.");
                while(!int.TryParse(Console.ReadLine(), out numero))
                {
                    Console.WriteLine("ERROR");
                }

                acumulador += numero;

                Console.WriteLine("Acumulado {0}", acumulador);

                Console.WriteLine("Continuar (S/N)?");
                respuesta = Console.ReadLine();
                continuar = ValidarRespueta.ValidaS_N(Convert.ToChar(respuesta));


            } while (continuar == true);

            Console.ReadKey();
        }
    }
}
