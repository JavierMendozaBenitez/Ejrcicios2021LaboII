using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades42
{
    public class OtraClase
    {
        public void MiMetodoDeInstancia()
        {
            MiClase miClase;

            try
            {
                miClase = new MiClase(20);
            }
            catch(UnaExcepcion ex)
            {                
                throw new MiExcepcion("Mi excepcion en OtraClase", ex);
            }
        }
    }
}
