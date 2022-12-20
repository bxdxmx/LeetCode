/*
 * You are given an m x n grid where each cell can have one of three values:

0 representing an empty cell,
1 representing a fresh orange, or
2 representing a rotten orange.
Every minute, any fresh orange that is 4-directionally adjacent to a rotten orange becomes rotten.

Return the minimum number of minutes that must elapse until no cell has a fresh orange. If this is impossible, return -1.
 * 
 */

public class Solution
{
    public int OrangesRotting(int[][] grid)
    {
        int m = grid.Length, n = grid[0].Length;
        var rottenQ = new Queue<(int y, int x)>();
        int freshCount = 0;
        int minute = 0;

        for (int y = 0; y < m; y++)
        {
            for (int x = 0; x < n; x++)
            {
                if (grid[y][x] == 2)
                {
                    rottenQ.Enqueue((y, x));
                }
                else if (grid[y][x] == 1)
                {
                    freshCount++;
                }
            }
        }

        while (freshCount != 0 && rottenQ.Any())
        {
            bool isUpdate = false;
            var temp = new Queue<(int y, int x)>();

            while (rottenQ.Any())
            {
                var (y, x) = rottenQ.Dequeue();

                void update(int y, int x)
                {
                    if (x < 0 || x >= n || y < 0 || y >= m || grid[y][x] != 1)
                    {
                        return;
                    }

                    isUpdate = true;
                    temp.Enqueue((y, x));
                    grid[y][x] = 0;
                    freshCount--;
                }

                update(y, x - 1);
                update(y, x + 1);
                update(y - 1, x);
                update(y + 1, x);
            }

            if (isUpdate)
            {
                minute++;
                rottenQ = temp;
            }
            else
            {
                break;
            }
        }

        return freshCount != 0 ? -1 : minute;
    }
}
