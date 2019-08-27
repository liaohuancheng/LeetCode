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
            //ListNode head = new ListNode(0);

            //ListNode l1 = new ListNode(1);
            //head.next = l1;
            //ListNode l2 = new ListNode(2);
            //l1.next = l2;
            //ListNode l3 = new ListNode(3);
            //l2.next = l3;
            //ListNode l4 = new ListNode(4);
            //l3.next = l4;
            string[] s = { "eat", "tea", "tan", "ate", "nat", "bat" };

            GroupAnagram groupAnagram = new GroupAnagram();
            Console.Write(groupAnagram.GroupAnagrams(s));
            Console.Read();
        }
    }
}
