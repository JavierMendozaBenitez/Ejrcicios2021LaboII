using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PPP1Apps
{
    public class AppJuegos : Aplicacion
    {
        public AppJuegos(string nombre, SistemaOperativo sistemaOperativo, int tamanio)
            : base(nombre, sistemaOperativo, tamanio)
        {}

        protected override int Tamanio
        {
            get
            {
                return base.tamanioMb;
            }
        }
    }
}
