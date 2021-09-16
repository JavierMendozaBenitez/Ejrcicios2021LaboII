using System;
using Ejercicio15;

namespace Ejercicio15
{
    class Program
    {
        static void Main(string[] args)
        {
            /*Realizar un programa que permita realizar operaciones matemáticas simples (suma, resta,
            multiplicación y división). Para ello se le debe pedir al usuario que ingrese dos números y la
            operación que desea realizar (pulsando el caracter +, -, * o /).
            El usuario decidirá cuándo finalizar el programa.
            Crear una clase llamada Calculadora que posea dos métodos estáticos (de clase):
            a. Calcular (público): Recibirá tres parámetros, el primer número, el segundo número y la
            operación matemática. El método devolverá el resultado de la operación.
            b. Validar (privado): Recibirá como parámetro el segundo número. Este método se debe
            utilizar sólo cuando la operación elegida sea la DIVISIÓN. Este método devolverá
            TRUE si el número es distinto de CERO.*/
            Console.Title = "Ejercicio 15";

            double a;
            double b;
            double resultado;
            string simbolo;
            string continuar = "s";

            do
            {
                Console.WriteLine("Ingrese el primer numero.");
                while (!double.TryParse(Console.ReadLine(), out a))
                {
                    Console.WriteLine("ERROR.");
                }
                Console.WriteLine("Ingrese el segundo numero.");
                while (!double.TryParse(Console.ReadLine(), out b))
                {
                    Console.WriteLine("ERROR.");
                }

                Console.WriteLine("Ingrese la operacion.");
                simbolo = Console.ReadLine();
                while (simbolo != "/" && simbolo != "*" && simbolo != "-" && simbolo != "+")
                {
                    Console.WriteLine("ERROR. Reingrese");
                    simbolo = Console.ReadLine();
                }

                resultado = Calculadora.Calcular(a, b, simbolo);

                Console.WriteLine("Resultado {0}", resultado);

                Console.WriteLine("Continuar s/n");
                continuar = Console.ReadLine();
                while (continuar != "s" && continuar != "n")
                {
                    Console.WriteLine("ERROR. Reingrese");
                    continuar = Console.ReadLine();
                }

            } while (continuar == "s");


            Console.ReadKey();
        }
    }
}
