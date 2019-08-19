using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCode
{
    class No_322
    {

        public int CoinChange(int[] coins, int amount)
        {
            int[] a = new int[amount];
            return CoinChange(coins, a, amount);

        }

        public int CoinChange(int[] coins, int[] a, int amount)
        {
            if (amount < 0) return -1;
            if (amount == 0) return 0;
            if (a[amount - 1] != 0) return a[amount - 1];
            int min = int.MaxValue;
            foreach(var i in coins)
            {
                int res = CoinChange(coins, a, amount - i);
                if (res >= 0 && res < min)
                    min = 1 + res;
            }
            a[amount - 1] = (min == int.MaxValue) ? -1 : min;
            return a[amount - 1];
            
        }
    }
}
