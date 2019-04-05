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
            ListNode l1 = new ListNode(1);
            ListNode l2 = new ListNode(2);
            //l1.next = l2;
            ListNode l3 = new ListNode(3);
            l2.next = l3;
            ListNode l4 = new ListNode(4);
            l3.next = l4;
            ListNode l5 = new ListNode(5);
            l4.next = l5;
            ListNode l6 = new ListNode(6);
            l5.next = l6;
            Test t = new Test();
            No_203 e = new No_203();
            e.RemoveElements(l1, 1);
            Console.WriteLine();
            Console.ReadKey();
        }
    }
}
