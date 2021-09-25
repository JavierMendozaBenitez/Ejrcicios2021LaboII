using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CentralitaHerencia
{
    public class Centralita
    {
        private List<Llamada> listaLlamadas;
        protected string razonSocial;

        public Centralita()
        {
            this.listaLlamadas = new List<Llamada>();
        }

        public Centralita (string nombreEmpresa)
            : this()
        {
            this.razonSocial = nombreEmpresa;
        }

        private float CalcularGanancia(Llamada.TipoLlamada tipo)
        {
            float acumulador = 0;

            foreach (Llamada llamada in Llamadas)
            {
                if(llamada is Local)
                {
                    if(tipo == Llamada.TipoLlamada.Local || tipo == Llamada.TipoLlamada.Todas)
                    {
                        acumulador += ((Local)llamada).CostoLlamada;
                    }
                }
                if (llamada is Provincial)
                {
                    if (tipo == Llamada.TipoLlamada.Provincial || tipo == Llamada.TipoLlamada.Todas)
                    {
                        acumulador += ((Provincial)llamada).CostoLlamada;
                    }
                }
            }
            return acumulador;
        }

        public float GananciaPorTotal
        {
            get
            {
                return this.CalcularGanancia(Llamada.TipoLlamada.Todas);
            }
        }

        public float GananciaPorLocal
        {
            get
            {
                return this.CalcularGanancia(Llamada.TipoLlamada.Local);
            }
        }

        public float GananciaPorProvincial
        {
            get
            {
                return this.CalcularGanancia(Llamada.TipoLlamada.Provincial);
            }
        }

        public List<Llamada> Llamadas
        {
            get
            {
                return this.listaLlamadas;
            }
        }

        public string Mostrar()
        {
            StringBuilder sb = new StringBuilder();

            sb.AppendLine("Razón Social: " + this.razonSocial);
            sb.AppendLine("Ganancia total: " + this.GananciaPorTotal);
            sb.AppendLine("Ganancia por llamadas locales: " + this.GananciaPorLocal);
            sb.AppendLine("Ganancia por llamadas provincial: " + this.GananciaPorProvincial);
            sb.AppendLine("Detalle de todas las llamadas:\n");

            foreach (Llamada llamada in Llamadas)
            {
                if(llamada is Local)
                {
                    sb.AppendLine(((Local)llamada).Mostrar());
                }
                else if(llamada is Provincial)
                {
                    sb.AppendLine(((Provincial)llamada).Mostrar());
                }
            }
            return sb.ToString();
        }

        public void OrdenarLlamadas()
        {
            this.Llamadas.Sort(Llamada.OrdenarPorDuracion);         
        }
    }
}
