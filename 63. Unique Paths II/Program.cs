public class Solution
{
    /*
     * dp[i,j] = dp[i-1,j] + dp[i,j-1]
     * dp[0,0] = 0
     * dp[1,0] = 1
     * dp[0,1] = 1;
     * 
     */

    public int UniquePathsWithObstacles(int[][] obstacleGrid)
    {
        int m = obstacleGrid.Length, n = obstacleGrid[0].Length;

        int[,] dp = new int[m, n];
        dp[0, 0] = 1;

        for (int i = 0; i < m; i++)
        {
            for (int j = 0; j < n; j++)
            {
                if (obstacleGrid[i][j] == 1)
                {
                    dp[i, j] = 0;
                }
                else
                {
                    dp[i, j] = Math.Max(
                        dp[i, j],
                        (i - 1 >= 0 ? dp[i - 1, j] : 0) + (j - 1 >= 0 ? dp[i, j - 1] : 0));
                }
            }
        }

        return dp[m - 1, n - 1];
    }
}
