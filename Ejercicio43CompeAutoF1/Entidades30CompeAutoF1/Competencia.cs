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
        List<VehiculoDeCarrera> competidores;
        public enum TipoCompetencia { F1, MotoCross }
        private TipoCompetencia tipo;
           
        private Competencia()
        {
            competidores = new List<VehiculoDeCarrera>();
        }

        public Competencia (short cantidadVueltas, short cantidadCompetidores, TipoCompetencia tipo)
            : this()
        {
            this.CantidadVueltas = cantidadVueltas;
            this.CantidadCompetidores = cantidadCompetidores;
            this.Tipo = tipo;
        }

        public short CantidadCompetidores
        {
            get
            {
                return this.cantidadCompetidores;
            }
            set
            {
                this.cantidadCompetidores = value;
            }
        }

        public short CantidadVueltas
        {
            get
            {
                return this.cantidadVueltas;
            }
            set
            {
                this.cantidadVueltas = value;
            }
        }

        public VehiculoDeCarrera this[int i]
        {
            get
            {
                if(competidores.Count > 0)
                {
                    for(int j = 0; j <= competidores.Count; j++)
                    {
                        if(j == i)
                        {
                            return competidores[i];
                        }
                    }
                }
                return competidores.Last();
            }
        }

        public TipoCompetencia Tipo
        {
            get
            {
                return this.tipo;
            }
            set
            {
                this.tipo = value;
            }
        }

        public string Mostrar()
        {
            StringBuilder sb = new StringBuilder();
            sb.AppendLine("Cantidad de competidores " + this.CantidadCompetidores);
            sb.AppendLine("Cantidad de vueltas " + this.CantidadVueltas);
            sb.AppendLine("Tipo de competencia " + this.Tipo);

            sb.AppendLine("Competidores");

            foreach (VehiculoDeCarrera vehiculo in competidores)
            {
                if(vehiculo is AutoF1)
                {
                    sb.AppendLine(((AutoF1)vehiculo).MostrarDatos());
                }
                else if(vehiculo is MotoCross)
                {
                    sb.AppendLine(((MotoCross)vehiculo).MostrarDatos());
                }                
            }
            return sb.ToString();
        }

        public static bool operator == (Competencia c, VehiculoDeCarrera a)
        {
            bool retorno = false;

            if(c.Tipo == TipoCompetencia.MotoCross && a is MotoCross || c.Tipo == TipoCompetencia.F1 && a is AutoF1)
            {
                if (c.competidores.Count > 0)
                {
                    foreach (VehiculoDeCarrera vehiculo in c.competidores)
                    {
                        if (vehiculo == a)
                        {
                            retorno = true;
                            break;
                        }
                    }
                }
            }
            else
            {
                throw new CompetenciaNoDisponibleException("El vehículo no corresponde a la competencia", "clase Competencia", "metodo ==");
            }

            return retorno;
        }

        public static bool operator !=(Competencia c, VehiculoDeCarrera a)
        {
            return !(c == a);
        }

        public static bool operator +(Competencia c, VehiculoDeCarrera a)
        {
            bool retorno = false;
            Random random = new Random();

            try
            {
                if (c.competidores.Count < c.cantidadCompetidores && c != a)
                {
                    c.competidores.Add(a);
                    a.EnCompetencia = true;
                    a.VueltasRestantes = c.cantidadVueltas;
                    a.CantidadCombustible = (short)random.Next(15, 100);

                    retorno = true;
                }
            }
            catch(CompetenciaNoDisponibleException ex)
            {
                throw new CompetenciaNoDisponibleException("Competencia incorrecta, ", "clase Competencia, ", " metodo +, ", ex);
            }
            
            return retorno;
        }

        public static bool operator -(Competencia c, VehiculoDeCarrera a)
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
