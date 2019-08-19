using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCode
{
    class HappyNumber
    {
        public bool IsHappy(int n)
        {
            
            List<int> e = new List<int>();
            while (n != 1)
            {
                double tmp = 0;
                while (n != 0)
                {
                    tmp += Math.Pow((n % 10),2);
                    n /= 10;
                }
                n = (int)tmp;
                if (e.Contains(n))
                    break;
                else
                    e.Add(n);
            }
            if (n == 1)
                return true;
            else
                return false;
        }
    }
}
