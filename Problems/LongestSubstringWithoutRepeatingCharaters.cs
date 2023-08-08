using System;

namespace Problems
{
    class LongestSubstringWithoutRepeatingCharaters
    {
        public static void Solution()
        {
            string chars = "abba";
            LengthOfLongestSubstring(chars);
        }

        public static int LengthOfLongestSubstring(string chars)
        {
            int maxLenght = 0, leftIndex = 0;
            Dictionary<char, int> charsWithIndexes = new Dictionary<char, int>();
            for (int rightIndex = 0; rightIndex < chars.Length; rightIndex++)
            {
                char character = chars[rightIndex];
                if (charsWithIndexes.ContainsKey(character))
                {
                    leftIndex = Math.Max(charsWithIndexes[character] + 1, leftIndex);
                }
                charsWithIndexes[character] = rightIndex;
                maxLenght = Math.Max(rightIndex - leftIndex + 1, maxLenght);
            }
            return maxLenght;
        }


        /* ======= Complexity explained

        */
    }
}