public class Solution
{
    public int MinDistance(string word1, string word2)
    {
        int[,] dp = new int[word1.Length + 1, word2.Length + 1];

        for (int i = 0; i < dp.GetLength(0); i++)
        {
            for (int j = 0; j < dp.GetLength(1); j++)
            {
                if (i == 0 || j == 0)
                {
                    dp[i, j] = Math.Max(i, j);
                }
                else
                {
                    if (word1[i - 1] != word2[j - 1])
                    {
                        dp[i, j] =
                            Math.Min(
                               Math.Min(dp[i - 1, j], dp[i, j - 1]) + 1,
                               dp[i - 1, j - 1] + 1);
                    }
                    else
                    {
                        dp[i, j] = dp[i - 1, j - 1];
                    }
                }
            }
        }
        return dp[dp.GetLength(0) - 1, dp.GetLength(1) - 1];
    }
}
