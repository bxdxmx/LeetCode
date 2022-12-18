public class Solution
{
    // dp[i]：その時の最大価値を格納

    // dp[i,持ってる] = max(dp[i-1,持ってない] - p[i], dp[i-1,持ってる])
    // dp[i,持ってない] = max(dp[i-1,持ってる] + p[i] - fee, dp[i-1,持ってない])

    // maxProfit = max( maxProfit, dp[i,持ってる], dp[i,持ってない])
    // ->dp[i,持ってない]でOK

    public int MaxProfit(int[] prices, int fee)
    {
        int dpHave = -prices[0], dpNotHave = 0;
//        int maxProfit = 0;

        for (int i = 1; i < prices.Length; i++)
        {
            (dpHave, dpNotHave) = (
                Math.Max(dpNotHave - prices[i], dpHave),
                Math.Max(dpHave + prices[i] - fee, dpNotHave)
            );
//            maxProfit = new int[] { maxProfit, dpHave, dpNotHave }.Max();
        }

        return dpNotHave;
//        return maxProfit;
    }
}
