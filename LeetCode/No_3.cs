using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections;

namespace LeetCode
{
    class No_3
    {
        public int lengthOfLongestSubstring(string s)
        {
            int l = s.Length;
            int ans = 0;
            Dictionary<char, int> dic = new Dictionary<char, int>();
            for (int j = 0, i = 0; j < l; j++)
            {
                if (dic.ContainsKey(s[j]))
                {
                    i = Math.Max(dic[s[j]], i);
                    dic[s[j]] = j + 1;
                }
                else { dic.Add(s[j], j + 1);}
                ans = Math.Max(ans, j - i + 1);
                
            }
            return ans;
        }

        
    }
}

