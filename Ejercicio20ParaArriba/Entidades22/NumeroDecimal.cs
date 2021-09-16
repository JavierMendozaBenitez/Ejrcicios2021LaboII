using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Ejercicio13;

namespace Entidades22
{
    public class NumeroDecimal
    {
        public double numero;

        private NumeroDecimal (double numero)
        {
            this.numero = numero;
        }

        public double GetNumeroDecimal
        {
            get
            {
                return this.numero;
            }
        }

        /*public static implicit operator double (NumeroDecimal nuDecimal)//covierto a double los NumeroDecimal que recibo
        {
            return nuDecimal;
        }

        public static explicit operator NumeroDecimal(double nuDecimal)//covierto a NumeroDecimal los double que recibo
        {
            return new NumeroDecimal(nuDecimal);
        }*/

        public static explicit operator double(NumeroDecimal nuDecimal)//covierto a double los NumeroDecimal que recibo
        {
            return nuDecimal.numero;
        }

        public static implicit operator NumeroDecimal(double nuDecimal)//covierto a NumeroDecimal los double que recibo
        {
            return new NumeroDecimal(nuDecimal);
        }

        public static double operator +(NumeroDecimal nuDecimal, NumeroBinario nuBinario)
        {
            return nuDecimal.numero + Conversor.BinarioDecimal(nuBinario.numero);
        }

        public static double operator -(NumeroDecimal nuDecimal, NumeroBinario nuBinario)
        {
            return nuDecimal.numero - Conversor.BinarioDecimal(nuBinario.numero);
        }
        public static bool operator ==(NumeroDecimal nuDecimal, NumeroBinario nuBinario)
        {
            return nuDecimal.numero == Conversor.BinarioDecimal(nuBinario.numero);
        }

        public static bool operator !=(NumeroDecimal nuDecimal, NumeroBinario nuBinario)
        {
            return !(nuDecimal.numero == Conversor.BinarioDecimal(nuBinario.numero));
        }
    }
}