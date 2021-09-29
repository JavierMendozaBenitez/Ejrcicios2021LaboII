using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PPP1Apps
{
    public abstract class Aplicacion
    {
        protected string nombre;
        protected SistemaOperativo sistemaOperativo;
        protected int tamanioMb;

        public SistemaOperativo SistemaOperativo
        {
            get
            {
                return this.sistemaOperativo;
            }
        }

        protected abstract int Tamanio { get; }

        protected Aplicacion(string nombre, SistemaOperativo sistemaOperativo, int tamanioMb)
        {
            this.nombre = nombre;
            this.sistemaOperativo = sistemaOperativo;
            this.tamanioMb = tamanioMb;
        }

        public virtual string ObtenerInformacion()
        {
            StringBuilder sb = new StringBuilder();

            sb.AppendLine("Nombre: " + this.nombre);
            sb.AppendLine("Sistema Operativo:" + this.SistemaOperativo);
            sb.AppendLine("Tamanio Mb: " + this.Tamanio);

            return sb.ToString();
        }

        public static implicit operator Aplicacion(List<Aplicacion> listaApp)
        {
            int maximoTamanio = int.MinValue;

            Aplicacion appMaximoTam = null;

            foreach (Aplicacion app in listaApp)
            {
                if (app.Tamanio > maximoTamanio)
                {
                    maximoTamanio = app.Tamanio;
                    appMaximoTam = app;
                }
            }
            return appMaximoTam;
        }

        public override string ToString()
        {
            return this.nombre;
        }

        public static bool operator ==(List<Aplicacion> listaApp, Aplicacion app)
        {
            foreach (Aplicacion appAux in listaApp)
            {
                if (appAux.nombre == app.nombre)
                {
                    return true;
                }
            }

            return false;
        }
        public static bool operator !=(List<Aplicacion> listaApp, Aplicacion app)
        {
            return !(listaApp == app);
        }

        public static bool operator +(List<Aplicacion> listaApp, Aplicacion app)
        {
            if (listaApp != app)
            {
                listaApp.Add(app);
                return true;
            }
            return false;
        }
    }
}
