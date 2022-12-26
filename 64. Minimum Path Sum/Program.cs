﻿public class Solution
{
    /*
     * dp[i,j] = min(dp[i-1,j], dp[i,j-1]) + grid[i][j]
     */

    public int MinPathSum(int[][] grid)
    {
        int m = grid.Length, n = grid[0].Length;

        for (int i = 1; i < m; i++)
        {
            grid[i][0] += grid[i - 1][0];
        }

        for (int j = 1; j < n; j++)
        {
            grid[0][j] += grid[0][j-1];
        }

        for (int i = 1; i < m; i++)
        {
            for (int j = 1; j < n; j++)
            {
                grid[i][j] = Math.Min(grid[i - 1][j], grid[i][j - 1]) + grid[i][j];
            }
        }

        return grid[^1][^1];
    }
}
