using System;
using CentralitaHerencia;

namespace Test
{
    class Program
    {
        static void Main(string[] args)
        {
            // Mi central
            Centralita c = new Centralita("Fede Center"); // Mis 4 llamadas
            Local l1 = new Local("Bernal", 30, "Rosario", 2.65f);
            Provincial l2 = new Provincial("Morón", Provincial.Franja.Franja_1, 21, "Bernal"); 
            Local l3 = new Local("Lanús", 45, "San Rafael", 1.99f);
            Provincial l4 = new Provincial(Provincial.Franja.Franja_3, l2); // Las llamadas se irán registrando en la Centralita.
            //Provincial l4 = new Provincial("Varela", Provincial.Franja.Franja_2, 23, "Quilmes");                                                                 // La centralita mostrará por pantalla todas las llamadas según las vaya registrando.

            try
            {
                Console.WriteLine("Agrego l1 con el + {0}", c + l1);
                Console.WriteLine("Agrego l2 con el + {0}", c + l2);
                Console.WriteLine("Agrego l3 con el + {0}", c + l3);
                Console.WriteLine("Agrego l4 con el + {0}", c + l4);
            }
            catch (CentralitaException ex)
            {
                Console.WriteLine($"Error: {ex.Message}, producido en {ex.NombreClase}, al momento de {ex.NombreMetodo}");
            }

            c.OrdenarLlamadas();
            Console.WriteLine(c.ToString()); 
            
            Console.ReadKey();
        }
    }
}
