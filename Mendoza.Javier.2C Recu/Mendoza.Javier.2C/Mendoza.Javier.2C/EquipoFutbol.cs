using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Mendoza.Javier._2C
{
    public class EquipoFutbol: Equipo
    {
        private bool jugadorEstrellas;

        public EquipoFutbol(string nombre)
            : this(nombre, false) { }

        public EquipoFutbol(string nombre, bool jugadoresEstrellas)
            : base(nombre)
        {
            this.jugadorEstrellas = jugadoresEstrellas;
        }

        public override int GetDificultad()
        {
            int rm;
            Random ramdom = new Random();

            rm = ramdom.Next(7, 10);

            if (this.jugadorEstrellas)
            {
                return rm * 2;
            }
            return rm;
        }

        protected override string MostrarDatos()
        {
            StringBuilder sb = new StringBuilder();

            sb.AppendLine(base.Nombre + "Futbol- ");

            return sb.ToString();
        }

        public override string ToString()
        {
            return this.MostrarDatos();
        }
    }
}
