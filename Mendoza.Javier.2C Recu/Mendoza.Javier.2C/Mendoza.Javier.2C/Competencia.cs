using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Mendoza.Javier._2C
{
    public class Competencia
    {
        private int cantidaCompetidores;
        private List<Equipo> equipos;
        private string nombre;

        private Competencia(string nombre)
            : this(nombre, 5) { }

        public Competencia(string nombre, int cantidadCompetidores)
        {
            this.equipos = new List<Equipo>();
            this.Nombre = nombre;
            this.CantidadCompetidores = cantidadCompetidores;
        }

        public int CantidadCompetidores
        {
            get
            {
                return this.cantidaCompetidores;
            }
            set
            {
                this.cantidaCompetidores = value;
            }
        }

        public List<Equipo> Equipos
        {
            get
            {
                return this.equipos;
            }
        }

        public string Nombre
        {
            get
            {
                return this.nombre;
            }
            set
            {
                this.nombre = value;
            }
        }

        public static implicit operator Competencia (string nombre)
        {
            Competencia compe = new Competencia(nombre);
            
            return compe;
        }

        public static bool operator == (Competencia torneo, Equipo equipo)
        {
            foreach (Equipo item in torneo.Equipos)
            {
                if (item.Equals(equipo.Nombre))
                {
                    return true;
                }
            }

            return false;
        }

        public static bool operator !=(Competencia torneo, Equipo equipo)
        {
            return !(torneo == equipo);
        }

        public static Competencia operator +(Competencia torneo, Equipo equipo)
        {
            if (torneo.Equipos.Count < torneo.CantidadCompetidores && torneo != equipo)
            {
                torneo.equipos.Add(equipo);
            }
            return torneo;
        }

        public static string MostrarTorneo(Competencia torneo)
        {
            StringBuilder sb = new StringBuilder();

            sb.AppendLine(torneo.Nombre);
            sb.AppendLine(torneo.CantidadCompetidores.ToString());

            foreach (Equipo item in torneo.Equipos)
            {
                sb.AppendLine(item.ToString());
            }

            return sb.ToString();
        }
    }
}
