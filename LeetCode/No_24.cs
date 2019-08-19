using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCode
{
    class No_24
    {
        public ListNode SwapPairs(ListNode head)
        {
            
            if (head == null || head.next==null)
                return head;
            ListNode tmp = head.next;
            Swap(head);
            return head;
        }

        void Swap(ListNode l)
        {
            if (l == null||l.next==null||l.next.next==null)
            {
                return;
            }
            ListNode tmp = l.next;
            l.next = tmp.next;
            tmp.next = l.next.next;
            l.next.next = tmp;
            Swap(tmp);
        }
    }
}
