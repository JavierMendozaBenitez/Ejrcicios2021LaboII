using System;
using Entidades;

namespace Clase3
{
    class Program
    {
        static void Main(string[] args)
        {
            //Persona p = new Persona();//este es un constructor por defecto. Llama a la clase aunque no exista un constructor

            //Persona.tipo = "Humanoide";//constructor estatico, afecta a todos los objetos

            Persona p1 = new Persona("Ale Dionicio", 30);//p1 es el objeto, new asigna memoria, Persona es el contructor que trae argumentos
            Persona p2 = new Persona("Yamila Bongioanni", 31);
            Persona p3 = new Persona("Mau Cerizza", 32);
            Persona p4 = p3;//copias la referencia de memoria, puntero
            Persona p5 = new Persona("Mau Cerizza", 32);

            Console.WriteLine(object.ReferenceEquals(p2, p3));//chequeas si apuntan al mismo lugar o a otras cosas
            Console.WriteLine(object.ReferenceEquals(p4, p3));
            Console.WriteLine(object.ReferenceEquals(p5, p3));
            Console.WriteLine(p3 is string);
            Console.WriteLine(p3 is Persona);
            Console.WriteLine(p3 is object);


            Console.WriteLine("{0} tiene {1} años y es {2}", p1.GetNombre(), p1.GetEdad(), p1.GetTipo());
            Console.WriteLine("{0} tiene {1} años y es {2}", p2.GetNombre(), p2.GetEdad(), p2.GetTipo());
            Console.WriteLine("{0} tiene {1} años y es {2}", p3.GetNombre(), p3.GetEdad(), p3.GetTipo());
            //p4.SetNombre("Fede");
            //Console.WriteLine("{0} tiene {1} años y es {2}", p3.GetNombre(), p3.GetEdad(), p3.GetTipo());

            /*if (Persona.AlterarObjetoRecibido(p3))
                Console.WriteLine("{0} tiene {1} años y es {2}", p3.GetNombre(), p3.GetEdad(), p3.GetTipo());*/

            Console.WriteLine(Persona.AlterarObjetoRecibido(null));

            if (Persona.AlterarObjetoRecibido(p3))
                Console.WriteLine("{0} tiene {1} años y es {2}", p3.GetNombre(), p3.GetEdad(), p3.GetTipo());


             Console.ReadKey();
        }
    }
}
