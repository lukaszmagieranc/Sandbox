using System;

namespace Problems
{
    class CountingBits
    {
        public static void Solution()
        {
            FastSolution(10);
        }

        public static int NormalSolution(uint n)
        {
            uint c = 0;

            while (n != 0)
            {
                c += n & 1;
                n = n >> 1;
            }

            return (int)c;
        }

        public static int FastSolution(uint n)
        {
            int sum = 0;

            while (n != 0)
            {
                sum++;
                n &= (n - 1);
            }

            return sum;
        }


        /* ======= Complexity explained

        */
    }
}