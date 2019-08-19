using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCode
{
    class No_63
    {
        public int UniquePaths(int m, int n)
        {
            int[,] a = new int[m, n];
            for(int i = 0; i < Math.Max(m, n); i++)
            {
                if (i < m)
                {
                    a[i, 0] = 1;
                }
                if (i < n)
                {
                    a[0, i] = 1;
                }
            }
            for(int i = 1; i < m; i++)
            {
                for(int j = 1; j < n; j++)
                {
                    a[i, j] = a[i - 1, j] + a[i, j - 1];
                }
            }
            return a[m - 1, n - 1];
        }
    }
}
