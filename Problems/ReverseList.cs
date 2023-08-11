using System;
using System.Collections;

namespace Problems
{
    class ReverseList
    {

        public static void Solution()
        {
            ListNode head = new ListNode(1, new ListNode(2, new ListNode(3, new ListNode(4))));
            ReverseLinkedList(head);
        }



        // Time: O(n)
        // Space: O(1)
        public static ListNode ReverseLinkedList(ListNode head)
        {
            if (head == null)
            {
                return head;
            }

            ListNode prevNode = null;
            ListNode currentNode = head;

            while (currentNode != null)
            {
                ListNode nextNode = head.next;
                currentNode.next = prevNode;
                prevNode = currentNode;
                currentNode = nextNode;
            }

            return prevNode;
        }


        // Time: O(n)
        // Space: O(n)
        public static ListNode ReverseLinkedListRecursive(ListNode head)
        {
            if (head == null || head.next == null)
            {
                return head;
            }

            ListNode reversedList = ReverseLinkedListRecursive(head.next);
            head.next.next = head;
            head.next = null;

            return reversedList;
        }


        /* ======= Complexity explained

        */
    }
}