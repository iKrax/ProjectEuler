using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjectEuler.Problems
{
    class Problem7 : Problem
    {        
        public override string name { get { return "Problem 7"; } }
        public override string description { get { return "10001st prime"; } }

        public override object execute()

        {
            int nPrimes = 1;
            int n = 1;

            while (nPrimes < 10001)
            {
                n = n + 2;
                if (isPrime(n))
                {
                    nPrimes++;
                }
            }
            return n;
        }

        public bool isPrime(int n)
        {
            if ((n % 2 == 0) && (n != 2))
            {
                return false;
            }
            int c = 3;
            while ((c * c) <= n)
            {
                if (n % c == 0)
                {
                    return false;
                }
                else
                {
                    c += 2;
                }
            }
            return true;
        }
    }
}
