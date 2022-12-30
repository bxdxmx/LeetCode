var s = new Solution();

s.Change(5, new int[] { 1, 2, 5 });

public class Solution
{
    public int Change(int amount, int[] coins)
    {
        int[,] dp = new int[coins.Length + 1, amount + 1];
        dp[0,0] = 1;

        for (int i = 1; i <= coins.Length; i++)
        {
            dp[i,0] = 1;

            for (int j = 1; j <= amount; j++)
            {
                dp[i, j] = dp[i - 1, j] + (j >= coins[i - 1] ? dp[i, j - coins[i - 1]] : 0);
            }
        }

        return dp[coins.Length, amount];
    }
}