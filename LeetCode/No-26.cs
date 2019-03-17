using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCode
{
    class No_26
    {
        public int RemoveDuplicates(int[] nums)
        {
            int l = nums.Length;
            int ans = 1;
            int j = 0;
            for(int i = 1; i < l;i++ )
            {
                if (nums[i] == nums[j])
                {
                    j++;
                    nums[j] = nums[i];
                }
                
            }
            return ++j;
        }
    }
}
