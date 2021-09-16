using System;

namespace Ejercicio3
{
    class Program
    {
        static void Main(string[] args)
        {
            /*3.Mostrar por pantalla todos los números primos que haya hasta el número que ingrese el usuario
            por consola.
            Nota: Utilizar estructuras repetitivas, selectivas y la función módulo(%).*/
            Console.Title = "Ejercicio 3";

            int numero;
            int primo;
            int acumuDivi = 0;

            Console.WriteLine("Ingrese un numero.");
            int.TryParse(Console.ReadLine(), out numero);

            for (int i = 2; i < numero; i++)
            {
                /*acumuDivi = 0;        //así chequea todos los que tengan dos divisores

                for (int j = 1 ; j <= i; j++)
                {                    
                    if ((i % j) == 0)
                    {
                        acumuDivi++;
                    }                    
                }
                if (acumuDivi == 2)
                {
                    Console.WriteLine("Numero primo {0}", i);                    
                } */
                acumuDivi = 0;

                for (int j = 2; j < i; j++) //así chequea todos los que tengan un divisor
                {
                    if ((i % j) == 0)
                    {
                        acumuDivi++;
                    }
                }
                if (acumuDivi == 0)
                {
                    Console.WriteLine("Numero primo {0}", i);
                }
            }


            Console.ReadKey();
        }
    }
}
