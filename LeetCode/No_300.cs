using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCode
{
    class No_300
    {
        public int LengthOfLIS(int[] nums)
        {
            if (nums.Length == 0)
                return 0;
            int[] dp = new int[nums.Length];
            for (int i = 0; i < dp.Length; i++)
                dp[i] = 1;
            for (int i = 0; i < nums.Length; i++)
            {
                for (int j = 0; j < i; j++)
                {
                    if (nums[i] <= nums[j])
                        dp[i] = Math.Max(dp[i], dp[j] + 1);
                }
            }
            return dp.Max();
        }
    }
}
