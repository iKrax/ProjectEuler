using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjectEuler.Problems
{
    class Problem14 : Problem
    {        
        public override string name { get { return "Problem 14"; } }
        public override string description { get { return "Longest Collatz sequence"; } }

        public override object execute()
        {
            long len = 0;
            long strNum = 0;
            long n;

            for (int i = 2; i <= 1000000; i++)
            {
                int length = 1;
                n = i;
                while (n != 1)
                {
                    if ((n % 2) == 0)
                    {
                        n = n / 2;
                    }
                    else
                    {
                        n = n * 3 + 1;
                    }
                    length++;
                }
                
                if (length > len)
                {
                    len = length;
                    strNum = i;
                }
            }
            return strNum;
        }
    }
}
