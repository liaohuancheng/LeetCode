using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCode
{
    class No_11
    {
        public int MaxArea(int[] height)
        {
            int start = 0, end = height.Length-1;
            int ans = 0;
            while (start != end)
            {
                ans = Math.Max(Math.Min(height[start], height[end]) * (end - start ), ans);
                if (height[start] > height[end])
                {
                    end--;
                }
                else
                {
                    start++;
                }
            }
            return ans;
        }
    }
}
