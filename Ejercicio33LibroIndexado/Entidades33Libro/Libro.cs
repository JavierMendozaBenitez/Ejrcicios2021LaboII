using System;
using System.Collections.Generic;
using System.Linq;

namespace Entidades33Libro
{
    public class Libro
    {
        private List<string> paginas = new List<string>() { "Chau", "Bye", "Ciao" };
         
        public string this [int i]
        {
            get
            {
                for(int j = 0; j < paginas.Count; j++)
                {
                    if(j == i)
                    {
                        return paginas[i];
                    }
                }
                return " ";
            }
            set
            {
                for (int j = 0; j < paginas.Count; j++)
                {
                    if (j == i)
                    {
                        this.paginas[j] = value;
                    }
                }
                if(i > paginas.Count)
                {
                    this.paginas.Insert(i, value);
                }
            }
        }
    }
}
