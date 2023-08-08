using System;

namespace Problems
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


    class AddTwoNumbersProblem
    {
        public static void Solution()
        {
            ListNode ln1 = new ListNode(7, new ListNode(4, new ListNode(3)));
            ListNode ln2 = new ListNode(5, new ListNode(6, new ListNode(9)));
            AddTwoNumbers(ln1, ln2);
        }

        public static ListNode? AddTwoNumbers(ListNode l1, ListNode l2)
        {

            ListNode dummyHead = new ListNode(0);
            ListNode pointer = dummyHead;
            ListNode currentNodeList1 = l1;
            ListNode currentNodeList2 = l2;
            var carry = 0;

            while (currentNodeList1 != null || currentNodeList2 != null || carry != 0)
            {
                var val1 = currentNodeList1?.val ?? 0;
                var val2 = currentNodeList2?.val ?? 0;
                var unitDigit = (val1 + val2 + carry) % 10;
                carry = (val1 + val2 + carry) / 10;
                pointer.next = new ListNode();
                pointer = pointer.next;
                pointer.val = unitDigit;
                currentNodeList1 = currentNodeList1?.next;
                currentNodeList2 = currentNodeList2?.next;
            }

            return dummyHead.next;
        }

    }


    /*
            ListNode dummyHead = new ListNode(0);
            ListNode curr = dummyHead;
            int carry = 0;
            while (l1 != null || l2 != null || carry != 0) {
                int x = (l1 != null) ? l1.val : 0;
                int y = (l2 != null) ? l2.val : 0;
                int sum = carry + x + y;
                carry = sum / 10;
                curr.next = new ListNode(sum % 10);
                curr = curr.next;
                if (l1 != null)
                    l1 = l1.next;
                if (l2 != null)
                    l2 = l2.next;
            }
            return dummyHead.next;
    */


    /* ======= Complexity explained
    Time complexity : O(max⁡(m,n))O(\max(m, n))O(max(m,n)). Assume that mmm and nnn represents the length of l1l1l1 and l2l2l2 respectively, the algorithm above iterates at most max⁡(m,n)\max(m, n)max(m,n) times.
    Space complexity : O(1)O(1)O(1). The length of the new list is at most max⁡(m,n)+1\max(m,n) + 1max(m,n)+1 However, we don't count the answer as part of the space complexity.
    */

}