using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Billetes
{
    public class Dolar
    {
        private double cantidad;
        private static double cotizRespectoDolar;

        static Dolar()//instanciar
        {
            Dolar.cotizRespectoDolar = 1;//solo se accede a otros static. 
        }
        public Dolar(double cantidad)
        {
            this.cantidad = cantidad;
        }
        public Dolar(double cantidad, double cotizacion)
            : this(cantidad)
        {
            Dolar.cotizRespectoDolar = cotizacion;
        }

        public double GetCantidad
        {
            get
            {
                return this.cantidad;
            }
        }

        public static double GetCotizacion
        {
            get
            {
                return Dolar.cotizRespectoDolar;
            }
        }

        public static implicit operator Dolar (double d)
        {
            return new Dolar(d);
        }

        public static explicit operator Euro (Dolar d)//quiero convertir a Euro los dolares que recibo
        {
            return new Euro(d.cantidad * Euro.GetCotizacion);
        }

        public static explicit operator Pesos(Dolar d)//quiero convertir a Pesos los dolares que recibo
        {
            return new Pesos(d.cantidad * Pesos.GetCotizacion);
        }


        public static bool operator == (Dolar d1, Dolar d2)
        {
            return (d1.GetCantidad == d2.GetCantidad);
        }

        public static bool operator != (Dolar d1, Dolar d2)
        {
            return !(d1 == d2);
        }

        public static bool operator == (Dolar d, Euro e)
        {
            return (d.GetCantidad == ((Dolar)e).GetCantidad);
        }
        public static bool operator != (Dolar d, Euro e)
        {
            return !(d == e);
        }

        public static bool operator == (Dolar d, Pesos p)
        {
            return (d.GetCantidad == ((Dolar)p).GetCantidad);
        }
        public static bool operator != (Dolar d, Pesos p)
        {
            return !(d == p);
        }

        public static Dolar operator + (Dolar d, Euro e)
        {
            return new Dolar((d.GetCantidad + ((Dolar)e).GetCantidad));
        }

        public static Dolar operator + (Dolar d, Pesos p)
        {
            return new Dolar((d.GetCantidad + ((Dolar)p).GetCantidad));
        }

        public static Dolar operator - (Dolar d, Euro e)
        {
            return new Dolar((d.GetCantidad - ((Dolar)e).GetCantidad));
        }

        public static Dolar operator - (Dolar d, Pesos p)
        {
            return new Dolar((d.GetCantidad - ((Dolar)p).GetCantidad));
        }
    }
}
