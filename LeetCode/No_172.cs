using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCode
{
    class No_172
    {
        public int TrailingZeroes(int n)
        {
            int res = 0;
            while (n >= 5)
            {
                res += n / 5;
                n /= 5;
            }
            return res;
        }
    }
}
