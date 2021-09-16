using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio15
{
    public static class Calculadora
    {
        public static double Calcular (double a, double b, string simbolo)
        {
            double resultado = 0;

            switch (simbolo)
            {
                case "-":
                    resultado = a - b;
                    break;
                case "+":
                    resultado = a + b;
                    break;
                case "*":
                    resultado = a * b;
                    break;
                case "/":
                    if(Calculadora.Validar(b))
                    {
                        resultado = a / b;
                    }
                    break;
                default:
                    break;
            }
            return resultado;
        }

        private static bool Validar (double b)
        {
            return (b != 0);
        }
    }
}
