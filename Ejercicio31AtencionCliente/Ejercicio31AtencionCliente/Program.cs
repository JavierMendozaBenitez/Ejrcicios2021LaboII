using System;
using Entidades31PuestoAtencion;

namespace Ejercicio31AtencionCliente
{
    class Program
    {
        static void Main(string[] args)
        {
            Negocio super = new Negocio("Chino");
            Cliente client1 = new Cliente(1, "Javier");
            Cliente client2 = new Cliente(2, "Pedro");
            Cliente client3 = new Cliente(3, "Ana");

            //Muestro negocio
            Console.WriteLine("Clientes pendientes {0}", super.ClientesPendientes);

            //Agrego clientes
            Console.WriteLine("Clientes agregados {0}", super + client1);
            //Datos del cliente agregado
            Console.WriteLine("Nombre del cliente agregado {0}", client1.Nombre);
            
            //Muestro negocio
            Console.WriteLine("Clientes pendientes {0}", super.ClientesPendientes);
            //Agrego clientes
            Console.WriteLine("Clientes agregados {0}", super + client2);
            //Datos del cliente agregado
            Console.WriteLine("Nombre del cliente agregado {0}", client2.Nombre);
            Console.WriteLine("Numero del cliente agregado {0}", client2.Numero);
            //Agrego clientes
            Console.WriteLine("Clientes agregados {0}", super + client3);
            //Datos del cliente agregado
            Console.WriteLine("Nombre del cliente agregado {0}", client3.Nombre);
            Console.WriteLine("Numero del cliente agregado {0}", client3.Numero);
            //Muestro negocio
            Console.WriteLine("Clientes pendientes {0}", super.ClientesPendientes);
            //Agrego uno que ya está en la fila
            if (!(super + client3))
            {
                Console.WriteLine("Cliente 3 ya esta en la cola");
            }


            while (~super)
            {
                Console.WriteLine("Cliente en espera {0}", super.ClientesPendientes);
            }


            Console.ReadKey();
        }
    }
}
