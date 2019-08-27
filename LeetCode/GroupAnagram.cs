using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCode
{
    class GroupAnagram
    {
        public IList<IList<string>> GroupAnagrams(string[] strs)
        {
            Dictionary<string, List<string>> dict = new Dictionary<string, List<string>>();

            foreach (string s in strs)
            {
                char[] c = s.ToCharArray();
                Array.Sort(c);

                string key = new string(c);
                if (!dict.ContainsKey(key))
                {
                    dict.Add(key, new List<string>());
                }
                dict[key].Add(s);
            }
            IList<IList<string>> res = new List<IList<string>>(dict.Values);

            //foreach (var v in res)
            //{
            //    foreach (var c in v)
            //    {
            //        Console.WriteLine(c);
            //    }
            //    Console.WriteLine("分割");
            //}
            return res;
        }
    }
}
