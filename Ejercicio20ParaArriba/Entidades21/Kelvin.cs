using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades21
{
    public class Kelvin
    {
        private double temperatura;
        private static double tempRespectoFahrenheit;

        static Kelvin()
        {
            Kelvin.tempRespectoFahrenheit = (Fahrenheit.GetTempRespectoFahrenheit + 459.67) * 5 / 9;
        }
        public Kelvin(double temperatura)
        {
            this.temperatura = temperatura;
        }
        public Kelvin(double temperatura, double tempRespectoFahrenheit)
            : this(temperatura)
        {
            Kelvin.tempRespectoFahrenheit = tempRespectoFahrenheit;
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
                return Kelvin.tempRespectoFahrenheit;
            }
        }

        public static implicit operator Kelvin(double f)
        {
            return new Kelvin(f);
        }

        public static explicit operator Celsius (Kelvin k)//quiero convertir a Celsius los Kelvin que recibo
        {
            return new Celsius(k.temperatura * Celsius.GetTempRespectoFahrenheit);
        }

        public static explicit operator Fahrenheit (Kelvin k)//quiero convertir a Fahrenheit los Kelvin que recibo
        {
            return new Fahrenheit(k.temperatura * Fahrenheit.GetTempRespectoFahrenheit);
        }





        public static bool operator ==(Kelvin k1, Kelvin k2)
        {
            return k1.GetTemperatura == k2.GetTemperatura;
        }

        public static bool operator !=(Kelvin k1, Kelvin k2)
        {
            return !(k1.GetTemperatura == k2.GetTemperatura);
        }



        public static bool operator ==(Kelvin k, Celsius c)
        {
            return ((k.GetTemperatura == ((Kelvin)c).GetTemperatura));
        }
        public static bool operator !=(Kelvin k, Celsius c)
        {
            return !((k.GetTemperatura == ((Kelvin)c).GetTemperatura));
        }



        public static bool operator ==(Kelvin k, Fahrenheit f)
        {
            return ((k.GetTemperatura == ((Kelvin)f).GetTemperatura));
        }
        public static bool operator !=(Kelvin k, Fahrenheit f)
        {
            return !((k.GetTemperatura == ((Kelvin)f).GetTemperatura));
        }





        public static Kelvin operator +(Kelvin k, Celsius c)
        {
            return new Kelvin((k.GetTemperatura + ((Kelvin)c).GetTemperatura));
        }

        public static Kelvin operator +(Kelvin k, Fahrenheit f)
        {
            return new Kelvin((k.GetTemperatura + ((Kelvin)f).GetTemperatura));
        }



        public static Kelvin operator -(Kelvin k, Celsius c)
        {
            return new Kelvin((k.GetTemperatura - ((Kelvin)c).GetTemperatura));
        }

        public static Kelvin operator -(Kelvin k, Fahrenheit f)
        {
            return new Kelvin((k.GetTemperatura - ((Kelvin)f).GetTemperatura));
        }
    }
}

