using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjectEuler.Problems
{
    class Problem3 : Problem
    {        
        public override string name { get { return "Problem 3"; } }
        public override string description { get { return "Largest prime factor"; } }

        public override object execute()

        {
            long newnum = 600851475143;
            long largestFact = 0;

            int i = 2;
            while (i * i <= newnum)
            {
                if (newnum % i == 0)
                {
                    newnum = newnum / i;
                    largestFact = i;
                }
                else
                {
                    i++;
                }
            }
            if (newnum > largestFact)
            {
                largestFact = newnum;
            }

            return largestFact;
        }
        
    }
}
