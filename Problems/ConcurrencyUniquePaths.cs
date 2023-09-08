using System;
using System.Threading;

namespace Problems
{
    class ConcurrencyUniquePaths
    {

        public static void Solution()
        {
            // Console.WriteLine($"Number of paths: " + UniquePaths(3,7));
            Console.WriteLine($"Number of paths: " + UniquePathsRecurrence(3,7));
        }

        
        public static int UniquePathsRecurrence(int m, int n)
        {
            if (m <= 1 || n <= 1) {
                return 1;
            } 
            return UniquePathsRecurrence(m-1, n) + UniquePathsRecurrence(m, n-1);
        }


        /* ======= Complexity explained
          ?
        */

        public static int UniquePaths(int m, int n)
        {
            if (m <= 1 || n <= 1) {
                return 1;
            } 
            int[,] grid = new int[m, n];    
            for (int col=0; col < m; col++) {
                for (int row = 0; row < n; row++) {
                    grid[col, row] = 1;
                }
            }
            for (int col=1; col < m; col++) {
                for (int row = 1; row < n; row++) {
                    grid[col, row] = grid[col-1,row] + grid[col,row-1];
                }
            }

            return grid[m-1,n-1];
        }


        /* ======= Complexity explained
            Time complexity: O(N×M)\mathcal{O}(N \times M)O(N×M).
            Space complexity: O(N×M)\mathcal{O}(N \times M)O(N×M).
        */



    }
}