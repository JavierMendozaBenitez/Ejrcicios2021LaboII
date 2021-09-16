using System;
using Ejercicio14;

namespace Ejercicio14
{
    class Program
    {
        static void Main(string[] args)
        {
            /*Realizar una clase llamada CalculoDeArea que posea 3 métodos de clase (estáticos) que realicen el
            cálculo del área que corresponda:
            a. double CalcularCuadrado(double)
            b. double CalcularTriangulo(double, double)
            c. double CalcularCirculo(double)
            El ingreso de los datos como la visualización se deberán realizar desde el método Main().*/
            Console.Title = "Ejercicio 14";
            double lado;
            double areaCuadrado;
            double ancho;
            double altura;
            double areaTriangulo;
            double radio;
            double areaCirculo;

            Console.WriteLine("Ingrese un lado del cuadrado.");
            while (!double.TryParse(Console.ReadLine(), out lado))
            {
                Console.WriteLine("ERROR");

            }
            areaCuadrado = CalculoDeArea.CalcularCuadrado(lado);
            Console.WriteLine("Area del cuadrado {0}\n", areaCuadrado);


            Console.WriteLine("Ingrese ancho del triangulo.");
            while (!double.TryParse(Console.ReadLine(), out ancho))
            {
                Console.WriteLine("ERROR");

            }
            Console.WriteLine("Ingrese altura del triangulo.");
            while (!double.TryParse(Console.ReadLine(), out altura))
            {
                Console.WriteLine("ERROR");

            }
            areaTriangulo = CalculoDeArea.CalcularTriangulo(ancho, altura);
            Console.WriteLine("Area del triangulo {0}\n", areaTriangulo);


            Console.WriteLine("Ingrese radio del circulo.");
            while (!double.TryParse(Console.ReadLine(), out radio))
            {
                Console.WriteLine("ERROR");
            }
            areaCirculo = CalculoDeArea.CalcularCirculo(radio);
            Console.WriteLine("Area del circulo {0}\n", areaCirculo);

            Console.ReadKey();
        }
    }
}
