public class Solution
{
    /*
     * 単純にやるのでは遅い
     * dp[i,j] = その時点での最大の辺の大きさ
     * dp[i,j] = 1 + min(dp[i-1,j], dp[i,j-1], dp[i-1,j-1])
     * 
     */

    public int MaximalSquare(char[][] matrix)
    {
        int m = matrix.Length, n = matrix[0].Length;
        int res = 0;

        int[][] dp = new int[m][];
        for (int i = 0; i < m; i++)
        {
            dp[i] = new int[n];
        }

        for (int i = 0; i < m; i++)
        {
            for (int j = 0; j < n; j++)
            {
                if (matrix[i][j] != '0')
                {
                    dp[i][j] = new int[] {
                        i - 1 >= 0 ? dp[i-1][j] : 0,
                        j - 1 >= 0 ? dp[i][j-1] : 0,
                        i - 1 >=0 && j - 1 >= 0 ? dp[i-1][j-1] : 0
                    }.Min() + 1;

                    res = Math.Max(res, dp[i][j]);
                }
            }
        }

        return res * res;
    }
}
