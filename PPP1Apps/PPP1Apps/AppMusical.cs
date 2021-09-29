using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PPP1Apps
{
    public class AppMusical : Aplicacion
    {
        private List<string> listaCanciones;

        protected override int Tamanio
        {
            get
            {
                return base.tamanioMb + listaCanciones.Count * 2;
            }
        }

        public AppMusical(string nombre, SistemaOperativo sistemaOperativo, int tamanioInicial)
            : this (nombre, sistemaOperativo, tamanioInicial, new List<string>() ) 
        { }

        public AppMusical(string nombre, SistemaOperativo sistemaOperativo, int tamanioInicial, List<string>listaCanciones)
            : base(nombre, sistemaOperativo, tamanioInicial)
        {
            if (listaCanciones is null)
            {
                this.listaCanciones = new List<string>();
            }
            else
            {
                this.listaCanciones = listaCanciones;
            }
        }

        public override string ObtenerInformacion()
        {
            StringBuilder sb = new StringBuilder();

            sb.AppendLine(base.ObtenerInformacion());
            sb.AppendLine("Lista de Canciones: ");

            foreach (string cancion in this.listaCanciones)
            {
                sb.AppendLine(cancion);
            }

            return sb.ToString();
        }


    }
}
