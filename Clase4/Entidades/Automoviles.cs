using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public class Automoviles
    {
        public int velocidadActual;
        public Marca marca;

        #region Constructores
        public Automoviles()
            : this(1)
        {}

        public Automoviles(int velocidadInicial)
        {
            this.velocidadActual = velocidadInicial;
        }

        public Automoviles(string velocidadInicial)
            : this(int.Parse(velocidadInicial))
        {
        }

        public Automoviles(string marca, int velocidadInicial)
            : this(new Marca(marca), velocidadInicial)
        {
            //this.marca = marca;
        }

        public Automoviles(Marca marca, int velocidadInicial)
           : this(velocidadInicial)
        {
            this.marca = marca;
        }

        #endregion

        ///// <summary>
        ///// Acelera el automovil de 1 unidad a la vez
        ///// </summary>
        //public void Acelerar()
        //{
        //    this.velocidadActual++;
        //}

        ///// <summary>
        ///// Acelera el automovil en la cantidad de unidades indicadas
        ///// </summary>
        ///// <param name="incremento">Unidades de aceleración</param>
        //public void Acelerar(int incremento)
        //{
        //    this.velocidadActual += incremento;
        //}




        public static Automoviles operator +(Automoviles a, int incremento)
        {
            a.velocidadActual += incremento;
            return a;
        }

        public static bool operator == (Automoviles a, int velocidad)
        {
            return a.velocidadActual == velocidad;
        }

        public static bool operator !=(Automoviles a, int velocidad)
        {
            return !(a == velocidad);
        }

        public static explicit operator int (Automoviles a)
        {
            return a.velocidadActual;
        }
    }
}
