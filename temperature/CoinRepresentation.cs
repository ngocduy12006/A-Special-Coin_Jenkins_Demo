using System;
using System.Text;
using System.Text.RegularExpressions;
using System.Collections;
using System.Collections.Generic;

namespace CoinRepresentation
{
    public class CoinRepresentation
    {
        private static Dictionary<long, long> Z = new Dictionary<long, long>();
        private static bool isEven(long sum)
        {
            if (sum % 2 == 0) return true;
            return false;
        }

        public static long Solve(long sum)
        {
            if (sum == 1 || sum == 0) return 1;
            if (Z.ContainsKey(sum))
            {
                return Z[sum];
            }
            long result;
            if (isEven(sum) == false)
            {
                 result =  Solve((sum - 1) / 2);
            }
            else
            {
                 result = Solve(sum / 2) + Solve((sum -2)/2);
            }

            Z[sum] = result;
            return result; 
        }

    }
}