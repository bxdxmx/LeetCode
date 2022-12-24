var s = new Solution();

s.MatrixBlockSum(
    new int[3][]
    {
        new int[3] {1,2,3},
        new int[3] {4,5,6},
        new int[3] {7,8,9}
    },
    1);

public class Solution
{
    /*
     * dp[i,j] = (0,0)..(i,j)の合計値
     * dp[i,j] = dp[i-1,j] + dp[i,j-1] - dp[i-1,j-1] + mat[i,j]
     * 
     * r[i,j] = dp[i+k,j+k] - dp[i-k-1,j+k] - dp[i+k,j-k-1] + dp[i-k-1,j-k-1]
     */

    public int[][] MatrixBlockSum(int[][] mat, int k)
    {
        int m = mat.Length, n = mat[0].Length;

        int[,] dp = new int[m, n];

        for (int i = 0; i < m; i++)
        {
            for (int j = 0; j < n; j++)
            {
                dp[i, j] =
                    (i - 1 >= 0 ? dp[i - 1, j] : 0) +
                    (j - 1 >= 0 ? dp[i, j - 1] : 0) -
                    (i - 1 >= 0 && j - 1 >= 0 ? dp[i - 1, j - 1] : 0) +
                    mat[i][j];
            }
        }

        var res = new int[m][];
        for (int i = 0; i < m; i++)
        {
            res[i] = new int[n];
        }

        for (int i = 0; i < m; i++)
        {
            for (int j = 0; j < n; j++)
            {
                res[i][j] =
                    dp[Math.Min(i + k, m - 1), Math.Min(j + k, n - 1)] -
                    (i - k - 1 >= 0 ? dp[i - k - 1, Math.Min(j + k, n - 1)] : 0) -
                    (j - k - 1 >= 0 ? dp[Math.Min(i + k, m - 1), j - k - 1] : 0) +
                    (i - k - 1 >= 0 && j - k - 1 >= 0 ? dp[i - k - 1, j - k - 1] : 0);
            }
        }

        return res;
    }
}
