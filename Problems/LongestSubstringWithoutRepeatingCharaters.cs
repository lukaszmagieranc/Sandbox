using System;

namespace Problems
{
    class LongestSubstringWithoutRepeatingCharaters
    {
        public static void Solution()
        {
            string chars = "abba";
            // LengthOfLongestSubstring(chars);
            LengthOfLongestSubstringBruteForce(chars);
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

        public static int LengthOfLongestSubstringBruteForce(string chars)
        {
            int maxLenght = 0;
            int charsLength = chars.Length;
            for (int leftIndex = 0; leftIndex < charsLength; leftIndex++)
            {
                for (int rightIndex = leftIndex; rightIndex < charsLength; rightIndex++)
                {
                    if (!checkIfSubsctringContainsDuplicateCharacters(chars, leftIndex, rightIndex))
                    {
                        maxLenght = Math.Max(maxLenght, rightIndex - leftIndex + 1);
                    }
                }
            }
            return maxLenght;
        }

        private static bool checkIfSubsctringContainsDuplicateCharacters(string s, int start, int end)
        {
            int[] chars = new int[128];

            for (int i = start; i <= end; i++)
            {
                char character = s[i];
                chars[character]++;
                if (chars[character] > 1) return true;
            }

            return false;
        }


        /* ======= Complexity explained

        */
    }
}