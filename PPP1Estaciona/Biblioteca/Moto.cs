using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Biblioteca
{
    public sealed class Moto : Vehiculo
    {
        public enum ETipo { ciclomotor, Scooter, Sport}
        private ETipo tipo;
        private static double valorHora;

        static Moto()
        {
            Moto.valorHora = 100;
        }

        public Moto(string patente, DateTime horaIngreso, ETipo tipo)
            : base (patente, horaIngreso)
        {
            this.tipo = tipo;
        }

        public static double ValorHora
        {
            set
            {
                if (value > 0)
                {
                    Moto.valorHora = value;
                }
            }
        }

        protected override double CargoEstacionamiento()
        {
            return base.CargoEstacionamiento() * Moto.valorHora;
        }

        public override string Descripcion
        {
            get
            {
                return this.tipo.ToString();
            }
        }

        public override double CostoEstadia
        {
            get
            {
                return this.CargoEstacionamiento();
            }
        }

        protected override string MostrarDatos()
        {
            StringBuilder sb = new StringBuilder();

            sb.AppendLine("****MOTO*****");
            sb.AppendLine("Tipo: " + this.Descripcion);
            sb.AppendLine(base.MostrarDatos());

            return sb.ToString();
        }

        public override string ToString()
        {
            return this.MostrarDatos();
        }
    }
}
