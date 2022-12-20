
/*
 * Given an m x n 2D binary grid grid which represents a map of '1's (land) and '0's (water), return the number of islands.

An island is surrounded by water and is formed by connecting adjacent lands horizontally or vertically. You may assume all four edges of the grid are all surrounded by water.
*/

public class Solution
{
    public int NumIslands(char[][] grid)
    {
        int m = grid.Length, n = grid[0].Length;
        int count = 0;
        const char visited = 'V', water = '0';

        void Land(int y, int x)
        {
            if (x < 0 || x >= n || y < 0 || y >= m || grid[y][x] == visited || grid[y][x] == water)
            {
                return;
            }

            grid[y][x] = visited;
            Land(y, x - 1);
            Land(y, x + 1);
            Land(y - 1, x);
            Land(y + 1, x);
        }

        for (int y = 0; y < m; y++)
        {
            for (int x = 0; x < n; x++)
            {
                if (grid[y][x] == '1')
                {
                    count++;
                    Land(y, x);
                }
            }
        }

        return count;
    }
}