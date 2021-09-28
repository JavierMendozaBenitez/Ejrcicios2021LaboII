using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PPP1Libreri
{
    public class Vendedor
    {
        private string nombre;
        private List<Publicacion> ventas;

        private Vendedor()
        {
            this.ventas = new List<Publicacion>();
        }

        public Vendedor (string nombre)
            : this()
        {
            this.nombre = nombre;
        }

        public static string ObtenerInformeDeVentas(Vendedor vendedor)
        {
            float acuGan = 0;

            StringBuilder sb = new StringBuilder();

            sb.AppendLine(vendedor.nombre.ToUpper());
            sb.AppendLine("--------------------------------------");

            foreach (Publicacion publi in vendedor.ventas)
            {
                sb.AppendLine($"PUBLICACIÓN: {publi.ObtenerInformacion()}");
                acuGan += publi.Importe;
            }

            sb.AppendLine($"Ganancia Total: ${acuGan}");

            return sb.ToString();
        }

        public static bool operator + (Vendedor vendedor, Publicacion publicacion)
        {
            bool retorno = false;

            if(publicacion.HayStock)
            {
                vendedor.ventas.Add(publicacion);
                publicacion.Stock--;
                retorno = true;
            }

            return retorno;
        }

    }
}
