using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades30CompeAutoF1
{
    public class VehiculoDeCarrera
    {
        private short cantidadConbustible;
        private bool enCompetencia;
        private string escuderia;
        private short numero;
        private short vueltasRestantes;

        public VehiculoDeCarrera(short numero, string escuderia)
        {
            this.Numero = numero;
            this.Escuderia = escuderia;
        }

        public short CantidadCombustible
        {
            get
            {
                return this.cantidadConbustible;
            }
            set
            {
                this.cantidadConbustible = value;
            }
        }

        public bool EnCompetencia
        {
            get
            {
                return this.enCompetencia;
            }
            set
            {
                this.enCompetencia = value;
            }
        }
        public string Escuderia
        {
            get
            {
                return this.escuderia;
            }
            set
            {
                this.escuderia = value;
            }
        }
        public short Numero
        {
            get
            {
                return this.numero;
            }
            set
            {
                this.numero = value;
            }
        }
        public short VueltasRestantes
        {
            get
            {
                return this.vueltasRestantes;
            }
            set
            {
                this.vueltasRestantes = value;
            }
        }

        public string MostrarDatos()
        {
            StringBuilder sb = new StringBuilder();
            sb.AppendLine("Cantidad de combustible " + this.CantidadCombustible);
            sb.AppendLine("En competencia? " + this.EnCompetencia);
            sb.AppendLine("Escuderia " + this.Escuderia);
            sb.AppendLine("Numero " + this.Numero);
            sb.AppendLine("Vueltas restantes: " + this.VueltasRestantes);

            return sb.ToString();
        }

        public static bool operator ==(VehiculoDeCarrera v1, VehiculoDeCarrera v2)
        {
            return v1.Numero == v2.Numero && v1.Escuderia == v2.Escuderia;
        }

        public static bool operator !=(VehiculoDeCarrera v1, VehiculoDeCarrera v2)
        {
            return !(v1 == v2);
        }

    }
}
