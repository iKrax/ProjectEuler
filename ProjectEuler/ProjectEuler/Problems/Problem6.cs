using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjectEuler.Problems
{
    class Problem6 : Problem
    {        
        public override string name { get { return "Problem 6"; } }
        public override string description { get { return "Sum square difference"; } }

        public override object execute()

        {
            int SumOfSquares = 0;
            int SquareOfSum = 0;

            for (int i = 0; i <= 100; i++)
            {
                SumOfSquares += Convert.ToInt32(Math.Pow(Convert.ToDouble(i), 2));
                SquareOfSum += i;
            }
            SquareOfSum = Convert.ToInt32(Math.Pow(Convert.ToDouble(SquareOfSum), 2));

            return SquareOfSum - SumOfSquares;
        }
    }
}
