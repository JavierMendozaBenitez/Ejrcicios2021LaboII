using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Billetes
{
    public class Euro
    {
        private double cantidad;
        private static double cotizRespectoDolar;
        
        static Euro()
        {
            Euro.cotizRespectoDolar = 1 / 1.18;
        }
        public Euro(double cantidad)
        {
            this.cantidad = cantidad;
        }
        public Euro(double cantidad, double cotizacion)
            : this(cantidad)
        {
            Euro.cotizRespectoDolar = cotizacion;
        }

        public static double SetCotizacion(double e)
        {
            return Euro.cotizRespectoDolar = e;
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
                return Euro.cotizRespectoDolar;
            }
        }

        public static implicit operator Euro(double d)
        {
            return new Euro(d);
        }

        public static explicit operator Dolar(Euro e)//quiero convertir a Dolar los euros que recibo
        {
            return new Dolar(e.cantidad / Euro.GetCotizacion);
        }

        public static explicit operator Pesos(Euro e)//quiero convertir a Pesos los euros que recibo
        {
            return (Pesos)((Dolar)e);
        }




        public static bool operator == (Euro e1, Euro e2)
        {
            return e1.GetCantidad == e2.GetCantidad;
        }

        public static bool operator != (Euro e1, Euro e2)
        {
            return !(e1.GetCantidad == e2.GetCantidad);
        }

        public static bool operator == (Euro e, Dolar d)
        {
            return ((e.GetCantidad == ((Euro)d).GetCantidad));
        }
        public static bool operator != (Euro e, Dolar d)
        {
            return !((e.GetCantidad == ((Euro)d).GetCantidad));
        }

        public static bool operator == (Euro e, Pesos p)
        {
            return ((e.GetCantidad == ((Euro)p).GetCantidad));
        }
        public static bool operator != (Euro e, Pesos p)
        {
            return !((e.GetCantidad == ((Euro)p).GetCantidad));
        }

        public static Euro operator + (Euro e, Dolar d)
        {
            return new Euro((e.GetCantidad + ((Euro)d).GetCantidad));
        }

        public static Euro operator + (Euro e, Pesos p)
        {
            return new Euro((e.GetCantidad + ((Euro)p).GetCantidad));
        }

        public static Euro operator - (Euro e, Dolar d)
        {
            return new Euro((e.GetCantidad - ((Euro)d).GetCantidad));
        }

        public static Euro operator - (Euro e, Pesos p)
        {
            return new Euro((e.GetCantidad - ((Euro)p).GetCantidad));
        }
    }
}

