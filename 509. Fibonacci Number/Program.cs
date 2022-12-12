public class Solution
{
    public int Fib(int n)
    {
        int[] dp = new int[3] { 0, 1, 0 };

        if (n <= 1)
        {
            return dp[n];
        }
        else
        {
            for (int i = 2; i <= n; i++)
            {
                dp[2] = dp[1] + dp[0];
                dp[0] = dp[1];
                dp[1] = dp[2];
            }

            return dp[2];
        }
    }

    public int Fib2(int n)
    {
        int[] dp = new int[n+2];
        dp[0] = 0;
        dp[1] = 1;

        for (int i = 2; i <= n; i++)
        {
            dp[i] = dp[i - 2] + dp[i - 1];
        }

        return dp[n];
    }
}
