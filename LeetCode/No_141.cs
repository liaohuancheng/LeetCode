using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCode
{
    class No_141
    {
        public bool HasCycle(ListNode head)
        {
            var p1 = head;
            var p2 = head;
            while (true)
            {
                if (p2 == null || p2.next == null)
                    return false;
                p2 = p2.next.next;
                p1 = p1.next;
                if (p1 == p2)
                    return true;
            }
        }
    }
}
