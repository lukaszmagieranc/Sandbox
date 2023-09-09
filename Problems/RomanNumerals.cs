using System;

namespace Problems
{
    class RomanNumerals
    {
        public static void Solution()
        {

        }

        private static Dictionary<string, int> values = new Dictionary<string, int>()
    {
        { "I", 1 },
        { "V", 5 },
        { "X", 10 },
        { "L", 50 },
        { "C", 100 },
        { "D", 500 },
        { "M", 1000 },
        { "IV", 4 },
        { "IX", 9 },
        { "XL", 40 },
        { "XC", 90 },
        { "CD", 400 },
        { "CM", 900 }
    };

        public static int RomanToInt(string romanNumber)
        {
            int sum = 0;
            int i = 0;
            while (i < romanNumber.Length)
            {
                if (i < romanNumber.Length - 1)
                {
                    string doubleSymbol = romanNumber.Substring(i, 2);
                    // Check if this is the length-2 symbol case.
                    if (values.ContainsKey(doubleSymbol))
                    {
                        sum += values[doubleSymbol];
                        i += 2;
                        continue;
                    }
                }
                // Otherwise, it must be the length-1 symbol case.
                string singleSymbol = romanNumber.Substring(i, 1);
                sum += values[singleSymbol];
                i += 1;
            }
            return sum;
        }


        /* ======= Complexity explained
            Time: O(1) only because we have max number of roman characters in the question, it'd be O(n) if it was not specified
            Space: O(1) 
        */
    }
}