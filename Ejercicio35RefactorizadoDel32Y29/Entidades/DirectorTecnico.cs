using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public class DirectorTecnico : Persona
    {
        private DateTime fechaNacimiento;

        private DirectorTecnico(long dni, string nombre): base (dni, nombre)
        {
        }

        public DirectorTecnico(long dni, string nombre, DateTime fechaNacimiento): base(dni, nombre)
        {
            this.FechaNacimiento = fechaNacimiento;
        }

        public DateTime FechaNacimiento
        {
            get
            {
                return this.fechaNacimiento;
            }
            set
            {
                this.fechaNacimiento = value;
            }
        }

        public string MostrarDatos()
        {
            StringBuilder sb = new StringBuilder();

            sb.AppendLine("Dni: " + base.Dni);
            sb.AppendLine("Nombre: " + base.Nombre);
            sb.AppendLine("Fecha de nacimiento: " + this.FechaNacimiento);

            return sb.ToString();
        }

        public static bool operator ==(DirectorTecnico dt1, DirectorTecnico dt2)
        {
            return dt1.Nombre == dt2.Nombre && dt1.FechaNacimiento == dt2.FechaNacimiento;
        }
        public static bool operator != (DirectorTecnico dt1, DirectorTecnico dt2)
        {
            return !(dt1 == dt2);
        }
    }
}
