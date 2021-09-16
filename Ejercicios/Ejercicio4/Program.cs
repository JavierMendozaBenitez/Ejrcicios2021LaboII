using System;

namespace Ejercicio4
{
    class Program
    {
        static void Main(string[] args)
        {
            /*4. Un número perfecto es un entero positivo, que es igual a la suma de todos los enteros positivos
            (excluido el mismo) que son divisores del número.
            El primer número perfecto es 6, ya que los divisores de 6 son 1, 2 y 3; y 1 + 2 + 3 = 6.
            Escribir una aplicación que encuentre los 4 primeros números perfectos.
            Nota: Utilizar estructuras repetitivas y selectivas.*/

            Console.Title = "Ejercicio 4";
            int numero = 1;
            int acuDivi = 0;
            int contador = 0;

            do
            {
                for (int i = 1; i < numero; i++) 
                {
                    if (numero % i == 0)
                    {
                        acuDivi += i;
                    }
                }

                if (acuDivi == numero)
                {
                    //Console.WriteLine("{0}", numero);
                    //Console.WriteLine($"El numero perfecto {numero}");
                    Console.WriteLine("El numero perfecto {0}", numero.ToString("00.0"));
                    contador++;
                }

                acuDivi = 0;
                numero++;

            } while (contador < 4);
            
            Console.ReadKey();
        }
    }
}
