using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCode
{
    class No_485
    {
        public int FindMaxConsecutiveOnes(int[] nums)
        {
            int ans=0;
            for(int i = 0, j = 0; i < nums.Length; i++)
            {
                if (nums[i] == 1)
                {
                    ans = Math.Max(ans, i - j+1);
                }
                else
                {
                    j = i + 1;
                }
            }
            return ans;
        }
    }
}
