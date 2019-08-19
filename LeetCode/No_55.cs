using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCode
{
    class No_55
    {
        public bool CanJump(int[] nums)
        {
            if (nums.Length == 1)
                return true;
            int max = 0;
            for(int i = 0; i < nums.Length-1; i++)
            {
                if (max >= i)
                {
                    max = Math.Max(nums[i] + i, max);
                }
                if (max >= nums.Length-1)
                    return true;
            }
            return false;

        }

        
    }
}
