using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades17
{
    public class Boligrafo
    {   //atributos 
        public const short cantidadTintaMaxima = 100;//al ser constante se le asigna un valor ahora
        private ConsoleColor color;
        private short tinta;

        public Boligrafo(short tinta, ConsoleColor color)//Constructor
        {
            this.tinta = tinta;
            this.color = color;
        }
        public ConsoleColor GetColor()
        {   
            return this.color;
        }
        public short GetTinta()
        {
            return this.tinta;
        }
        public bool Pintar(short gasto, out string dibujo)
        {
            string cadenaAux = string.Empty;
            bool returAux = false;
            if (this.tinta == 0)
            {
                dibujo = "No se puede Pintar ya que no se posee tinta";
            }
            else
            {
                //Generamos un bucle para ir adicionando * a cadena Aux segun el gasto de tinta a realizar

                while (gasto > 0 && this.tinta > 0)
                {
                    cadenaAux += "*";
                    gasto--; //decrementamos el gasto recibido
                    this.SetTinta(-1); //gastamos tinta
                }
                dibujo = cadenaAux;
                returAux = true;

            }
            return returAux;
        }

        private void SetTinta(short tinta)
        {
            short auxTinta = 0;
            auxTinta = this.tinta;
            auxTinta += tinta;

            if (auxTinta >= 0 && auxTinta <= cantidadTintaMaxima)
            {
                this.tinta = auxTinta;
            }
            else if(auxTinta > cantidadTintaMaxima)
            {
                this.tinta = cantidadTintaMaxima;
            }
            else
            {
                this.tinta = 0;
            }
        }
        public void Recargar()
        {
            SetTinta(cantidadTintaMaxima);
        }

    }
}
