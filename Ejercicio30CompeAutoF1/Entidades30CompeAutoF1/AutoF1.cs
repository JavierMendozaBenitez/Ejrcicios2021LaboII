using System;
using System.Text;

namespace Entidades30CompeAutoF1
{
    public class AutoF1
    {
        private short cantidadConbustible;
        private bool enCompetencia;
        private string escuderia;
        private short numero;
        private short vueltasRestantes;

        public AutoF1(short numero, string escuderia)
        {
            this.numero = numero;
            this.escuderia = escuderia;
            this.cantidadConbustible = 0;
            this.vueltasRestantes = 0;
            this.enCompetencia = false;
        }

        public short GetCantidadCombustible
        {
            get
            {
                return this.cantidadConbustible;
            }
        }

        public short SetCantidadCombustible
        {
            set
            {
               this.cantidadConbustible = value;
            }
        }

        public bool GetEnCompetencia
        {
            get
            {
                return this.enCompetencia;
            }
        }

        public bool SetEnCompetencia
        {
            set
            {
                this.enCompetencia = value;
            }
        }

        public short GetVueltasRestantes
        {
            get
            {
                return this.vueltasRestantes;
            }
        }

        public short SetVueltasRestantes
        {
            set
            {
                this.vueltasRestantes = value;
            }
        }


        public string MostrarDatos()
        {
            StringBuilder sb = new StringBuilder();
            sb.AppendLine("Cantidad de combustible " + this.GetCantidadCombustible);
            sb.AppendLine("En competencia? " + this.GetEnCompetencia);
            sb.AppendLine("Escuderia " + this.escuderia);
            sb.AppendLine("Numero " + this.numero);
            sb.AppendLine("Vueltas restantes: " + this.GetVueltasRestantes);

            return sb.ToString();
        }

        public static bool operator == (AutoF1 a1, AutoF1 a2)
        {
            return a1.escuderia == a2.escuderia && a1.escuderia == a2.escuderia;
        }

        public static bool operator !=(AutoF1 a1, AutoF1 a2)
        {
            return !(a1 == a2);
        }
    }
}
