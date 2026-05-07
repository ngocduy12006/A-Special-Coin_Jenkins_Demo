using System;
using System.Text;
using System.Text.RegularExpressions;
using System.Collections;
using System.Collections.Generic;

namespace CoinRepresentation
{
    public class CoinRepresentation
    {
        private static Dictionary<long, long> Z_num = new Dictionary<long, long>();
        private static bool isEven(long sum)
        {
            if (sum % 2 == 0) return true;
            return false;
        }

        public static long Solve(long sum)
        {
            if (sum == 1 || sum == 0) return 1;
            if (Z_num.ContainsKey(sum))
            {
                return Z_num[sum];
            }
            long result;
            if (isEven(sum) == true)
            {
                result = Solve(sum / 2) + Solve((sum - 2) / 2);
                
            }
            else
            {
                result = Solve((sum - 1) / 2);
            }

            Z_num[sum] = result;
            return result; 
        }

    }
}