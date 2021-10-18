using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades42
{
    public class MiClase
    {
        public MiClase()
        {
            try
            {
                MiClase.MiMetodoEstatico();
            }
            catch(DivideByZeroException)//Relanza sin modificar lo que capturo
            {
                throw;
            }
        }
         
        public MiClase(int numero)
        {
            MiClase miClase; 

            try
            {
                miClase = new MiClase();
            }
            catch (DivideByZeroException ex)
            {
                throw new UnaExcepcion("Mi excepcion en MiClase", ex);
            }
        }
         
        public static void MiMetodoEstatico()
        {
            throw new DivideByZeroException();
        }
    }
}
