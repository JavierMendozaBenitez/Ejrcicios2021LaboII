using System;
using System.Collections.Generic;

namespace Ejercicio26
{
    class Program
    {
        static void Main(string[] args)
        {
            Random aleatorio = new Random();

            int[] numeros = new int [20];

            for (int i = 0; i < 10; i++)
            {
                numeros[i] = aleatorio.Next(-10, -1);
                
            }

            for (int i = 10; i < 20; i++)
            {
                numeros[i] = aleatorio.Next(1, 12);
            }

            Console.WriteLine("NUMEROS");
            for (int i = 0; i< 20; i++)
            {
                Console.WriteLine(numeros[i]);
            }

            //Ordenar

            for (int i = 0; i < 20; i++)
            {
                for (int j = 0; j < 20 - 1; j++)
                {
                    if (numeros[j] < numeros[j + 1])
                    {
                        int aux;
                        aux = numeros[j];
                        numeros[j] = numeros[j + 1];
                        numeros[j + 1] = aux;
                    }
                }
            }

            Console.WriteLine("ORDENADOS Positivos decrecientes.");
            for (int i = 0; i < 20; i++)
            {
                if(numeros[i] > 0)
                {
                    Console.WriteLine(numeros[i]);
                }
            }

            for (int i = 0; i < 20; i++)
            {
                for (int j = 0; j < 20 - 1; j++)
                {
                    if (numeros[j] > numeros[j + 1])
                    {
                        int aux;
                        aux = numeros[j];
                        numeros[j] = numeros[j + 1];
                        numeros[j + 1] = aux;
                    }
                }
            }

            Console.WriteLine("ORDENADOS Negativos crecientes.");
            for (int i = 0; i < 20; i++)
            {
                if (numeros[i] < 0)
                {
                    Console.WriteLine(numeros[i]);
                }
            }

            Console.WriteLine("ORDENADOS");
            for (int i = 0; i < 20; i++)
            {
                Console.WriteLine(numeros[i]);
            }

            Console.ReadKey();
        }        
    }
}
