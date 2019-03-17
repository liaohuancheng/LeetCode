using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCode
{
    class No_747
    {
        public int DominantIndex(int[] nums)
        {

            int max_num = 0;
            int max_num_index=0;
            int sercond_num = 0;
            for (int i = 0; i < nums.Length; i++)
            {
                if (nums[i] > max_num)
                {
                    sercond_num = max_num;
                    max_num = nums[i];
                    max_num_index = i;
                }
                else if (nums[i] > sercond_num)
                {
                    sercond_num = nums[i];
                }
            }
            return max_num >= 2 * sercond_num ? max_num_index : -1;

        }
    }
}
