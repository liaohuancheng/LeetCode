using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCode
{
    class No_169
    {
        public int MajorityElement(int[] nums)
        {
            int ans=nums[0];
            int count = 1;
            int l = nums.Length;
            for(int i = 1; i < l; i++)
            {
                if (ans == nums[i])
                {
                    count++;
                }
                else
                {
                    count--;
                }
                if (count == 0)
                {
                    ans = nums[i];
                    count = 1;
                }
                    
            }
            return ans;
        }
    }
}
