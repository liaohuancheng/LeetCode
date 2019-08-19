using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCode
{
    class No_139
    {
        
        public bool WordBreak(string s, IList<string> wordDict)
        {
            bool[] dp = new bool[s.Length+1] ;
            for(int i = 0; i < dp.Length;i++)
            {
                dp[i] = false;
            }
           
            dp[0] = true;
            for(int i = 1; i <= s.Length;i++)
            {
                for(int j = i-1; j >=0; j--)
                {
                    foreach(var w in wordDict)
                    {
                        if (dp[j] && s.Substring(j, i - j).Equals(w))
                        {
                            dp[i] = true;
                            break;
                        }
                    }
                    
                }
            }
            return dp[s.Length];
        }
    }
}
