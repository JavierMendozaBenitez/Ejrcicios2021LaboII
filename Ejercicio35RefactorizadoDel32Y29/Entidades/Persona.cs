using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public class Persona
    {
        private long dni;
        private string nombre;

        public Persona(long dni, string nombre)
        {
            this.Dni = dni;
            this.Nombre = nombre;
        }

        public Persona (string nombre)
            : this(0, nombre)
        {

        }

        public string MostrarDatos()
        {
            StringBuilder sb = new StringBuilder();

            sb.AppendLine("Dni: " + this.Dni);
            sb.AppendLine("Nombre: " + this.Nombre);

            return sb.ToString();
        }
        public long Dni
        {
            get
            {
                return this.dni;
            }
            set
            {
                this.dni = value;
            }
        }

        public string Nombre
        {
            get
            {
                return this.nombre;
            }
            set
            {
                this.nombre = value;
            }
        }
    }
}
