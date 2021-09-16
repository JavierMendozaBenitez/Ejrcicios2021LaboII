using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades21
{
    public class Celsius
    {
        private double temperatura;
        private static double tempRespectoFahrenheit;

        static Celsius()
        {
            Celsius.tempRespectoFahrenheit = (Fahrenheit.GetTempRespectoFahrenheit - 32) * 5 / 9;
        }
        public Celsius(double temperatura)
        {
            this.temperatura = temperatura;
        }
        public Celsius(double temperatura, double tempRespectoFahrenheit)
            : this(temperatura)
        {
            Celsius.tempRespectoFahrenheit = tempRespectoFahrenheit;
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
                return Celsius.tempRespectoFahrenheit;
            }
        }

        public static implicit operator Celsius (double f)
        {
            return new Celsius(f);
        }

        public static explicit operator Fahrenheit (Celsius c)//quiero convertir a Fahrenheit los celsius que recibo
        {
            return new Fahrenheit(c.temperatura * Fahrenheit.GetTempRespectoFahrenheit);
        }

        public static explicit operator Kelvin(Celsius c)//quiero convertir a kelvin los celsius que recibo
        {
            return new Kelvin(c.temperatura * Kelvin.GetTempRespectoFahrenheit);
        }






        public static bool operator ==(Celsius c1, Celsius c2)
        {
            return c1.GetTemperatura == c2.GetTemperatura;
        }

        public static bool operator !=(Celsius c1, Celsius c2)
        {
            return !(c1.GetTemperatura == c2.GetTemperatura);
        }



        public static bool operator ==(Celsius c, Kelvin k)
        {
            return ((c.GetTemperatura == ((Celsius)k).GetTemperatura));
        }
        public static bool operator !=(Celsius c, Kelvin k)
        {
            return !((c.GetTemperatura == ((Celsius)k).GetTemperatura));
        }



        public static bool operator ==(Celsius c, Fahrenheit f)
        {
            return ((c.GetTemperatura == ((Celsius)f).GetTemperatura));
        }
        public static bool operator !=(Celsius c, Fahrenheit f)
        {
            return !((c.GetTemperatura == ((Celsius)f).GetTemperatura));
        }





        public static Celsius operator +(Celsius c, Kelvin k)
        {
            return new Celsius((c.GetTemperatura + ((Celsius)k).GetTemperatura));
        }

        public static Celsius operator +(Celsius c, Fahrenheit f)
        {
            return new Celsius((c.GetTemperatura + ((Celsius)f).GetTemperatura));
        }



        public static Celsius operator -(Celsius c, Kelvin k)
        {
            return new Celsius((c.GetTemperatura - ((Celsius)k).GetTemperatura));
        }

        public static Celsius operator -(Celsius c, Fahrenheit f)
        {
            return new Celsius((c.GetTemperatura - ((Celsius)f).GetTemperatura));
        }
    }
}

