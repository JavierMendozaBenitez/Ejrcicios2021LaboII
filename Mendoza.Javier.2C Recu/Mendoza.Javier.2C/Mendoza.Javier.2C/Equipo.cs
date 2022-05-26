using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Mendoza.Javier._2C
{
    public abstract class Equipo
    {
        private string nombre;
        private int partidosEmpatados;
        private int partidosGanados;
        private int partidosJugados;
        private int partidosPerdidos;
        private int puntuacion;

        public string Nombre
        {
            get
            {
                return this.nombre;
            }
        }
        public int PE
        {
            get
            {
                return this.partidosEmpatados;
            }
            set
            {
                this.partidosEmpatados = value;
            }
        }
        public int PG
        {
            get
            {
                return this.partidosGanados;
            }
            set
            {
                this.partidosGanados = value;
            }
        }
        public int PJ
        {
            get
            {
                return this.partidosJugados;
            }
            set
            {
                this.partidosJugados = value;
            }
        }
        public int PP
        {
            get
            {
                return this.partidosPerdidos;
            }
            set
            {
                this.partidosPerdidos = value;
            }
        }

        public int Puntuacion
        {
            get
            {
                return this.puntuacion;
            }
            set
            {
                this.puntuacion = value;
            }
        }

        public string Tipo
        {
            get
            {
                return this.Nombre;
            }
        }

        public override bool Equals(object obj)
        {
            return this.GetType() == obj.GetType();
        }

        protected Equipo(string nombre)
        {
            this.nombre = nombre;
        }

        public abstract int GetDificultad();

        public static bool JugarPartido(Equipo equipoA, Equipo equipoB)
        {
            if (equipoA.Equals(equipoB))
            {
                equipoA.PJ++;
                equipoB.PJ++;

                if (equipoA.GetDificultad() > equipoB.GetDificultad())
                {
                    equipoA.Puntuacion += 3;
                }
                else if (equipoA.GetDificultad() < equipoB.GetDificultad())
                {
                    equipoB.Puntuacion += 3;
                }
                else
                {
                    equipoA.Puntuacion += 1;
                    equipoB.Puntuacion += 1;
                }
                return true;
            }
            return false;
        }

        protected virtual string MostrarDatos()
        {
            StringBuilder sb = new StringBuilder();

            sb.AppendLine(this.Nombre);

            return sb.ToString();
        } 

        public static bool operator ==(Equipo equipoA, Equipo equipoB)
        {
            if (equipoA.Equals(equipoB.Tipo))
            {
                return true;
            }
            return false;
        }

        public static bool operator !=(Equipo equipoA, Equipo equipoB)
        {
            return !(equipoA == equipoB);
        }
    }
}
