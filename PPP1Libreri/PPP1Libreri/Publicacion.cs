using System;
using System.Text;

namespace PPP1Libreri
{
    public abstract class Publicacion
    {
        protected float importe;
        protected string nombre;
        protected int stock;

        public Publicacion(string nombre)
        {
            this.nombre = nombre;
        }

        public Publicacion(string nombre, int stock)
            : this(nombre)
        {
            this.Stock = stock;
        }

        public Publicacion(string nombre, int stock, float importe)
            : this (nombre, stock)
        {
            this.importe = importe;
        }

        public abstract bool EsColor { get; }

        public virtual bool HayStock
        {
            get
            {
                return this.Stock > 0 && this.Importe > 0;                
            }
        }

        public float Importe
        {
            get
            {
                return this.importe;
            }
        }

        public int Stock
        {
            get
            {
                return this.stock;
            }
            set
            {
                if(value > 0)
                {
                    this.stock = value;
                }
            }
        }

        public string ObtenerInformacion()
        {
            StringBuilder sb = new StringBuilder();

            sb.AppendLine("Nombre: " + this.nombre);
            sb.AppendLine("Stock: " + this.Stock);
            sb.AppendLine("Es color: " + this.EsColor);
            sb.AppendLine("Valor: " + this.Importe);

            return sb.ToString();
        }

        public override string ToString()
        {
            return this.nombre;
        }
    }
}
