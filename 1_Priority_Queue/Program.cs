using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _1_Priority_Queue
{
    public class Node<T>
    {

        public T Data { get; set; }

        public int Priority { get; set; }

    }



    public class PriorityQueue<T>
    {

      
        private readonly List<Node<T>> val;
        public PriorityQueue()
        {
            val = new List<Node<T>>();

        }



        public void Offer(T data, int priority)
        {

            val.Add(new Node<T>() { Data = data, Priority = priority });

        }



        public T Take()
        {

            if (val.Count == 0)
            {

                return default;

            }


            var item = val.OrderByDescending(varData=>varData.Priority).First();
           
            val.Remove(item);

            return item.Data;

        }

    }
    internal class Program
    {
        static void Main(string[] args)
        {
            
            PriorityQueue<String> pq = new PriorityQueue<String>();

            pq.Offer("Hello", 0);

            pq.Offer("Adform", 0);

            pq.Offer("World", 1);

            pq.Offer("Welcome", 0);

            pq.Offer("Here", 2);



            System.Console.WriteLine(pq.Take()); //Prints "Here"

            System.Console.WriteLine(pq.Take()); //Prints "World"

            System.Console.WriteLine(pq.Take()); //Prints "Hello"

            System.Console.WriteLine(pq.Take()); //Prints "Adform"

            System.Console.WriteLine(pq.Take()); //Prints "Welcome"
          
        }
    }
}
