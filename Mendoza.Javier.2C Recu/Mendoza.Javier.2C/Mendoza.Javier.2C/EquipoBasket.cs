using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Mendoza.Javier._2C
{
    public class EquipoBasket: Equipo
    {
        public enum Eliga {NBA, Euroleague, ACB};
        private Eliga liga;

        public EquipoBasket(string nombre)
            : this(nombre, Eliga.NBA) { }

        public EquipoBasket(string nombre, Eliga liga)
            : base(nombre)
        {
            this.liga = liga;
        }

        public override int GetDificultad()
        {
            int rm;
            Random ramdom = new Random();

            if (this.liga.Equals(Eliga.NBA))
            {
                return ramdom.Next(8, 10);
            }
            else if (this.liga.Equals(Eliga.Euroleague))
            {
                return ramdom.Next(5, 10);
            }
            else
            {
                return ramdom.Next(1, 7);
            }
        }

        protected override string MostrarDatos()
        {
            StringBuilder sb = new StringBuilder();

            sb.AppendLine(base.Nombre + "Basket- ");

            return sb.ToString();
        }

        public override string ToString()
        {
            return this.MostrarDatos();
        }
    }
}
