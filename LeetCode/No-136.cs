using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCode
{
    class No_136
    {
        public int SingleNumber(int[] nums)
        {
            if (nums.Length == 0)
                return 0;
            int ans = nums[0];
            int l = nums.Length;
            for(int i = 1; i < l; i++)
            {
                ans = nums[i] ^ ans;
            }
            return ans;
        }
    }
}
