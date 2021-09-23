using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades31PuestoAtencion
{
    public class Negocio
    {
        private PuestoAtencion caja;
        private Queue<Cliente> clientes;
        private string nombre;

        private Negocio()
        {
            this.clientes = new Queue<Cliente>();
            this.caja = new PuestoAtencion(PuestoAtencion.Puesto.Caja1);
        }

        public Negocio(string nombre)
            : this()
        {
            this.nombre = nombre;
        }

        public Cliente Cliente
        {
            get
            {
                return clientes.Dequeue();
            }
            set
            {
                bool retorno;
                //this es la instancia del negocio y value representa al cliente que recibo
                retorno = this + value;
            }
        }

        public int ClientesPendientes
        {
            get
            {
                return this.clientes.Count;
            }
        }

        public static bool operator == (Negocio n, Cliente c)
        {
            bool retorno = false;
            foreach (Cliente cliente in n.clientes)
            {   
                if(cliente == c)
                {
                    retorno = true;
                }
            }
            return retorno;
        }

        public static bool operator !=(Negocio n, Cliente c)
        {            
            return !(n == c);
        }

        public static bool operator + (Negocio n, Cliente c)
        {
            bool retorno = false;

            if(n != c)
            {
                n.clientes.Enqueue(c);
                retorno = true;
            }
            return retorno;
        }

        /*public static bool operator -(Negocio n, Cliente c)
        {
            bool retorno = false;

            if (n == c)  
            {
                n.clientes.Dequeue();
                retorno = true;
            }
            return retorno;
        }*/
        
        public static bool operator ~ (Negocio n)
        {
            if(n.clientes.Count > 0)
            {
                return n.caja.Atender(n.Cliente);//voy quitando clientes cada 3 segundos.
            }
            else
            {
                return false;
            }            
        }
    }
}
