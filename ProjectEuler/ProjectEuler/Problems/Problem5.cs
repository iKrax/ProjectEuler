using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjectEuler.Problems
{
    class Problem5 : Problem
    {        
        public override string name { get { return "Problem 5"; } }
        public override string description { get { return "Smallest multiple"; } }

        public override object execute()

        {
            long temp = 20;


            while (true)
            {
                if (evenlyDivisible(temp))
                {
                    return temp;
                }
                temp += 20;
            }
        }

        public bool evenlyDivisible(long n)
        {
            if ((n % 20 == 0) && (n % 19 == 0) && (n % 18 == 0) && (n % 17 == 0) && (n % 16 == 0) && (n % 15 == 0) && (n % 14 == 0) && (n % 13 == 0) && (n % 12 == 0) && (n % 11 == 0))
            {
                return true;
            }
            return false;
        }

    }
}
