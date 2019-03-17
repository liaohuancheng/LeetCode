using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCode
{
    class No_5
    {
        public string LongestPalindrome(string s)
        {
            int l = s.Length;
            if (l == 0) return "";
            int start = 0, end = 0;
            
            for(int i = 0; i < l; i++)
            {
                int len1 = 0, len2 = 0, z=0;
                len1 = stringAroundCenter(s, i, i);
                len2 = stringAroundCenter(s, i, i+1);
                z = Math.Max(len1, len2);
                if (z > end - start + 1)
                {
                    start = i - (z - 1) / 2;
                    end = i + z / 2;
                }
                
            }
            return s.Substring(start,end-start+1);
        }

        public int stringAroundCenter(string s,int left,int right)
        {
            int l = s.Length;
            while (left >= 0 && right < l && s[left] == s[right])
            {
                left--;
                right++;
            }
            return right - left - 1; 
        }
    }
}
