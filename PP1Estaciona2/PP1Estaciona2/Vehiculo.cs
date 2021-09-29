using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PP1Estaciona2
{
    public abstract class Vehiculo
    {
        private DateTime horaEgreso;
        private DateTime horaIngreso;
        private string patente;
        public enum EVehiculos {Automovil, Moto}

        public abstract double CostoEstadia { get; }
        public abstract string Descripcion { get; }

        public DateTime HoraEgreso
        {
            get
            {
                return this.horaEgreso;
            }
            set
            {
                if(value > this.HoraIngreso)
                {
                    this.horaEgreso = value;
                }
            }
        }

        public DateTime HoraIngreso
        {
            get
            {
                return this.horaIngreso;
            }
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

        public Vehiculo(string patente, DateTime horaIngreso)
        {
            this.Patente = patente;
            this.horaIngreso = horaIngreso;
        }

        private bool ValidarPatente(string patente)
        {
            bool retorno = false;

            if (patente.Length >= 6 && patente.Length < 8)
            {
                retorno = true; 
            }
            return retorno;
        }

        protected virtual double CargoDeEstacionamiento()
        {
            return (this.HoraEgreso - this.HoraIngreso).TotalHours;
        }

        protected virtual string MostrarDatos()
        {
            StringBuilder sb = new StringBuilder();

            sb.AppendLine("Patente: " + this.Patente);
            sb.AppendLine("Hora de Ingreso: " + this.HoraIngreso);

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
