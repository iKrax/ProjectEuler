using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjectEuler.Problems
{
    class Problem4 : Problem
    {        
        public override string name { get { return "Problem 4"; } }
        public override string description { get { return "Largest palindrome product"; } }

        public override object execute()

        {
            //This is slightly hacky but it works.. feel free to make it better
            int total = 12;

            while (!isPalindrome(total.ToString()))
            {
                for (int a = 999; a > 600; a--)
                {
                    for (int b = 999; b > 600; b--)
                    {
                        total = a * b;
                        if (isPalindrome(total.ToString()))
                        {
                            return total;
                        }   
                    }
                }
            }

            return 0;
        }

        public bool isPalindrome(string i)
        {
            string c = Reverse(i);

            
            if (i == c)
            {
                return true;
            }
            return false;
        }

        public static string Reverse(string s)
        {
            char[] cArray = s.ToCharArray();
            Array.Reverse(cArray);
            return new string(cArray);
        }
    }
}
