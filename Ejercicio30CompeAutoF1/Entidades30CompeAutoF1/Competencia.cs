using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades30CompeAutoF1
{
    public class Competencia
    {
        private short cantidadCompetidores;
        private short cantidadVueltas;
        List<AutoF1> competidores;

        private Competencia()
        {
            competidores = new List<AutoF1>();
        }

        public Competencia (short cantidadVueltas, short cantidadCompetidores)
            : this()
        {
            this.cantidadVueltas = cantidadVueltas;
            this.cantidadCompetidores = cantidadCompetidores;
        }

        public string Mostrar()
        {
            StringBuilder sb = new StringBuilder();
            sb.AppendLine("Cantidad de competidores " + this.cantidadCompetidores);
            sb.AppendLine("Cantidad de vueltas " + this.cantidadVueltas);

            foreach (AutoF1 item in competidores)
            {
                sb.AppendLine(item.MostrarDatos());
            }

            return sb.ToString();
        }

        public static bool operator == (Competencia c, AutoF1 a)
        {
            bool retorno = false;

            if(c.competidores.Count > 0)
            {
                foreach (AutoF1 auto in c.competidores)
                {
                    if(auto == a)
                    {
                        retorno = true;
                        break;
                    }
                }
            }
            return retorno;
        }

        public static bool operator !=(Competencia c, AutoF1 a)
        {
            return !(c == a);
        }

        public static bool operator +(Competencia c, AutoF1 a)
        {
            bool retorno = false;
            Random random = new Random();

            if (c.competidores.Count < c.cantidadCompetidores && c != a)
            {
                c.competidores.Add(a);
                a.SetEnCompetencia = true;
                a.SetVueltasRestantes = c.cantidadVueltas;
                a.SetCantidadCombustible = (short)random.Next(15, 100);

                retorno = true;
            }
            return retorno;
        }

        public static bool operator -(Competencia c, AutoF1 a)
        {
            bool retorno = false;

            if(c == a)
            {
                c.competidores.Remove(a);
                retorno = true;
            }

            return retorno;
        }
    }
}
