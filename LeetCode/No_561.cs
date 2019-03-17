using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCode
{
    class No_561
    {
        public int ArrayPairSum(int[] nums)
        {
            int ans=0;
            int n = nums.Length / 2;
            Array.Sort(nums);
            for(int i = 0; i < n; i++)
            {
                ans += nums[i * 2];
            }
            return ans;
        }
    }
}
