using System;

namespace Ejercicio1
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Title = "Titulo ejercicio 1";
            int numero;
            int maximo = int.MinValue;
            int minimo = int.MaxValue;
            float promedio;
            int acumulador = 0;
            int contador = 0;

            while(contador<5)
            {
                Console.WriteLine("Ingrese un numero");
                
                while (!int.TryParse(Console.ReadLine(), out numero))
                {
                    Console.WriteLine("Reingrese numero");
                }

                if (numero > maximo)
                {
                    maximo = numero;
                }
                if (numero < minimo)
                {
                    minimo = numero;
                }

                acumulador = acumulador + numero;

                contador += 1;
            }
            promedio = (float) acumulador / contador;

            Console.WriteLine("El maximo es {0} y el minimo es {1}\nEl promedio es {2}", maximo, minimo, promedio);
            
            Console.ReadKey();

        }
    }
}
