using System;
using Entidades;

namespace Ejercicio29
{
    class Program
    {
        static void Main(string[] args)
        {

            Jugador j1 = new Jugador(36666666, "Javier", 200, 400);
            Jugador j2 = new Jugador(77777777, "Pedro", 300, 600);
            Jugador j3 = new Jugador(88888888, "Mario", 800, 500);

            Equipo equipo = new Equipo(2, "River");

    
            if(equipo + j1)
            {
                Console.WriteLine("Se agrego {0}", j1.MostrarDatos());
            }
            else
            {
                Console.WriteLine("No se pudo agregar.");
            }

            if (equipo + j2)
            {
                Console.WriteLine("Se agrego {0}", j2.MostrarDatos());
            }
            else
            {
                Console.WriteLine("No se pudo agregar.");
            }

            if (equipo + j3)
            {
                Console.WriteLine("Se agrego {0}", j3.MostrarDatos());
            }
            else
            {
                Console.WriteLine("No se pudo agregar.");
            }

            if (equipo + j1)
            {
                Console.WriteLine("Se agrego {0}", j1.MostrarDatos());
            }
            else
            {
                Console.WriteLine("No se pudo agregar j1.");
            }

            Console.ReadKey();
        }
    }
}
