using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades30CompeAutoF1
{
    public class CompetenciaNoDisponibleException : Exception
    {
        private string nombreClase;
        private string nombreMetodo;

        public CompetenciaNoDisponibleException(string mensaje, string clase, string metodo)
            : base(mensaje)
        {
            this.nombreClase = clase;
            this.nombreMetodo = metodo;
        }

        public CompetenciaNoDisponibleException(string mensaje, string clase, string metodo, Exception innerException)
            : base(mensaje, innerException)
        {
            this.nombreClase = clase;
            this.nombreMetodo = metodo;
        }

        public string NombreClase
        {
            get
            {
                return this.nombreClase;
            }
        }
        public string NombreMetodo
        {
            get
            {
                return this.nombreMetodo;
            }
        }

        public override string ToString()
        {
            /*StringBuilder sb = new StringBuilder();
            //sb.AppendLine("Excepción en el método {0} de la clase {1}:"+ this.NombreMetodo+ this.NombreClase);
            sb.AppendLine("Excepción en el método" + this.NombreMetodo +" de la clase " + this.NombreClase);
            sb.AppendLine("Mensaje: {0}" + base.Message);
            sb.AppendLine("Todos los InnerException: {0}\t"+ base.InnerException);

            return sb.ToString();*/

            StringBuilder sb = new StringBuilder();

            sb.AppendFormat("Excepción en el método {0} de la clase {1}: \n", this.NombreMetodo, this.NombreClase);
            sb.AppendFormat("Mensaje: {0}\n", this.Message);
           
            Exception exInner = this.InnerException;

            while(exInner is not null)
            {
                sb.AppendFormat("Excepcion {0}: \n", exInner.Message);
                sb.AppendFormat("\t Barra T {0}: \n", exInner);

                exInner = exInner.InnerException;
            }

            return sb.ToString();
        }
    }
}
