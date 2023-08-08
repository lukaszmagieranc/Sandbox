using System;

namespace Problems
{
    class ValidParenthesis
    {
        public static void Solution()
        {
            var s = "()";
            Console.WriteLine(CheckIfStringContainingBracketsIsCorrect(s));
        }

        public static bool CheckIfStringContainingBracketsIsCorrect(string s)
        {
            var bracketPairs = new Dictionary<char, char>() { { '(', ')' }, { '[', ']' }, { '{', '}' } };
            var stackOfCharacters = new Stack<char>();
            foreach (char character in s)
            {
                if (bracketPairs.ContainsKey(character))
                {
                    stackOfCharacters.Push(character);
                }
                else
                {
                    if (stackOfCharacters.Count == 0)
                    {
                        return false;
                    }
                    char topCharacter = stackOfCharacters.Pop();
                    if (bracketPairs[topCharacter] != character)
                    {
                        return false;
                    }
                }
            }
            return stackOfCharacters.Count == 0;
        }


        /* ======= Complexity explained
            Time: O(n) because we only iterate once and all operations in the loop are constant time
            Space: O(n) because we will use the maxmum of n characters on the stack (even less in fact but pesimistically n)
        */
    }
}