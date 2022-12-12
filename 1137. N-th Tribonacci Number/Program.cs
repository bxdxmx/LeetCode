public class Solution
{
    public int Tribonacci(int n)
    {
        int[] dp = new int[4] { 0, 1, 1, 0 };

        if (n <= 2)
        {
            return dp[n];
        }
        else
        {
            for (int i = 3; i <= n; i++)
            {
                dp[3] = dp[2] + dp[1] + dp[0];
                dp[0] = dp[1];
                dp[1] = dp[2];
                dp[2] = dp[3];
            }

            return dp[3];
        }
    }
}
