using System;

namespace LeetCode
{
    public class ListNode
    {
        public int val;
        public ListNode next;
        public ListNode(int x)
        {
            val = x;
            next = null;
        }
        public void show(ListNode node)
        {
            Console.Write(node.val + "  ");
            if (node.next != null)
                show(node.next);
        }
    }
}