using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades21
{
    public class Fahrenheit
    {
        private double temperatura;
        private static double tempRespectoFahrenheit;

        static Fahrenheit()
        {
            Fahrenheit.tempRespectoFahrenheit = 1;
        }
        public Fahrenheit(double temperatura)
        {
            this.temperatura = temperatura;
        }
        public Fahrenheit(double temperatura, double tempRespectoFahrenheit)
            : this(temperatura)
        {
            Fahrenheit.tempRespectoFahrenheit = tempRespectoFahrenheit;
        }

        public double GetTemperatura
        {
            get
            {
                return this.temperatura;
            }
        }

        public static double GetTempRespectoFahrenheit
        {
            get
            {
                return Fahrenheit.tempRespectoFahrenheit;
            }
        }

        public static implicit operator Fahrenheit(double f)
        {
            return new Fahrenheit(f);
        }

        public static explicit operator Celsius (Fahrenheit f)//quiero convertir a Celsius los Fahrenheit que recibo
        {
            return new Celsius(f.temperatura * Celsius.GetTempRespectoFahrenheit);
        }

        public static explicit operator Kelvin(Fahrenheit f)//quiero convertir a Pesos los dolares que recibo
        {
            return new Kelvin(f.temperatura * Kelvin.GetTempRespectoFahrenheit);
        }




        public static bool operator == (Fahrenheit f1, Fahrenheit f2)
        {
            return f1.GetTemperatura == f2.GetTemperatura;
        }

        public static bool operator != (Fahrenheit f1, Fahrenheit f2)
        {
            return !(f1.GetTemperatura == f2.GetTemperatura);
        }



        public static bool operator == (Fahrenheit f, Celsius c)
        {
            return ((f.GetTemperatura == ((Fahrenheit)c).GetTemperatura));
        }
        public static bool operator != (Fahrenheit f, Celsius c)
        {
            return !((f.GetTemperatura == ((Fahrenheit)c).GetTemperatura));
        }



        public static bool operator == (Fahrenheit f, Kelvin k)
        {
            return ((f.GetTemperatura == ((Fahrenheit)k).GetTemperatura));
        }
        public static bool operator != (Fahrenheit f, Kelvin k)
        {
            return !((f.GetTemperatura == ((Fahrenheit)k).GetTemperatura));
        }





        public static Fahrenheit operator + (Fahrenheit f, Celsius c)
        {
            return new Fahrenheit((f.GetTemperatura + ((Fahrenheit)c).GetTemperatura));
        }

        public static Fahrenheit operator + (Fahrenheit f, Kelvin k)
        {
            return new Fahrenheit((f.GetTemperatura + ((Fahrenheit)k).GetTemperatura));
        }



        public static Fahrenheit operator - (Fahrenheit f, Celsius c)
        {
            return new Fahrenheit((f.GetTemperatura - ((Fahrenheit)c).GetTemperatura));
        }

        public static Fahrenheit operator - (Fahrenheit f, Kelvin k)
        {
            return new Fahrenheit((f.GetTemperatura - ((Fahrenheit)k).GetTemperatura));
        }
    }
}

