using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Clase1
{
    public static class MiClaseEstatica
    {
        public static string Mensaje(int i)//metodo
        {
            string[] miArray = new string[10];//new es una instancia
            miArray[0] = "Hola";
            string[] otroArray = new string[17];
            miArray.CopyTo(otroArray, 3);//copias dentro de otroArray desde la posicion 3 el array miArray
            otroArray[3] = "chau";

            //return "Este es mi primer metodo estatico: " + i;
            //string[] s = string.Format("Este es mi primer metodo estatico: {0}", i).Split(" ");//separa el string cada palabra por separado


            //return string.Format("Este es mi primer metodo estatico: {0} {1} ", 
            //    i, DateTime.Now.ToString());//Format metodo estatico. Date permite imprimir la fecha y hora

            //return string.Format("Este es mi primer metodo estatico: {0} {1} ",
            //    i, DateTime.Now.Year.ToString());//imprime el año

            return string.Format("Este es mi primer metodo estatico: {0} {1} ",
                i, DateTime.Now.AddDays(-2).Day.ToString());//imprime que dia fue hace 2 dias


            //StringBuilder sb = new StringBuilder();//así se instacia
            //sb.Append("Este es mi primer metodo estatico: ");//metodos

            //sb.AppendLine(i.ToString());
            //return sb.ToString();

        }
    }
}
