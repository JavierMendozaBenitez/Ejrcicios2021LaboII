using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Ejercicio13;

namespace Entidades22
{
    public class NumeroBinario
    {
        public string numero;

        private NumeroBinario(string numero)
        {
            this.numero = numero;
        }

        public string GetNumeroBinario
        {
            get
            {
                return this.numero;
            }
        }

        /* public static implicit operator string (NumeroBinario nuBinario)//covierto a string los NumeroBinario que recibo
         {
             return nuBinario;
         }

         public static explicit operator NumeroBinario(string nuBinario)//covierto a NumeroBinario los string que recibo
         {
             return new NumeroBinario(nuBinario);
         }*/

        public static explicit operator string(NumeroBinario nuBinario)//casteo a (string) los NumeroBinario que recibo, conviert
        {
            return nuBinario.numero;
        }

        public static implicit operator NumeroBinario(string nuBinario)//covierto a NumeroBinario los string que recibo
        {
            return new NumeroBinario(nuBinario);
        }


        public static string operator + (NumeroBinario nuBinario, NumeroDecimal nuDecimal)
        {
            return Conversor.DecimalBinario((int)nuDecimal.numero + Conversor.BinarioDecimal(nuBinario.numero));
        }

        public static string operator -(NumeroBinario nuBinario, NumeroDecimal nuDecimal)
        {
            /*double numAux = Conversor.BinarioDecimal(nuBinario.numero) - nuDecimal.numero;
            nuDecimal.numero = numAux;
            return Conversor.DecimalBinario((int)nuDecimal.numero);*/
            //return Conversor.DecimalBinario((int)nuDecimal.numero - Conversor.BinarioDecimal(nuBinario.numero));
            return Conversor.DecimalBinario((int)(Conversor.BinarioDecimal(nuBinario.numero) - nuDecimal.numero));
        }

        /*public static string operator +(NumeroBinario nuBinario, NumeroDecimal nuDecimal)
        {
            double numAux;
            string hola;
            numAux = Conversor.BinarioDecimal(nuBinario.numero) + nuDecimal.numero;
            nuDecimal.numero = numAux;
            hola = (Conversor.DecimalBinario((int)nuDecimal.numero));
            return hola.ToString();
        }
        */
        public static bool operator == (NumeroBinario nuBinario, NumeroDecimal nuDecimal)
        {
            //return nuBinario.numero == (Conversor.DecimalBinario((int)nuDecimal.numero));
            return nuDecimal.numero == Conversor.BinarioDecimal(nuBinario.numero);
        }

        public static bool operator !=(NumeroBinario nuBinario, NumeroDecimal nuDecimal)
        {
            return !(nuDecimal.numero == Conversor.BinarioDecimal(nuBinario.numero));
        }
    }
}
