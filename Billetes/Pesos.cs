using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Billetes
{
    public class Pesos
    {
        private double cantidad;
        private static double cotizRespectoDolar;

        static Pesos()
        {
            Pesos.cotizRespectoDolar = 180;
        }
        public Pesos(double cantidad)
        {
            this.cantidad = cantidad;
        }
        public Pesos(double cantidad, double cotizacion)
            : this(cantidad)
        {
            Pesos.cotizRespectoDolar = cotizacion;
        }

        public static double SetCotizacion(double p)
        {
            return Pesos.cotizRespectoDolar = p;
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
                return Pesos.cotizRespectoDolar;
            }
        }


        public static implicit operator Pesos(double d)
        {
            return new Pesos(d);
        }

        public static explicit operator Euro(Pesos p)//quiero convertir a Euro los Pesos que recibo
        {
            return (Euro)((Dolar)p);
        }

        public static explicit operator Dolar(Pesos p)//quiero convertir a dolares los Pesos que recibo
        {
            return new Dolar(p.cantidad / Pesos.GetCotizacion);
        }



        public static bool operator == (Pesos p1, Pesos p2)
        {
            return (p1.GetCantidad == p2.GetCantidad);
        }

        public static bool operator != (Pesos p1, Pesos p2)
        {
            return !(p1 == p2);
        }

        public static bool operator == (Pesos p, Euro e)
        {
            return (p.GetCantidad == ((Pesos)e).GetCantidad);
        }
        public static bool operator != (Pesos p, Euro e)
        {
            return !(p == e);
        }

        public static bool operator == (Pesos p, Dolar d)
        {
            return (p.GetCantidad == ((Pesos)d).GetCantidad);
        }
        public static bool operator !=(Pesos p, Dolar d)
        {
            return !(d == p);
        }

        public static Pesos operator + (Pesos p, Euro e)
        {
            return new Pesos((p.GetCantidad + ((Pesos)e).GetCantidad));
        }

        public static Pesos operator + (Pesos p, Dolar d)
        {
            return new Pesos((p.GetCantidad + ((Pesos)d).GetCantidad));
        }

        public static Pesos operator - (Pesos p, Euro e)
        {
            return new Pesos((p.GetCantidad - ((Pesos)e).GetCantidad));
        }

        public static Pesos operator - (Pesos p, Dolar d)
        {
            return new Pesos((p.GetCantidad - ((Pesos)d).GetCantidad));
        }
    }
}
