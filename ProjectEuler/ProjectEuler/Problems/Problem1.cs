using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjectEuler.Problems
{
    class Problem1 : Problem
    {        
        public override int id { get { return 1; } }
        public override string name { get { return "Problem 1"; } }
        public override string description { get { return "Multiples of 3 and 5"; } }

        public override object execute()
        {
            var sum = 0;
            for (var i = 0; i < 1000; i++)
            {
                if ((i % 3) == 0 || (i % 5) == 0)
                {
                    sum += i;
                }
            }

            return sum;
        }
    }
}
