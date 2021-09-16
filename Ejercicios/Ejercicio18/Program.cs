using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Geometría;

namespace PruebaGeometria
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Title = "Ejercicio 18";
           
            Punto punto1 = new Punto(5, 10);
            Punto punto2 = new Punto(7, 20);
            Punto punto3 = new Punto(2, 55);
            Punto punto4 = new Punto(10, 3);

            Rectangulo rec1 = new Rectangulo(punto1, punto3);
            Rectangulo rec2 = new Rectangulo(punto2, punto4);

            Console.WriteLine("Area {0}", rec1.Area());
            Console.WriteLine("Area {0}", rec2.Area());
            Console.WriteLine("Perimetro {0}", rec1.Perimetro());
            Console.WriteLine("Perimetro {0}", rec2.Perimetro());
            Console.WriteLine(MostrarDatos(rec1));
            Console.WriteLine(MostrarDatos(rec2));
            Console.ReadKey();
        }
        public static string MostrarDatos(Rectangulo rectan)
        {
            StringBuilder sb = new StringBuilder();

            sb.AppendLine("Area " + rectan.Area());
            sb.AppendLine("Perimetro " + rectan.Perimetro());

            return sb.ToString();
        }
    }
}
