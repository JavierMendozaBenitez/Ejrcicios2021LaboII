using System;
using Ejercicio11;

namespace Ejercicio11
{
    class Program
    {
        static void Main(string[] args)
        {
            /*11. Realizar una clase llamada Validación que posea un método estático llamado Validar, que posea la
            siguiente firma: bool Validar(int valor, int min, int max):
            a. valor: dato a validar
            b. min y max: rango en el cual deberá estar la variable valor.
            Pedir al usuario que ingrese 10 números enteros. Validar con el método desarrollado
            anteriormente que estén dentro del rango -100 y 100.
            Terminado el ingreso mostrar el valor mínimo, el valor máximo y el promedio.
            Nota: Utilizar variables escalares, NO utilizar vectores.*/
            Console.Title = "Ejercicio 11";
            int contador = 0;
            int valorIngr;
            int maximo = int.MinValue;
            int minimo = int.MaxValue;
            int acumulador = 0;
            float promedio;

            while (contador < 10)
            {
                Console.WriteLine("Ingrese un numero.");
                while(!int.TryParse(Console.ReadLine(), out valorIngr) || !Validacion.Validar(valorIngr, -100, 100))
                {
                    Console.WriteLine("ERROR. Reingrese.");
                }

                if (valorIngr > maximo)
                {
                    maximo = valorIngr;
                }
                if (valorIngr < minimo)
                {
                    minimo = valorIngr;
                }
                acumulador += valorIngr;
                contador++;
            }
            promedio = (float)acumulador / contador;
            Console.WriteLine("Minimo {0}\nMaximo {1}\nPromedio {2}.", minimo, maximo, promedio);

            Console.ReadKey();
        }
    }
}
