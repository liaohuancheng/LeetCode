using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCode
{
    class No_498
    {
        public int[] FindDiagonalOrder(int[,] matrix)
        {
            int index = 0;
            int[] ans = new int[matrix.Length];
            int r = 0, c = 0, k = 0;
            int m = matrix.GetLength(0), n = matrix.GetLength(1);
            int[,] dirs = new int[2, 2] { { -1, 1 }, { 1, -1 } };
            while (index != matrix.Length)
            {
                ans[index++] = matrix[r,c];
                r += dirs[k,0];
                c += dirs[k,1];
                if (r >= matrix.GetLength(0)) { r = m - 1; c += 2; k = 1 - k; }
                if (c >= matrix.GetLength(1)) { c = n - 1; r += 2; k = 1 - k; }
                if (r < 0) { r = 0; k = 1 - k; }
                if (c < 0) { c = 0; k = 1 - k; }
            }
            return ans;
        }
    }
}
