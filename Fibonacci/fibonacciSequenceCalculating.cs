using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Fibonacci
{
    class FibonacciSequenceCalculating
    {
        private int calcFibNum(int n)
        {
            if (n == 0) return 0;
            if (n == 1) return 1;
            return calcFibNum(n - 1) + calcFibNum(n - 2);
        }

        public string calcFibSeq(int n)
        {
            string sequence = "";
            
            int[] seq = Enumerable.Range(0, n).ToArray();
            foreach (var i in seq)
            {
                sequence = sequence + "  " +calcFibNum(i);
            }
            return sequence;
        }

    }
}
