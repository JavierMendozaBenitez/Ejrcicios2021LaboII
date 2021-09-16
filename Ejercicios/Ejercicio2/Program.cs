using System;

namespace Ejercicio2
{
    class Program
    {
        static void Main(string[] args)
        {
            /*2.Ingresar un número y mostrar: el cuadrado y el cubo del mismo.Se debe validar que el número sea
            mayor que cero, caso contrario, mostrar el mensaje: "ERROR. ¡Reingresar número!".
            Nota: Utilizar el método ‘Pow’ de la clase Math para realizar la operación.*/

            Console.Title = "Titulo ejercicio 2";
            int numero;
            double cuadrado;
            double cubo;

            Console.WriteLine("Ingrese un numero.");

            while((!int.TryParse(Console.ReadLine(), out numero)) || numero < 1)
            {
                Console.WriteLine("ERROR. ¡Reingresar número!");
            }

            cuadrado = Math.Pow(numero, 2);
            cubo = Math.Pow(numero, 3);

            Console.WriteLine("El cuadrado es {0}\nEl cubo es {1}", cuadrado, cubo);

            Console.ReadKey();
        }
    }
}
