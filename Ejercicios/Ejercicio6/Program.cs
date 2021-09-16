using System;

namespace Ejercicio6
{
    class Program
    {
        static void Main(string[] args)
        {
            /*6. Escribir un programa que determine si un año es bisiesto.
            Un año es bisiesto si es múltiplo de 4. Los años múltiplos de 100 no son bisiestos, salvo si ellos
            también son múltiplos de 400. Por ejemplo: el año 2000 es bisiesto pero 1900 no.
            Pedirle al usuario un año de inicio y otro de fin y mostrar todos los años bisiestos en ese rango.
            Nota: Utilizar estructuras repetitivas, selectivas y la función módulo (%).*/
            Console.Title = "Ejercicio 6";

            int desde;
            int hasta;

            Console.WriteLine("Ingrese año de inicio.");
            while(!int.TryParse(Console.ReadLine(), out desde) || desde < 1)
            {
                Console.WriteLine("Reingrese año de inicio.");
            }
            Console.WriteLine("Ingrese año de fin.");
            while (!int.TryParse(Console.ReadLine(), out hasta) || hasta > 10000 || hasta < desde)
            {
                Console.WriteLine("Reingrese año de hasta.");
            }

            for(int i = desde; i <= hasta; i++)
            {          
                if(i % 400 == 0)
                {
                    Console.WriteLine($"Año bisiesto {i}");
                }
                else if(i % 4 == 0 && i % 100 != 0)
                {
                    Console.WriteLine($"Año bisiesto {i}");
                }
            }

            Console.ReadKey();
        }
    }
}
