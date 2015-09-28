using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjectEuler.Problems
{
    class Problem9 : Problem
    {
        public override string name { get { return "Problem 9"; } }
        public override string description { get { return "Special Pythagorean triplet"; } }

        public override object execute()
        {
            for (int i = 1; i < 1000; i++)
            {
                for (int ii = 1; ii < 1000; ii++)
                {
                    if (isPythagTriplet(i, ii))
                    {
                        if (i + ii + Math.Sqrt((Math.Pow(i, 2) + Math.Pow(ii, 2))) == 1000)
                        {
                            return i * ii * Math.Sqrt((Math.Pow(i, 2) + Math.Pow(ii, 2)));
                        }
                    }
                }
            }
            return false;
        }

        bool isPythagTriplet(int a, int b)
        {
            if (Math.Sqrt((Math.Pow(a,2) + Math.Pow(b,2))) % 1 == 0)
            {
                return true;
            }
            return false;
        }
}
}
    