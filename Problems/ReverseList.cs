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


        /* ======= Complexity explained

        */
    }
}