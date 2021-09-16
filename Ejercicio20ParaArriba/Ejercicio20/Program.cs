using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Billetes;

namespace Ejercicio20
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Title = "Ejercicio 20";
           
            Euro billeteEuro = 1;
            Pesos billetePesos = (Pesos)billeteEuro;
            Dolar billeteDolar = 100;

            Pesos billetePesos2 = 500;
            Pesos billetePesos3 = 500;

            Dolar billeteDolar2 = 700;
            Dolar billeteDolar3 = 700;

            Euro billeteEuro2 = 800;
            Euro billeteEuro3 = 800;


            Console.WriteLine(billeteEuro.GetCantidad);
            Console.WriteLine(billetePesos.GetCantidad);
            Console.WriteLine(billeteDolar.GetCantidad);
            billetePesos = (Pesos)billeteDolar;
            Console.WriteLine("Dolares convertidos a pesos {0}", billetePesos.GetCantidad);
            // billetePesos = billetePesos2 + billetePesos3;

            Console.Write("Operador == ");
            Console.WriteLine(billetePesos2 == billetePesos3);

            Console.Write("Operador != ");
            Console.WriteLine(billetePesos2 != billetePesos3);

            billetePesos = billetePesos2 - billeteEuro3;
            Console.Write("Operador - ");
            Console.WriteLine(billetePesos.GetCantidad);

            billetePesos = billetePesos2 + billeteEuro3;
            Console.Write("Operador + ");
            Console.WriteLine(billetePesos.GetCantidad);

            Console.ReadKey();
        }
    }
}
