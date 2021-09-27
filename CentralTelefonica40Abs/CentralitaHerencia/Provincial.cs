using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CentralitaHerencia
{
    public class Provincial : Llamada
    {
        public enum Franja { Franja_1, Franja_2, Franja_3 }

        protected Franja franjaHoraria;

        public Provincial (Franja miFranja, Llamada llamada)
        : this(llamada.NroOrigen, miFranja, llamada.Duracion, llamada.NroDestino)
        { }

        public Provincial (string origen, Franja miFranja, float duracion, string destino)
            : base (duracion, destino, origen)
        {
            this.franjaHoraria = miFranja;
        }

        protected override string Mostrar()
        {
            StringBuilder sb = new StringBuilder();

            sb.AppendLine(base.Mostrar());
            sb.AppendLine("Costo de la llamada: " + this.CostoLlamada);
            sb.AppendLine("Franja horarria: " + this.franjaHoraria);

            return sb.ToString();
        }

        public override string ToString()
        {
            return this.Mostrar();
        }

        public override bool Equals(object obj)
        {
            return this.GetType() == obj.GetType();
            //return obj is Provincial;
        }

        private float CalcularCosto()
        {
            float retorno;

            switch (this.franjaHoraria)
            {
                case Franja.Franja_1:
                    retorno = (float)(base.Duracion * 0.99);
                    break;
                case Franja.Franja_2:
                    retorno = (float)(base.Duracion * 1.25);
                    break;
                default:
                    retorno = (float)(base.Duracion * 0.66);
                    break;
            }

            return retorno;
        }

        public override float CostoLlamada
        {
            get
            {
                return this.CalcularCosto();
            }
        }

    }
}
