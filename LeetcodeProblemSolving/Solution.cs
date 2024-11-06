﻿namespace LeetcodeProblemSolving
{
    public class ListNode
    {
        public int val;
        public ListNode next;
        public ListNode(int val = 0, ListNode next = null)
        {
            this.val = val;
            this.next = next;
        }
    }
    public class Solution
    {
        public ListNode AddTwoNumbers(ListNode l1, ListNode l2)
        {
            ListNode dummyHead = new ListNode(0); // Dummy head to simplify handling the result list
            ListNode current = dummyHead;
            int carry = 0;

            while (l1 != null || l2 != null || carry != 0)
            {
                int sum = carry;

                if (l1 != null)
                {
                    sum += l1.val;
                    l1 = l1.next;
                }

                if (l2 != null)
                {
                    sum += l2.val;
                    l2 = l2.next;
                }

                // Calculate new digit and carry
                carry = sum / 10;
                current.next = new ListNode(sum % 10);
                current = current.next;
            }

            return dummyHead.next; // Return the next node to skip the dummy head
        }
    }
}