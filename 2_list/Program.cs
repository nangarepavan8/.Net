using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2_list
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /*
            var names = new List<string> { "<name>", "Ana", "Felipe" };
            foreach (var name in names)
            {
                Console.WriteLine($"Hello {name.ToUpper()}!");
            }

            */


           // var names = new List<string> { "<name>", "Ana", "kamlesh"};

            /*
            foreach (var name in names)
            {
                Console.WriteLine($"Hello {name.ToUpper()} !");
            }
            */


            /*

            for(int i = 1; i < names.Count; i++)
            {
                Console.WriteLine($"Hello {names[i].ToUpper ()} !");
            }
            */

            /*

            names.Add("Maria");
            names.Add("pavan");
            names.Remove("kamlesh");

            names.Sort();
            foreach (var name in names)
            {
                Console.WriteLine(name);
            }

            */

          //  Console.WriteLine("first index "+ names[1]);

            /*
            var index = names.IndexOf("pavan");
            Console.WriteLine(index);
        */


            var fibonacciNumbers = new List<int> { 1,1};
            while (fibonacciNumbers.Count <20)
            {


                var previous = fibonacciNumbers[fibonacciNumbers.Count - 1];
                var previous2 = fibonacciNumbers[fibonacciNumbers.Count - 2];

                fibonacciNumbers.Add(previous + previous2);
            }
            foreach (var item in fibonacciNumbers)
                Console.WriteLine(item);



        }
    }
}
