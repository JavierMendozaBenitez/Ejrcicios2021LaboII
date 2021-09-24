using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Biblioteca
{
    public class Automovil: Vehiculo 
    {
        private string marca;
        private static double valorHora;

        static Automovil()
        {
            Automovil.valorHora = 120;
        }
        public Automovil (string patente, DateTime horaIngreso, string marca) 
            : base (patente, horaIngreso)
        {

        }

    }
}
