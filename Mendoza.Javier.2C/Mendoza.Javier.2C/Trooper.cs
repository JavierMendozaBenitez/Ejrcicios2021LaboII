using System;

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
            return string.Format(this.Tipo, " armado con ", this.Armamento,"SI/NO es clone");
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
