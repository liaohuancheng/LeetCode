using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCode
{
    class No_724
    {
        public int PivotIndex(int[] nums)
        {
            int sum = 0;
            int tmp = 0;
            for(int i = 0; i < nums.Length; i++)
            {
                sum += nums[i];
            }
            for(int i = 0; i < nums.Length; i++)
            {
                if(tmp==(sum-nums[i])/2&& (sum - nums[i]) % 2==0)
                    return i;
                tmp += nums[i];
                
            }
            return -1;
        }
    }
}
