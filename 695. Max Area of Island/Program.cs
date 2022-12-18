public class Solution
{
    // islandの数ではなくて、一番大きいエリアの面積を返す。

    public int MaxAreaOfIsland(int[][] grid)
    {
        int m = grid.Length, n = grid[0].Length;
        int visited = -1;
        int maxArea = 0;

        int EnqueueArea(int y, int x)
        {
            if (x < 0 || x >= n || y < 0 || y >= m || grid[y][x] == 0 || grid[y][x] == visited)
            {
                return 0;
            }

            grid[y][x] = visited;

            return
                EnqueueArea(y - 1, x) +
                EnqueueArea(y + 1, x) +
                EnqueueArea(y, x - 1) +
                EnqueueArea(y, x + 1) +
                1;
        }

        for (int i = 0; i < m; i++)
        {
            for (int j = 0; j < n; j++)
            {
                if (grid[i][j] == 1)
                {
                    maxArea = Math.Max(maxArea, EnqueueArea(i, j));
                }
            }
        }

        return maxArea;
    }
}
