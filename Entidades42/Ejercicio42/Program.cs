using System;
using Entidades42;

namespace Ejercicio42
{   
    class Program
    {
        static void Main(string[] args)
        {
            try
            {
                OtraClase otraClase = new OtraClase();
                otraClase.MiMetodoDeInstancia();
            }
            catch(MiExcepcion ex)
            {
                Exception exception = ex;
                do
                {
                    Console.WriteLine(exception.Message);
                    exception = exception.InnerException;
                }
                while (!(exception is null));   
            } 

            Console.ReadKey();
        }
    }
}
