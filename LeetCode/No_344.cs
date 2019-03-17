using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCode
{
    class No_344
    {
        public string ReverseString(string s)
        {
            char[] b = s.ToCharArray();
            int start = 0, end = s.Length - 1;
            while (start < end)
            {
                char tmp;
                tmp = b[start];
                b[start++] = s[end];
                b[end--] = tmp;
            }
            string ans = new string(b);
            return ans;
        }
    }
}
