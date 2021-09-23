using System;
using Entidades30CompeAutoF1;

namespace Ejercicio30CompeAutoF1
{
    class Program
    {
        static void Main(string[] args)
        {
            AutoF1 auto1 = new AutoF1(1, "Ferrari");
            AutoF1 auto2 = new AutoF1(2, "Ford");
            AutoF1 auto3 = new AutoF1(3, "Renault");
            Competencia compe = new Competencia(10, 2);

            //Preguntar si esta en la lista
            Console.WriteLine("Está en la lista auto1: {0}", compe == auto1);

            //Agregar a la lista
            Console.WriteLine("Se agrega a la lista auto1: {0}", compe + auto1);
            //Preguntar si esta en la lista
            Console.WriteLine("Está en la lista auto1: {0}", compe == auto1);

            // Preguntar si esta en la lista
            Console.WriteLine("Está en la lista auto2: {0}", compe == auto2);
            //Agregar a la lista
            Console.WriteLine("Se agrega a la lista auto2: {0}", compe + auto2);
            //Preguntar si esta en la lista
            Console.WriteLine("Está en la lista auto2: {0}", compe == auto2);

            // Preguntar si esta en la lista
            Console.WriteLine("Está en la lista auto3: {0}", compe == auto3);
            //Agregar a la lista
            Console.WriteLine("Se agrega a la lista auto3: {0}", compe + auto3);
            //Preguntar si esta en la lista
            Console.WriteLine("Está en la lista auto3: {0}", compe == auto3);

            //Quitar de la lista
            Console.WriteLine("Quito auto1 :{0}", compe - auto1);
            Console.WriteLine("Muestro auto1 \n{0}", auto1.MostrarDatos());
            //Agregar a la lista
            Console.WriteLine("Se agrega a la lista auto3: {0}", compe + auto3);
            //muestro la lista sin auto1
            Console.WriteLine("Muestro lista \n{0}", compe.Mostrar());
            //Preguntar si esta en la lista
            Console.WriteLine("Está en la lista auto1 con ==: {0}", compe == auto1);
            //Preguntar si esta en la lista
            Console.WriteLine("Está en la lista auto1 con !=: {0}", compe != auto1);


            Console.ReadKey();
        }
    }
}
