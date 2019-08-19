using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCode
{
    class No_344
    {
        public string ReverseString(char[] b)
        {
            
            int start = 0, end = b.Length - 1;
            while (start < end)
            {
                char tmp;
                tmp = b[start];
                b[start++] = b[end];
                b[end--] = tmp;
            }
            string ans = new string(b);
            return ans;
        }
    }
}
