using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCode
{
    class No_142
    {
        public ListNode DetectCycle(ListNode head)
        {
            if (head == null)
                return null;
            ListNode p1 = head, p2 = head, p3 = head;
            while (p1.next != null && p2.next != null && p2.next.next != null)
            {
                p1 = p1.next;
                p2 = p2.next.next;
                if (p1 == p2)
                {
                    while (p1 != p3)
                    {
                        p1 = p1.next;
                        p3 = p3.next;

                    }
                    return p1;
                }
            }
            return null;
        }
    }
}
