using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCode
{
    class Test
    {
        static void Main(string[] args)
        {
            int[] z = new int[4]{ 2, 7, 11, 15 };
            Test t = new Test();
            No_167 e = new No_167();
            int[] a = e.TwoSum(z, 9);
            Console.WriteLine();
            Console.ReadKey();
        }
    }
}
