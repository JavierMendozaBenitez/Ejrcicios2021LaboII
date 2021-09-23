using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades38
{
    public class SobreSobrescrito: Sobrescrito
    {
        public override string MiPropiedad
        {
            get
            {
                return base.miAtributo;
            }
        }
        public override string MiMetodo()
        {
            return this.MiPropiedad;
        }

    }
}
