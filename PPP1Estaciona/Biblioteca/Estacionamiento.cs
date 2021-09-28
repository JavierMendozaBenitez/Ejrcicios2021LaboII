using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Biblioteca
{
    public class Estacionamiento
    {
        private int capacidadEstacionamiento;
        private static Estacionamiento estacionamiento;
        private List<Vehiculo> listadoVehiculos;
        private string nombre;

        private Estacionamiento(string nombre, int capacidad)
        {
            this.listadoVehiculos = new List<Vehiculo>();
            this.nombre = nombre;
            this.capacidadEstacionamiento = capacidad;
        }
        public static Estacionamiento GetEstacionamiento(string nombre, int capacidad)
        {
            if(Estacionamiento.estacionamiento is null)
            {
                Estacionamiento.estacionamiento = new Estacionamiento(nombre, capacidad);
            }
            else
            {
                Estacionamiento.estacionamiento.capacidadEstacionamiento = capacidad;
            }
            return Estacionamiento.estacionamiento;
        }

        public List<Vehiculo> ListadoVehiculos
        {
            get
            {
                return this.listadoVehiculos;
            }
        }

        public string Nombre
        {
            get
            {
                return this.nombre;
            }
        }

        public string InformarSalida(Vehiculo vehiculo)
        {
            StringBuilder sb = new StringBuilder();

            sb.AppendLine("Nombre del estacionamiento: " + this.nombre);

            sb.AppendLine("Los datos del vehiculo son: \n" + vehiculo.ToString());
            sb.AppendLine("Hora de salida: " + vehiculo.HoraEgreso);
            sb.AppendLine("El cargo de estacionamiento: " + vehiculo.CostoEstadia.ToString());

            return sb.ToString();            
        }

        public static bool operator == (Estacionamiento estacionamiento, Vehiculo vehiculo)
        {
            bool retorno = false;

            foreach (Vehiculo vehiculoAux in estacionamiento.ListadoVehiculos)
            {
                if(vehiculoAux == vehiculo)
                {
                    retorno = true;
                }
            }
            return retorno;
        }
        public static bool operator !=(Estacionamiento estacionamiento, Vehiculo vehiculo)
        {
            return !(estacionamiento == vehiculo);
        }

        public static bool operator + (Estacionamiento estacionamiento, Vehiculo vehiculo)
        {
            bool retorno = false;

            if(estacionamiento.ListadoVehiculos.Count < estacionamiento.capacidadEstacionamiento && estacionamiento != vehiculo)
            {
                Estacionamiento.estacionamiento.ListadoVehiculos.Add(vehiculo);
                retorno = true;
            }            
            return retorno;
        }

        public static bool operator -(Estacionamiento estacionamiento, Vehiculo vehiculo)
        {
            bool retorno = false;
            if (estacionamiento == vehiculo)
            {
                vehiculo.HoraEgreso = DateTime.Now;
                Estacionamiento.estacionamiento.listadoVehiculos.Remove(vehiculo);
                retorno = true;
            }
            return retorno;
        }
    }
}
