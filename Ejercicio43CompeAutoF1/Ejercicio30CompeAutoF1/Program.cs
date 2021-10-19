using System;
using Entidades30CompeAutoF1;

namespace Ejercicio30CompeAutoF1
{
    class Program
    {
        static void Main(string[] args)
        {
            Competencia compeF1 = new Competencia(10, 2, Competencia.TipoCompetencia.F1);

            AutoF1 auto1 = new AutoF1(1, "Ferrari", 1000);
            AutoF1 auto2 = new AutoF1(2, "Ford", 2000);
            AutoF1 auto3 = new AutoF1(3, "Renault", 3000);

            //Competencia compeMoto = new Competencia(10, 2, Competencia.TipoCompetencia.MotoCross);

            MotoCross moto1 = new MotoCross(1, "Yamaha", 150);
            MotoCross moto2 = new MotoCross(2, "Harley", 200);
            MotoCross moto3 = new MotoCross(3, "Zanella", 300);



            try
            {
                //Agregar a la lista
                Console.WriteLine("Se agrega a la lista auto no existente: {0}\n\n", compeF1 + moto1);
            }
            catch(CompetenciaNoDisponibleException ex)
            {
                /*Exception exception = ex;
                do
                {
                    Console.WriteLine($"Error: {ex.Message}, producido en {ex.NombreClase}, al momento de {ex.NombreMetodo}\n\n");
                    Console.WriteLine(exception.Message, exception.InnerException);
                    exception = exception.InnerException;
                }
                while (!(exception is null));*/
                Console.WriteLine(ex.ToString());
                Console.WriteLine("\n\n------------------------------------------------\n\n");
                //throw new CompetenciaNoDisponibleException(ex.Message, ex.NombreClase, ex.NombreMetodo, ex);
                
            }




            //Preguntar si esta en la lista
            Console.WriteLine("Está en la lista auto1: {0}", compeF1 == auto1);

            //Agregar a la lista
            Console.WriteLine("Se agrega a la lista auto1: {0}", compeF1 + auto1);
            //Preguntar si esta en la lista
            Console.WriteLine("Está en la lista auto1: {0}", compeF1 == auto1);



            // Preguntar si esta en la lista
            Console.WriteLine("Está en la lista auto2: {0}", compeF1 == auto2);
            //Agregar a la lista
            Console.WriteLine("Se agrega a la lista auto2: {0}", compeF1 + auto2);
            //Preguntar si esta en la lista
            Console.WriteLine("Está en la lista auto2: {0}", compeF1 == auto2);



            // Preguntar si esta en la lista
            Console.WriteLine("Está en la lista auto3: {0}", compeF1 == auto3);
            //Agregar a la lista
            Console.WriteLine("Se agrega a la lista auto3: {0}", compeF1 + auto3);
            //Preguntar si esta en la lista
            Console.WriteLine("Está en la lista auto3: {0}", compeF1 == auto3);



            //Quitar de la lista
            Console.WriteLine("Quito auto1 :{0}", compeF1 - auto1);
            Console.WriteLine("Muestro auto1 \n{0}", auto1.MostrarDatos());
            //Agregar a la lista
            Console.WriteLine("Se agrega a la lista auto3: {0}", compeF1 + auto3);
            //muestro la lista sin auto1
            Console.WriteLine("Muestro lista \n{0}", compeF1.Mostrar());
            //Preguntar si esta en la lista
            Console.WriteLine("Está en la lista auto1 con ==: {0}", compeF1 == auto1);
            //Preguntar si esta en la lista
            Console.WriteLine("Está en la lista auto1 con !=: {0}", compeF1 != auto1);

            
            ////muestro esto para demostrar que no se cargo
            //Console.WriteLine("Está en la lista moto1: {0}", compeF1 == moto1);
            ////Agregar a la lista
            //Console.WriteLine("Se agrega a la lista moto1: {0}", compeF1 + moto1);
            ////Preguntar si esta en la lista
            //Console.WriteLine("Está en la lista moto1: {0}", compeF1 == moto1);
            //Console.WriteLine("MUESTRO COMPE \n{0}", compeF1.Mostrar());













            /*//Preguntar si esta en la lista
            Console.WriteLine("Está en la lista moto1: {0}", compeMoto == moto1);

            //Agregar a la lista
            Console.WriteLine("Se agrega a la lista moto1: {0}", compeMoto + moto1);
            //Preguntar si esta en la lista
            Console.WriteLine("Está en la lista moto1: {0}", compeMoto == moto1);

            // Preguntar si esta en la lista
            Console.WriteLine("Está en la lista moto2: {0}", compeMoto == moto2);
            //Agregar a la lista
            Console.WriteLine("Se agrega a la lista moto2: {0}", compeMoto + moto2);
            //Preguntar si esta en la lista
            Console.WriteLine("Está en la lista moto2: {0}", compeMoto == moto2);

            // Preguntar si esta en la lista
            Console.WriteLine("Está en la lista moto3: {0}", compeMoto == moto3);
            //Agregar a la lista
            Console.WriteLine("Se agrega a la lista moto3: {0}", compeMoto + moto3);
            //Preguntar si esta en la lista
            Console.WriteLine("Está en la lista moto3: {0}", compeMoto == moto3);

            //Quitar de la lista
            Console.WriteLine("Quito moto1 :{0}", compeMoto - moto1);
            Console.WriteLine("Muestro moto1 \n{0}", compeMoto.Mostrar());
            //Agregar a la lista
            Console.WriteLine("Se agrega a la lista moto3: {0}", compeMoto + moto3);
            //muestro la lista sin auto1
            Console.WriteLine("Muestro lista \n{0}", compeMoto.Mostrar());
            //Preguntar si esta en la lista
            Console.WriteLine("Está en la lista moto1 con ==: {0}", compeMoto == moto1);
            //Preguntar si esta en la lista
            Console.WriteLine("Está en la lista moto1 con !=: {0}", compeMoto != moto1);*/


            Console.ReadKey();
        }
    }
}
