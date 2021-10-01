using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Mendoza.Javier._2C
{
    public class TrooperAsalto:Trooper
    {
        /// <summary>
        /// Constructor
        /// </summary>
        /// <param name="armamento"></param>
        public TrooperAsalto(Blaster armamento)
            : base(armamento, true)
        { }

        /// <summary>
        /// Propiedad
        /// </summary>
        public override string Tipo
        {
            get
            {
                return "Comandos para misiones de infiltracion";
            }
        }
    }
}
