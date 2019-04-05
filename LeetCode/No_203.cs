using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCode
{
    class No_203
    {
        public ListNode RemoveElements(ListNode head, int val)
        {
            if (head == null) return null;
            head.next = RemoveElements(head.next, val);
            return head.val == val ? head.next : head;
        }
    }
}
