using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Mendoza.Javier._2C
{
    public class TrooperArena: Trooper
    {

        /// <summary>
        /// Constructor
        /// </summary>
        /// <param name="armamento"></param>
        public TrooperArena(Blaster armamento)
            :base (armamento)
        {  }
        /// <summary>
        /// Propiedad
        /// </summary>
        public override string Tipo
        {
            get
            {
                return "Soldado de asalto de terrenos deserticos";
            }
        }
    }
}
