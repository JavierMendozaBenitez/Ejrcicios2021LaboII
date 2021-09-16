using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Entidades21;

namespace Ejercicio21
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Title = "Ejercicio 21";

            Celsius termometroCelsius = 1;
            Kelvin termometroKelvin = (Kelvin)termometroCelsius;
            Fahrenheit termometroFahrenheit = 100;

            Console.ReadKey();

            Kelvin termometroKelvin2 = 500;
            Kelvin termometroKelvin3 = 500;

            Fahrenheit termometroFahrenheit2 = 700;
            Fahrenheit termometroFahrenheit3 = 700;

            Celsius termometroCelsius2 = 800;
            Celsius termometroCelsius3 = 800;


            Console.WriteLine(termometroCelsius.GetTemperatura);
            Console.WriteLine(termometroKelvin.GetTemperatura);
            Console.WriteLine(termometroFahrenheit.GetTemperatura);
            termometroKelvin = (Kelvin)termometroFahrenheit;
            Console.WriteLine("Dolares convertidos a pesos {0}", termometroKelvin.GetTemperatura);

            Console.Write("Operador == ");
            Console.WriteLine(termometroKelvin2 == termometroKelvin3);

            Console.Write("Operador != ");
            Console.WriteLine(termometroKelvin2 != termometroKelvin3);

            termometroKelvin = termometroKelvin2 - termometroCelsius3;
            Console.Write("Operador - ");
            Console.WriteLine(termometroKelvin.GetTemperatura);

            termometroKelvin = termometroKelvin2 + termometroCelsius3;
            Console.Write("Operador + ");
            Console.WriteLine(termometroKelvin.GetTemperatura);

            Console.ReadKey();
        }
    }
}
