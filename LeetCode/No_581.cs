using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCode
{
    class No_581
    {
        public int FindUnsortedSubarray(int[] nums)
        {
            int l = nums.Length;
            int[] n = (int[])nums.Clone();
            Array.Sort(nums);
            int i = 0, j = l - 1;
            while (i < l && nums[i] == n[i])
                i++;
            while (j > i + 1 && nums[j] == n[j])
                j--;
            return j - i + 1;
        }
    }
}
