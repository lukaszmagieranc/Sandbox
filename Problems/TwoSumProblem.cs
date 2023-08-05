using System;

namespace Problems
{
    class TwoSumProblem
    {
        public static void Solution()
        {
            //int[] nums = {9,2,11,15,7,8};
            int[] nums = { 1, 1, 1, 1, 1, 4, 1, 1, 1, 1, 1, 7, 1, 1, 1, 1, 1 };
            int target = 11;
            GetIndexesOfTwoNumbersThatSumUpTo(nums, target)?.ToList().ForEach(i => Console.WriteLine(i.ToString()));
        }

        private static int[] GetIndexesOfTwoNumbersThatSumUpTo(int[] nums, int target)
        {
            Dictionary<int, int> map = new Dictionary<int, int>();
            for (int i = 0; i < nums.Length; i++)
            {
                int missingNumber = target - nums[i];
                if (map.ContainsKey(missingNumber))
                {
                    return new int[] { map[missingNumber], i };
                }

                map.TryAdd(nums[i], i);
            }
            return default;
        }


        private static int[] GetIndexesOfTwoNumbersThatSumUpToGreedy(int[] nums, int target)
        {
            if (nums.Length < 2)
            {
                return new[] { 0, 0 };
            }

            for (int i = 0; i < nums.Length - 1; i++)
            {
                for (int j = i + 1; j < nums.Length; j++)
                {
                    if (nums[i] + nums[j] == target)
                    {
                        return new int[] { i, j };
                    }
                }
            }

            return new[] { 0, 0 };
        }

    }

    // Complexity explained

    /*
        The "two pointers" approach for solving the algorithm question of finding the sum of two elements in an array usually has a time complexity of O(n log(n)). However, it depends on the specific implementation and the problem constraints.
        The typical "two pointers" approach involves sorting the array first and then using two pointers (usually referred to as "left" and "right") to scan the array from both ends to find the desired pair of elements. The reason it has a time complexity of O(n log(n)) is because of the following steps:
        Sorting the array: The most common sorting algorithms (e.g., quicksort, mergesort, etc.) have a time complexity of O(n log(n)).
        Scanning the array: After sorting, the two pointers will move towards each other, and in the worst case, you might have to scan the entire sorted array. This step has a linear time complexity of O(n).
        So, combining the sorting step with the scanning step, the overall time complexity becomes O(n log(n)) + O(n) ≈ O(n log(n)), as the O(n log(n)) term dominates.
        Keep in mind that this analysis assumes that the dominant time-consuming operation is the sorting process. In some cases, the two pointers approach might be optimized to avoid sorting, leading to different time complexities depending on the specific problem and constraints. But in the general case, when the input array needs to be sorted before applying the two pointers approach, the complexity is O(n log(n)).
    */

}
