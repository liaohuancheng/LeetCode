using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCode
{
    class No_160
    {
        public ListNode GetIntersectionNode(ListNode headA, ListNode headB)
        {
            ListNode p1, p2;
            if (headA == null || headB == null) return null;
            p1 = headA;
            p2 = headB;
            while (p1 != p2)
            {
                if (p1 == null)
                    p1 = headB;
                else
                    p1 = p1.next;
                if (p2 == null)
                    p2 = headA;
                else
                    p2 = p2.next;
            }
            return p1;
    }
}
