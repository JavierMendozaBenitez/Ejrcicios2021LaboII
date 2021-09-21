using System;
using System.Collections.Generic;

namespace Ejercicio27
{
    class Program
    {
        static void Main(string[] args)
        {
            Random aleatorio = new Random();
            Random aleatorioQueue = new Random();
            Random aleatorioStack = new Random();

            //List
            List<int> numeros = new List<int>();

            for (int i = 0; i < 10; i++)
            {
                numeros.Add(aleatorio.Next(-10, -1));
                numeros.Add(aleatorio.Next(1, 12));
            }

            foreach (int item in numeros)
            {
                Console.WriteLine(item);
            }

            numeros.Sort();
            numeros.Reverse();
            Console.WriteLine("SORT POSITIVO");
            foreach (int item in numeros)
            {
                if (item > 0)
                {
                    Console.WriteLine(item);
                }
            }

            numeros.Reverse();
            Console.WriteLine("SORT NEGATIVO");
            foreach (int item in numeros)
            {
                if (item < 0)
                {
                    Console.WriteLine(item);
                }
            }



            ///Queue
            
            Queue<int> numeroQueue = new Queue<int>();

            for (int i = 0; i < 10; i++)
            {
                numeroQueue.Enqueue(aleatorioQueue.Next(-10, -1));
            }
            for (int i = 10; i < 20; i++)
            {
                numeroQueue.Enqueue(aleatorioQueue.Next(1, 12));
            }
            Console.WriteLine("numeroQueue");
            foreach (int item in numeroQueue)
            {
                Console.WriteLine(item);
            }



            //Queue lo paso a List para ordenar
            List<int> numerosQ = new List<int>(numeroQueue);
            Console.WriteLine("Queue en List");
            foreach (int item in numerosQ)
            {
                Console.WriteLine(item);
            }

            numerosQ.Sort();
            numerosQ.Reverse();
            Console.WriteLine("SORT POSITIVO");
            foreach (int item in numerosQ)
            {
                if (item > 0)
                {
                    Console.WriteLine(item);
                }
            }

            numerosQ.Reverse();
            Console.WriteLine("SORT NEGATIVO");
            foreach (int item in numerosQ)
            {
                if (item < 0)
                {
                    Console.WriteLine(item);
                }
            }



            //stack

            Stack<int> numeroStack = new Stack<int>();

            for (int i = 0; i < 10; i++)
            {
                numeroStack.Push(aleatorioStack.Next(-10, -1));
            }
            for (int i = 10; i < 20; i++)
            {
                numeroStack.Push(aleatorioStack.Next(1, 12));
            }
            Console.WriteLine("numeroStack");
            foreach (int item in numeroStack)
            {
                Console.WriteLine(item);
            }



            //Queue lo paso a List para ordenar
            List<int> numerosS = new List<int>(numeroStack);
            Console.WriteLine("Stack en List");
            foreach (int item in numerosS)
            {
                Console.WriteLine(item);
            }

            numerosS.Sort();
            numerosS.Reverse();
            Console.WriteLine("SORT POSITIVO");
            foreach (int item in numerosS)
            {
                if (item > 0)
                {
                    Console.WriteLine(item);
                }
            }

            numerosS.Reverse();
            Console.WriteLine("SORT NEGATIVO");
            foreach (int item in numerosS)
            {
                if (item < 0)
                {
                    Console.WriteLine(item);
                }
            }

            Console.ReadKey();
        }
    }
}
