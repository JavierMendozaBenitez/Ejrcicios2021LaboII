using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades16
{
    public class Alumno
    {
        private byte nota1;//argumentos
        private byte nota2;
        private float notaFinal;
        public string apellido;
        public int legajo;
        public string nombre;

        public Alumno (string apellido, int legajo, string nombre)//metodo constructor, inicializa el objeto. Pero el ejercicio no lo pide
        {
            this.apellido = apellido;
            this.legajo = legajo;
            this.nombre = nombre;
        }
        public void CalcularFinal()//metodos
        {
            Random ran = new Random();
            
            if(this.nota1 >= 4 && this.nota2 >= 4)
            {
                this.notaFinal = ran.Next(4, 10);
            }
            else
            {
                this.notaFinal = -1;
            }
        }
        public void Estudiar(byte notaUno, byte notaDos)
        {
            this.nota1 = notaUno;
            this.nota2 = notaDos;
        }
        
        public string Mostrar()
        {
            StringBuilder sb = new StringBuilder();
            if (this.notaFinal != -1)
            {
                sb.AppendLine("Nota 1: "+this.nota1 +"\nNota 2: " + this.nota2 + 
                    "\nNota Final: " + this.notaFinal + "\nApellido: " + 
                    this.apellido + "\nLegajo: " + this.legajo + "\nNombre: " 
                    + this.nombre);
            }
            else
            {
                sb.AppendLine("Nota 1: " + this.nota1 + "\nNota 2: " + this.nota2 + 
                    "\nNota Final: Alumno desaprobado\nApellido: " + this.apellido + 
                    "\nLegajo: " + this.legajo + "\nNombre: " + this.nombre);
            }

            return sb.ToString();
        }
    }
}
