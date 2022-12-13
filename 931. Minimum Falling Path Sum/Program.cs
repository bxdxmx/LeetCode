public class Solution
{
    // 動的計画法でそのセルでの最低の値を記録していって、
    // 一番下の行で最低の値を答えとすればよい。

    // dp[i][j] = i行目j列の最低の値
    // dp[i][j] = min(dp[i-1][j]+dp[i][j], dp[i-1][j-1]+dp[i][j], dp[i-1][j+1]+dp[i][j])

    public int MinFallingPathSum(int[][] matrix)
    {
        int n = matrix.Length;

        for (int i = 1; i < n; i++)
        {
            for( int j = 0; j < n; j++)
            {
                int v1 = matrix[i - 1][j];
                int v2 = j > 0 ? matrix[i - 1][j - 1] : 10000;
                int v3 = j < n - 1 ? matrix[i - 1][j + 1] : 10000;

                matrix[i][j] += new int[] { v1, v2, v3 }.Min();
            }
        }

        return matrix[n - 1].Min();
    }
}
