var s = new Solution();

s.CoinChange(new int[] { 2 }, 3);


public class Solution
{
    /*
     * dp[i,j] : i番目までのコインを使用して、jを実現する最低の回数
     * dp[i,j] = min(dp[i-1,j], dp[i,j-coin[i]] + 1)
     */

    public int CoinChange(int[] coins, int amount)
    {
        int[,] dp = new int[coins.Length + 1, amount + 1];

        for( int i = 0; i < dp.GetLength(0); i++)
        {
            for (int j = 1; j < dp.GetLength(1); j++)
            {
                dp[i, j] = int.MaxValue;
            }
        }

        for (int i = 0; i < coins.Length; i++)
        {
            for (int j = 0; j <= amount; j++)
            {
                dp[i + 1, j] = Math.Min(
                    dp[i, j],
                    (j - coins[i] >= 0 && dp[i + 1, j - coins[i]] != int.MaxValue) ? dp[i + 1, j - coins[i]] + 1 : int.MaxValue
                );
            }
        }

        return dp[coins.Length, amount] == int.MaxValue
            ? -1
            : dp[coins.Length, amount];
    }
}
