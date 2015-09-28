using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjectEuler.Problems
{
    class Problem10 : Problem
    {
        public override string name { get { return "Problem 10"; } }
        public override string description { get { return "Summation of primes"; } }

        public override object execute()
        {
            long sum = 2;

            for (int i = 3; i < 2000000; i += 2)
            {
                if (isPrime(i))
                {
                    sum += i;
                }
            }

            return sum;
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
    