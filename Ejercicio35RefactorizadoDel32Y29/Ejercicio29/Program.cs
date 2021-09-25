using System;
using Entidades;

namespace Ejercicio32RefactorizadoDel29
{
    class Program
    {
        static void Main(string[] args)
        {

            Jugador j1 = new Jugador(36666666, "Javier", 200, 400);
            Jugador j2 = new Jugador(77777777, "Pedro", 300, 600);
            Jugador j3 = new Jugador(88888888, "Mario", 800, 500);

            DirectorTecnico dt0 = new DirectorTecnico(11111111, "JuanDT", Convert.ToDateTime("11/23/1992".ToString()));
            DirectorTecnico dt1 = new DirectorTecnico(11111111, "JuanDT", Convert.ToDateTime("11/23/1992".ToString()));
            DirectorTecnico dt2 = new DirectorTecnico(22222222, "PabloDT",Convert.ToDateTime("12/05/1989".ToString()));
            DirectorTecnico dt3 = new DirectorTecnico(33333333, "RamonDT",Convert.ToDateTime("05/09/1999".ToString()));

            Equipo equipo = new Equipo(2, "River");

    
            if(dt0 == dt1)
            {
                Console.WriteLine("El dto y dt1 son iguales\nDt0: {0}\nDt1: {1}\n", dt0.MostrarDatos(), dt1.MostrarDatos());
            }
            else
            {
                Console.WriteLine("No son el mismo det.\nDt1: {0}\nDt2: {1}\n", dt0.MostrarDatos(), dt1.MostrarDatos());
            }


            if (dt2 == dt3)
            {
                Console.WriteLine("El dt2 y dt3 son iguales\nDt2: {0}\nDt3: {1}\n", dt2.MostrarDatos(), dt3.MostrarDatos());
            }
            else
            {
                Console.WriteLine("No son el mismo det.\nDt2: {0}\nDt3: {1}\n", dt2.MostrarDatos(), dt3.MostrarDatos());
            }

            if (equipo + j1)
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
