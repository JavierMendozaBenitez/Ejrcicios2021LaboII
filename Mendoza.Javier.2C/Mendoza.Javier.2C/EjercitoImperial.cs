using System; 
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Mendoza.Javier._2C
{
    public class EjercitoImperial
    {
        private int capacidad;
        private List<Trooper> troopers;

        /// <summary>
        /// Constructor
        /// </summary>
        private EjercitoImperial()
        {
            this.troopers = new List<Trooper>();
        }

        /// <summary>
        /// Constructor
        /// </summary>
        /// <param name="capacidad"></param>
        public EjercitoImperial(int capacidad)
            :this()
        {
            this.capacidad = capacidad;
        }

        /// <summary>
        /// Lista
        /// </summary>
        public List<Trooper> Troopers
        {
            get
            {
                return this.troopers;
            }
        }

        /// <summary>
        /// Sobrecarga
        /// </summary>
        /// <param name="ejercito"></param>
        /// <param name="soldado"></param>
        /// <returns></returns>
        public static EjercitoImperial operator + (EjercitoImperial ejercito, Trooper soldado)
        {
            if(ejercito.Troopers.Count < ejercito.capacidad)
            {
                foreach (Trooper troAux in ejercito.Troopers)
                {
                    if(troAux == soldado)
                    {
                        ejercito.troopers.Add(soldado);
                        return ejercito; 
                    }
                }
            }
            return ejercito;
        }

        /// <summary>
        /// Sobrecarga
        /// </summary>
        /// <param name="ejercito"></param>
        /// <param name="soldado"></param>
        /// <returns></returns>
        public static EjercitoImperial operator -(EjercitoImperial ejercito, Trooper soldado)
        {

            foreach (Trooper troAux in ejercito.Troopers)
            {
                if (troAux.Tipo == soldado.Tipo)
                {
                    ejercito.troopers.Remove(soldado);
                    break;                   
                }
            }
            return ejercito;
        }
    }
}
