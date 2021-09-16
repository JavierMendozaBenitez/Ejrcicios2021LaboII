using System;

namespace Ejercicio8
{
    class Program
    {
        static void Main(string[] args)
        {
            /*8. Por teclado se ingresa el valor hora, el nombre, la antigüedad (en años) y la cantidad de horas
            trabajadas en el mes de N empleados de una fábrica.
            Se pide calcular el importe a cobrar teniendo en cuenta que el total (que resulta de multiplicar el
            valor hora por la cantidad de horas trabajadas), hay que sumarle la cantidad de años trabajados
            multiplicados por $ 150, y al total de todas esas operaciones restarle el 13% en concepto de
            descuentos.
            Mostrar el recibo correspondiente con el nombre, la antigüedad, el valor hora, el total a cobrar en
            bruto, el total de descuentos y el valor neto a cobrar de todos los empleados ingresados.
            Nota: Utilizar estructuras repetitivas y selectivas.*/
            Console.Title = "Ejercicio 8";
            int continuar = 1;
            int antiguedad;
            int cantHoras;
            float sueldoBruto;
            float sueldoNeto;
            float desc;
            float valorHora;
            string nombre;
            do
            {
                Console.WriteLine("Ingrese el valor hora.");
                while(!float.TryParse(Console.ReadLine(), out valorHora))
                {
                    Console.WriteLine("ERROR. Reingrese hora");
                }

                Console.WriteLine("Ingrese el nombre.");
                nombre = Console.ReadLine();

                Console.WriteLine("Ingrese la antigüedad en años.");
                while (!int.TryParse(Console.ReadLine(), out antiguedad))
                {
                    Console.WriteLine("ERROR. Reingrese antigüedad");
                }

                Console.WriteLine("Ingrese la cantidad horas trabajadas en el mes.");
                while (!int.TryParse(Console.ReadLine(), out cantHoras))
                {
                    Console.WriteLine("ERROR. Reingrese cantidad horas trabajadas");
                }

                sueldoBruto = ((float)cantHoras * valorHora) + (antiguedad * 150);   
                desc = 13 * sueldoBruto / 100;    
                sueldoNeto = sueldoBruto - desc;                

                Console.WriteLine("Continuar? SI 1 NO 2");
                int.TryParse(Console.ReadLine(), out continuar);


                Console.WriteLine($"Nombre {nombre}.\nAntigüedad {antiguedad}.\nValor hora {valorHora}.\nSueldo bruto {sueldoBruto}.\nDescuentos {desc}.\nSueldo neto {sueldoNeto}.");
                
            } while (continuar == 1);

                       
            Console.ReadKey();
        }
    }
}
