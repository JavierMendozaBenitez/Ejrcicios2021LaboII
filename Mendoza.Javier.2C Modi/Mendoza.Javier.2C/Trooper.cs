using System;
using System.Text;

namespace Mendoza.Javier._2C
{
    public abstract class Trooper
    {
        protected Blaster armamento;
        protected bool esClon;

        /// <summary>
        /// Constructor
        /// </summary>
        /// <param name="armamento"></param>
        public Trooper(Blaster armamento)
        {
            this.armamento = armamento;
        }

        /// <summary>
        /// Constructor
        /// </summary>
        /// <param name="armamento"></param>
        /// <param name="esClon"></param>
        public Trooper(Blaster armamento, bool esClon)
            : this (armamento)
        {
            this.EsClon = false;
        }

        /// <summary>
        /// Propiedad
        /// </summary>
        public Blaster Armamento
        {
            get
            {
                return this.armamento;
            }
        }

        /// <summary>
        /// Propiedad
        /// </summary>
        public bool EsClon
        {
            get
            {
                return this.esClon;
            }
            set
            {
                this.esClon = value;
            }
        }

        /// <summary>
        /// Propiedad
        /// </summary>
        public abstract string Tipo { get; }

        /// <summary>
        /// Metodo
        /// </summary>
        /// <returns></returns>
        public virtual string InfoTrooper()
        {
            if(this.EsClon == false)
            {
                return string.Format("{0} armado con {1}, NO es clone ", this.Tipo, this.Armamento);
            }
            else
            {
                return string.Format("{0} armado con {1}, SI es clone ", this.Tipo, this.Armamento);
            }            
        }

        /// <summary>
        /// Sobrecarga
        /// </summary>
        /// <param name="obj"></param>
        /// <returns></returns>
        public override bool Equals(object obj)
        {
            return this.GetType() == obj.GetType();
        }

    }
}
