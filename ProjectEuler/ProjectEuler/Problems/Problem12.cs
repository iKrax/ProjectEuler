using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjectEuler.Problems
{
    class Problem12 : Problem
    {        
        public override string name { get { return "Problem 12"; } }
        public override string description { get { return "Highly divisible triangular number"; } }

        public override object execute()
        {
            int number = 0;
            int i = 1;

            while (NumberOfDivisors(number) < 500)
            {
                number += i;
                i++;
            }
            return number;
        }

        private int NumberOfDivisors(int number)
        {
            int n = 0;
            int sqrt = Convert.ToInt32(Math.Sqrt(number));

            for (int i = 1; i <= sqrt; i++)
            {
                if (number % i == 0)
                {
                    n += 2;
                }
            }
            if (sqrt * sqrt == number)
            {
                n--;
            }

            return n;
        }
    }
}
