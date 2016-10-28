using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Caching;
using System.Text;
using System.Threading.Tasks;

namespace Fibonacci
{
    class Cache
    {
         public string Caching(string key)
        {
            int keyNumber = strToInt(key);
            string sequence;
            if (keyNumber>=0)
            {
                ObjectCache cache = MemoryCache.Default;

                sequence = cache.Get(key) as string;

                if (sequence == null)
                {
                    FibonacciSequenceCalculating fibonacci = new FibonacciSequenceCalculating();
                    sequence = fibonacci.calcFibSeq(keyNumber);
                    cache.Set(key, sequence, ObjectCache.InfiniteAbsoluteExpiration);
                }
            }
            else
            {
                sequence = "It's not an integer number";
            }
            return sequence;
        }

        private int strToInt(string s)
        {
            int j;
            if (!Int32.TryParse(s, out j))
            {
                j = -1;
            }
            return j;
        }
    }

}
