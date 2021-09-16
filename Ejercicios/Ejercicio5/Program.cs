using System;

namespace Ejercicio5
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Title = "Ejercicio 5";
            /*5. Un centro numérico es un número que separa una lista de números enteros (comenzando en 1) en
            dos grupos de números, cuyas sumas son iguales.
            El primer centro numérico es el 6, el cual separa la lista (1 a 8) en los grupos: (1; 2; 3; 4; 5) y (7; 8)
            cuyas sumas son ambas iguales a 15. El segundo centro numérico es el 35, el cual separa la lista (1 a
            49) en los grupos: (1 a 34) y (36 a 49) cuyas sumas son ambas iguales a 595.
            Se pide elaborar una aplicación que calcule los centros numéricos entre 1 y el número que el
            usuario ingrese por consola.
            Nota: Utilizar estructuras repetitivas y selectivas.*/
            int numero;
            int acumulador = 0;
            int copiaNumero = 0;
            int acumuladorPasado = 0;
            int esCentro = 0;

            Console.WriteLine("Ingrese un numero.");

            while (!int.TryParse(Console.ReadLine(), out numero) || numero < 1)
            {
                Console.WriteLine("ERROR. Reingrese numero");
            }
            copiaNumero = numero;
            for (int i = 1; i < numero; i++)
            {
                acumulador += i;    
            }
            do
            {
                if (acumulador > acumuladorPasado)
                {
                    copiaNumero++;
                    acumuladorPasado += copiaNumero;
                }
                else if (acumulador == acumuladorPasado)
                {
                    Console.WriteLine($"El numero {numero} es centro numerico. Acumulado {acumulador} y pasado {acumuladorPasado}");
                    esCentro = 1;
                }
                else
                {
                    Console.WriteLine("El numero no es un centro numerico");
                    esCentro = 2;
                }
            } while (esCentro == 0);
            
            Console.ReadKey();
        }
    }
}
