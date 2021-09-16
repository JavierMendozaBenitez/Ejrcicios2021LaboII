using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades19
{
    public class Sumador
    {
        private int cantidadSumas;
        
        public Sumador(int cantidadSumas)//constructor
        {
            this.cantidadSumas = cantidadSumas;
        }
        public Sumador()//constructor
            : this(0)
        {}
        public long Sumar(long a, long b)//metodo
        {
            this.cantidadSumas++;
            return a + b;
        }
        public string Sumar(string a, string b)//metodo
        {
            this.cantidadSumas++;
            return a + b;
        }

        public static explicit operator int (Sumador s)//para que el casteo sea explicito
        {
            return s.cantidadSumas;
        }

        public static long operator + (Sumador s1, Sumador s2)//Sobrecargar el operador + para que sume
        {
             s1.cantidadSumas += s2.cantidadSumas;

            return s1.cantidadSumas;
        }
        public static bool operator | (Sumador s1, Sumador s2)//Sobrecargar el operador | para que devuelva true o false
        {      
            return s1.cantidadSumas == s2.cantidadSumas;
        }
    }
}
