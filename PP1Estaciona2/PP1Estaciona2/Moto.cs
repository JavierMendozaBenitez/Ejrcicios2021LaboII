using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PP1Estaciona2
{
    public sealed class Moto: Vehiculo
    {
        public enum ETipo { Ciclomotor, Scooter, Sport }
        private ETipo tipo;
        private static double valorHora;

        static Moto()
        {
            valorHora = 100;
        }

        public Moto(string patente, DateTime horaIngreso, ETipo tipo)
            : base(patente, horaIngreso)
        {
            this.tipo = tipo;
        }
        public override double CostoEstadia
        {
            get
            {
                return this.CargoDeEstacionamiento();
            }
        }
        public override string Descripcion
        {
            get
            {
                return this.tipo.ToString();
            }
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

        protected override double CargoDeEstacionamiento()
        {
            return base.CargoDeEstacionamiento() * Moto.valorHora;
        }

        protected override string MostrarDatos()
        {
            StringBuilder sb = new StringBuilder();

            sb.AppendLine("****MOTO****");

            sb.AppendLine("Tipo: " + this.Descripcion);
            sb.AppendLine("Valor Hora:  " + Moto.valorHora);
            sb.AppendLine(base.MostrarDatos());

            return sb.ToString();
        }

        public override string ToString()
        {
            return MostrarDatos();
        }
    }
}
