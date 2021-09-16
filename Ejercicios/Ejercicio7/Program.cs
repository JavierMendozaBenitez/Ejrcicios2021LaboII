using System;

namespace Ejercicio7
{
    class Program
    {
        static void Main(string[] args)
        {
            /*7. Hacer un programa que pida por pantalla la fecha de nacimiento de una persona (día, mes y año) y
            calcule el número de días vividos por esa persona hasta la fecha actual (tomar la fecha del sistema
            con DateTime.Now).
            Nota: Utilizar estructuras selectivas. Tener en cuenta los años bisiestos.*/
            Console.Title = "Ejercicio 7";
            DateTime fechaIng;
            /*TimeSpan dias;
            DateTime horaActual = DateTime.Now;
            Console.WriteLine($"{horaActual}");
            Console.WriteLine("Ingrese fecha de nacimiento ####-##-##");

            while(!DateTime.TryParse(Console.ReadLine(), out fechaIng))
            {
                Console.WriteLine("ERROR.");
            }

            dias = DateTime.Now - fechaIng;
            Console.WriteLine("Dias vividos {0}", dias);
            Console.WriteLine($"Fecha ingresada {fechaIng}");*/
            string fechaNacimiento;
            TimeSpan diasVividos;

            Console.WriteLine("Ingrese dia, mes y año de nacimiento: (mm/dd/aaaa)?");
            fechaNacimiento = Console.ReadLine();

            diasVividos = DateTime.Now - Convert.ToDateTime(fechaNacimiento);

            Console.WriteLine(string.Format("Dias vividos: {0}", diasVividos.Days));
            Console.ReadKey();


            Console.ReadKey();
        }
    }
}
