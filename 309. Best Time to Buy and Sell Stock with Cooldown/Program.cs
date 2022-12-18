public class Solution
{
    // dp[i]：その時の最大価値を格納

    // dp[i,持ってる] = max(dp[i-1,持ってない] - p[i], dp[i-1,持ってる])
    // dp[i,持ってない] = max(dp[i-1,クール], dp[i-1,持ってない])
    // dp[i,クール] = max(dp[i-1,持ってる] + p[i], dp[i-1,クール])

    // maxProfit = max( dp[i,持ってない], dp[i,クール])

    public int MaxProfit(int[] prices)
    {
        int dpHave = -prices[0], dpNotHave = 0, dpCool = 0;

        for (int i = 1; i < prices.Length; i++)
        {
            (dpHave, dpNotHave, dpCool) = (
                Math.Max(dpNotHave - prices[i], dpHave),
                Math.Max(dpCool, dpNotHave),
                Math.Max(dpHave + prices[i], dpCool)
            );
        }

        return Math.Max(dpNotHave, dpCool);
    }
}
