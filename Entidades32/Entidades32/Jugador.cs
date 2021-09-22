using System;
using System.Text;

namespace Entidades32
{
    public class Jugador
    {
        private int dni;
        private string nombre;
        private int partidosJugados;
        private float promedioGoles;
        private int totalGoles;

        private Jugador()
        {
            this.partidosJugados = 0;
            this.promedioGoles = 0;
            this.totalGoles = 0;
        }

        public Jugador(int dni, string nombre)
            : this()
        {
            this.dni = dni;
            this.nombre = nombre;
        }


        //propiedades
        // solo lectura

        public int PartidosJugados
        {
            get
            {
                return this.partidosJugados;
            }
        }
        
        
        public int TotalGoles
        {
            get { return this.totalGoles; }
        }


        public float PromedioGoles
        {
            get { return (float) this.totalGoles / this.partidosJugados; }
        }

        //lectura y escritura


        public int Dni
        {
            get { return this.dni; }
            set { this.dni = value; }
        }


        public string Nombre
        {
            get { return this.nombre; }
            set { this.nombre = value; }
        }




        public Jugador(int dni, string nombre, int totalGoles, int totalPartidos)
            : this(dni, nombre)
        {
            this.totalGoles = totalGoles;
            this.partidosJugados = totalPartidos;
        }

        /*public float GetPromedioGoles()
        {
            return this.promedioGoles = (float)this.totalGoles / (float)this.partidosJugados;
        }*/

        public string MostrarDatos()
        {
            StringBuilder sb = new StringBuilder();

            sb.AppendLine("DNI: " + this.dni);
            sb.AppendLine("Nombre: " + this.nombre);
            sb.AppendLine("Partidos jugados: " + this.partidosJugados.ToString());
            //sb.AppendLine("Promedio de Goles: " + this.GetPromedioGoles());
            sb.AppendLine("Promedio de Goles: " + this.PromedioGoles.ToString());
            sb.AppendLine("Total de Goles: " + this.totalGoles.ToString());

            return sb.ToString();
        }

        public static bool operator ==(Jugador j1, Jugador j2)
        {
            return j1.dni == j2.dni;
        }
        public static bool operator !=(Jugador j1, Jugador j2)
        {
            return !(j1.dni == j2.dni);
        }
    }
}