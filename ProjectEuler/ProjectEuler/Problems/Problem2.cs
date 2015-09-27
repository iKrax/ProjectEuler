using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjectEuler.Problems
{
    class Problem2 : Problem
    {        
        public override string name { get { return "Problem 2"; } }
        public override string description { get { return "Even Fibonacci numbers"; } }

        public override object execute()
        {
            int sum = 0;
            int prev_term = 0;
            int curr_term = 1;
            

            while (curr_term < 4000000)
            {
                // Add current term to sum if even
                if ((curr_term % 2) == 0)
                {
                    sum += curr_term;
                }
                
                //Store previous term
                int temp = prev_term;
                prev_term = curr_term;

                // Calculate next term
                curr_term += temp;
       
            }

            return sum;
        }
    }
}
