public class Solution
{
    public int NumSquares(int n)
    {
        int[] dp = new int[n + 1];

        for (int i = 1; i <= n; i++)
        {
            int temp = dp[i - 1];

            for (int j = (int)Math.Sqrt(i); j > 0; j--)
            {
                temp = Math.Min(temp, dp[i - j * j]);
            }

            dp[i] = temp + 1;
        }

        return dp[n];
    }
}
