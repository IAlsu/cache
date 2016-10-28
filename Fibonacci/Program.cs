using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Fibonacci
{
    class Program
    {
        

        static void Main(string[] args)
        {
            // Examples show that we dont't calculate for "2" after first time
            Cache cache = new Cache();
            string sequence = cache.Caching("2");
            Console.WriteLine("2" +" : " + sequence);

            sequence = cache.Caching("2");
            Console.WriteLine("2" + " : " + sequence);

            sequence = cache.Caching("a");
            Console.WriteLine("5" + " : " +  sequence);

            sequence = cache.Caching("11");
            Console.WriteLine("11" + " : " + sequence);

            sequence = cache.Caching("2");
            Console.WriteLine("2" + " : " + sequence);

            Console.ReadLine();
        }
    }
}
