using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Mendoza.Javier._2C
{
    public class TrooperExplorador : Trooper
    {
        public string vehiculo;

        /// <summary>
        /// Constructor
        /// </summary>
        /// <param name="vehiculo"></param>
        public TrooperExplorador(string vehiculo)
            : base(Blaster.EC17)
        {
            this.Vehiculo = vehiculo;
        }

        /// <summary>
        /// Propiedad
        /// </summary>
        public string Vehiculo
        {
            get
            {
                return this.vehiculo;
            }
            set
            {
                if(value == " ")
                {
                    this.vehiculo = "Indefinido";
                }
                else
                {
                    this.vehiculo = value;
                }
            }
        }

        /// <summary>
        /// Propiedad
        /// </summary>
        public override string Tipo
        {
            get
            {
                return "Soldado de exploracion";
            }
        }

        /// <summary>
        /// Metodo
        /// </summary>
        /// <returns></returns>
        public override string InfoTrooper()
        {
            StringBuilder sb = new StringBuilder();
            
            sb.AppendLine(base.InfoTrooper());
            sb.AppendLine("- Vehiculo: " + this.Vehiculo);
            return sb.ToString();  
        }
    }
}
