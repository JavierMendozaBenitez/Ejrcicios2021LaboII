using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public class Persona
    {
        private string nombre;//argumentos privados
        private int edad;
        public static string tipo;//atributo estatico

        static Persona()//Constructor estático 
        {
            Persona.tipo = "Humano";
        }

        /*public static void AlterarObjetoRecibido(Persona p4)//metodo para modificar un objeto copiado
        {
            p4.nombre = "Alterado";
        }*/
        public static bool AlterarObjetoRecibido(Persona p4)//metodo para modificar un objeto copiado
        {
            //if (!object.ReferenceEquals(p4, null))//analiza si la direccion del stack es null o si apuntan al mismo lugar
            if(!(p4 is null))//si p4 es null
            {
                p4.nombre = "Alterado";
                return true;
            }    
            return false;
        }

        public Persona(string nombre, int edad)//constructor. Es para modificar el objeto
        {
            this.nombre = nombre;//asignamos nombre a this.nombre
            this.edad = edad;
        }

        public void SetNombre(string nombre)//metodos para mostrar como se modifica un objeto si lo copias a otro
        {
            this.nombre = nombre;
        }

        public string GetNombre()//metodos
        {
            return this.nombre;
        }
        public int GetEdad()//metodos
        {
            return this.edad;
        }

        public string GetTipo()//metodos
        {
            return Persona.tipo;
        }
    }
}
