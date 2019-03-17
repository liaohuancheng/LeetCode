using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCode
{
    class NO_6
    {
        public string Convert(string s, int numRows)
        {

            if (numRows == 1) return s;
            int l = s.Length;
            char[] ans = new char[l];
            int t = 2 * numRows - 2;
            int z = 0;
            bool isUp = false;
            for(int i = 0; i < numRows; i++)
            {
                isUp = false;
                for (int j = 0; i + j < l&&z<l; )
                {
                    
                    if (i == 0 || i == numRows - 1)
                    {
                        ans[z++] = s[i + j];
                        j = j + t ;
                    }
                    else
                    {
                        ans[z++] = s[i + j];
                        if (isUp)
                        {
                            j = j + i * 2;
                        }
                        else
                        {
                            j = j + t - i * 2;
                        }
                        isUp = !isUp;
                        
                    }
                }
            }
            return new string(ans);
        }
    }
}
