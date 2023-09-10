using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Problems
{
    class TopKElements
    {
        public static void Solution()
        {
            int[] numbers = new int[] { 3, 2, 1, 5, 6, 4 };
            FindKthLargest(numbers, 2);
        }

        public static int FindKthLargest(int[] nums, int k)
        {
            var heap = new PriorityQueue<int, int>();
            foreach (int num in nums)
            {
                heap.Enqueue(num, num);
                if (heap.Count > k)
                {
                    heap.Dequeue();
                }
            }

            return heap.Peek();
        }


        /* ======= Complexity explained

        */
    }
}