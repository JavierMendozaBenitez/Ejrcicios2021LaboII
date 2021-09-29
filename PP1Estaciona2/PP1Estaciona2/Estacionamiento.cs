using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PP1Estaciona2
{
    public class Estacionamiento
    {
        private int capacidadEstacionamiento;
        private static Estacionamiento estacionamiento;
        private List<Vehiculo> listadoVehiculo;
        private string nombre;

        private Estacionamiento(string nombre, int capacidad)
        {
            this.nombre = nombre;
            this.capacidadEstacionamiento = capacidad;
            this.listadoVehiculo = new List<Vehiculo>();
        }

        public static Estacionamiento GetEstacionamiento(string nombre, int capacidad)
        {
            if (Estacionamiento.estacionamiento is null)
            {
                Estacionamiento.estacionamiento = new Estacionamiento(nombre, capacidad);
                return Estacionamiento.estacionamiento;
            }
            else
            {
                Estacionamiento.estacionamiento.capacidadEstacionamiento = capacidad;
                return Estacionamiento.estacionamiento;
            }
        }

        public List<Vehiculo> ListadoVehiculos
        {
            get
            {
                return this.listadoVehiculo;
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

            sb.AppendLine("Nombre Estacionamiento: " + this.Nombre);
            sb.AppendLine(vehiculo.ToString());
            sb.AppendLine(vehiculo.HoraEgreso.ToString());
            sb.AppendLine(vehiculo.CostoEstadia.ToString());
            
            return sb.ToString();
        }

        public static bool operator ==(Estacionamiento estacionamiento, Vehiculo vehiculo)
        {
            bool returAux = false;

            if (Estacionamiento.estacionamiento.ListadoVehiculos.Count > 0)
            {
                foreach (Vehiculo vehiAux in estacionamiento.ListadoVehiculos)
                {
                    if (vehiAux == vehiculo)
                    {
                        returAux = true;
                        break;
                    }
                }
            }
            
            return returAux;
        }
        public static bool operator !=(Estacionamiento estacionamiento, Vehiculo vehiculo)
        {
            return !(estacionamiento == vehiculo);
        }

        public static bool operator +(Estacionamiento estacionamiento, Vehiculo vehiculo)
        {
            if (estacionamiento.ListadoVehiculos.Count < estacionamiento.capacidadEstacionamiento && estacionamiento != vehiculo)
            {
                Estacionamiento.estacionamiento.listadoVehiculo.Add(vehiculo);
                return true;
            }
            return false;
        }

        public static bool operator -(Estacionamiento estacionamiento, Vehiculo vehiculo)
        {
            if(estacionamiento == vehiculo)
            {
                vehiculo.HoraEgreso = DateTime.Now;
                Estacionamiento.estacionamiento.listadoVehiculo.Remove(vehiculo);
                return true;
            }
            return false;
        }

    }
}
