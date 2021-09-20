using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public class Equipo
    {
        private short cantidadDeJugadores;
        private List<Jugador> jugadores;
        private string nombre;

        private Equipo()
        {
            jugadores = new List<Jugador>();//Inicializo la lista
        }

        public Equipo(short cantidad, string nombre)
            : this()
        {
            this.cantidadDeJugadores = cantidad;
            this.nombre = nombre;
        }

        public static bool operator + (Equipo e, Jugador j)
        {
            bool puedeAgregar = false;

            if (e.jugadores.Count < e.cantidadDeJugadores)
            {
                puedeAgregar = true;

                foreach (Jugador aux in e.jugadores)
                {
                    if (aux == j)
                    {
                        puedeAgregar = false;
                        break;
                    }
                }

                if (puedeAgregar)
                {
                    e.jugadores.Add(j);
                }
            }

            return puedeAgregar;
        }
    }    
}
