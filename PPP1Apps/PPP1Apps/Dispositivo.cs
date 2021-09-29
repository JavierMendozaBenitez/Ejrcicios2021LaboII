using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PPP1Apps
{
    public static class Dispositivo
    {
        private static List<Aplicacion>appsInstaladas;
        private static SistemaOperativo sistemaOperativo;

        static Dispositivo()
        {
            Dispositivo.appsInstaladas = new List<Aplicacion>();
            Dispositivo.sistemaOperativo = SistemaOperativo.ANDROID;
        }

        public static bool InstalarApp(Aplicacion app)
        {
            if(Dispositivo.sistemaOperativo == app.SistemaOperativo)
            {
                return appsInstaladas + app;
            }

            return false;
        }

        public static string ObtenerInformacionDispositivo()
        {
            StringBuilder sb = new StringBuilder();

            sb.AppendLine("Sistem operativo: "+ sistemaOperativo);

            foreach (Aplicacion app in appsInstaladas)
            {
                sb.AppendLine(app.ObtenerInformacion());
            }

            return sb.ToString();
        }
    }
}
