﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjectEuler.Problems
{
    class Problem8 : Problem
    {
        public override string name { get { return "Problem 8"; } }
        public override string description { get { return "Largest product in a series"; } }

        const string series = "7316717653133062491922511967442657474235534919493496983520312774506326239578318016984801869478851843858615607891129494954595017379583319528532088055111254069874715852386305071569329096329522744304355766896648950445244523161731856403098711121722383113622298934233803081353362766142828064444866452387493035890729629049156044077239071381051585930796086670172427121883998797908792274921901699720888093776657273330010533678812202354218097512545405947522435258490771167055601360483958644670632441572215539753697817977846174064955149290862569321978468622482839722413756570560574902614079729686524145351004748216637048440319989000889524345065854122758866688116427171479924442928230863465674813919123162824586178664583591245665294765456828489128831426076900422421902267105562632111110937054421750694165896040807198403850962455444362981230987879927244284909188845801561660979191338754992005240636899125607176060588611646710940507754100225698315520005593572972571636269561882670428252483600823257530420752963450";
        bool v = true;
        string[] subStr = new string[300];
        int p = 0;

        long highest = 0;

        public override object execute()

        {
            //Create substring
            for (int i = 0; i < series.Length - 12; i++)
            {
                v = true;
                string temp = series.Substring(i, 13);

                //Check substring for 0's
                for (int i2 = 0; i2 < temp.Length; i2++)
                {
                    if (Convert.ToString(temp[i2]) == "0")
                    {
                        v = false;
                        break;
                    }
                }

                //Add all valid substrings to array of strings
                if (v == true)
                {
                    subStr[p] = temp;
                    p++;
                }
            }

            //Calculate products and store highest
            for (int i = 0; i < 300; i++)
            {
                if (subStr[i] == null)
                {
                    break;
                }
                string sTemp = subStr[i];
                long lTemp = 1;
                for (int ii = 0; ii < 13; ii++)
                {
                    lTemp = lTemp * Convert.ToInt64(sTemp[ii]);
                }
                if (highest < lTemp)
                {
                    highest = lTemp;
                }
            }

            

            return highest;
        }
    }
}
    