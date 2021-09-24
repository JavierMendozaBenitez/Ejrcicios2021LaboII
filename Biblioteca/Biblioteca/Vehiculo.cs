using System;
using System.Text;

namespace Biblioteca
{
    public abstract class Vehiculo
    {
        private DateTime horaEgreso;
        private DateTime horaIngreso;
        private string patente;

        public enum EVehiculos
        {
            Automovil,
            Moto
        }

        public Vehiculo(string patente, DateTime horaIngreso)
        {
            this.Patente = patente;
            this.horaIngreso = horaIngreso;
        }

        private bool ValidarPatente(string patente)
        {
            if (patente.Length > 5 && patente.Length < 8)
            {
                return true;
            }
            return false;
        }

        public string Patente
        {
            get
            {
                return this.patente;
            }
            set
            {
                if (ValidarPatente(value))
                {
                    this.patente = value;
                }
            }
        }

        public abstract string Descripcion { get; }

        public abstract double CostoEstadia { get; }

        public DateTime HoraIngreso
        {
            get
            {
                return this.horaIngreso;
            }
        }

        public DateTime HoraEgreso
        {
            get
            {
                return this.HoraEgreso;
            }
            set
            {
                if (value > this.horaIngreso)
                {
                    this.HoraEgreso = value;
                }
            }
        }        

        protected double CargoEstacionamiento()
        {
            return (double)(HoraEgreso.Hour - HoraIngreso.Hour);
        }

        protected string MostrarDatos()
        {
            StringBuilder sb = new StringBuilder();

            sb.AppendLine("Patente " + this.Patente);
            sb.AppendLine("Hora de ingreso " + this.HoraIngreso);

            return sb.ToString();
        }

        public static bool operator == (Vehiculo v1, Vehiculo v2)
        {
            return v1.Patente == v2.Patente;
        }

        public static bool operator !=(Vehiculo v1, Vehiculo v2)
        {
            return !(v1 == v2);
        }
    }
}
