using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CentralitaHerencia
{
    public class Local: Llamada
    {
        protected float costo;

        public Local(Llamada llamada, float costo)
            : this(llamada.NroOrigen, llamada.Duracion, llamada.NroDestino, costo)
        {}

        public Local(string origen, float duracion, string destino, float costo)
            : base (duracion, destino, origen)
        {
            this.costo = costo;
        }

        private float CalcularCosto()
        {
            return base.Duracion * this.costo;
        }
                
        public override float CostoLlamada
        {
            get
            {
                return this.CalcularCosto();
            }
        }

        public override bool Equals(object obj)
        {
            return this.GetType() == obj.GetType();
            //return obj is Local;
        }

        protected override string Mostrar()
        {
            StringBuilder sb = new StringBuilder();

            sb.AppendLine(base.Mostrar());
            sb.AppendLine("Costo de llamada: " + CostoLlamada);

            return sb.ToString();
        }

        public override string ToString()
        {
            return this.Mostrar();
        }
    }
}
