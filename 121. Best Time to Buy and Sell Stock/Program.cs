public class Solution
{
    // max( maxvalue, prices[i] - prices[..i-1]の最低値)

    public int MaxProfit(int[] prices)
    {
        int maxProfit = 0;
        int minPrice = int.MaxValue;

        for (int i = 1; i < prices.Length; i++)
        {
            minPrice = Math.Min(minPrice, prices[i - 1]);
            maxProfit = Math.Max(maxProfit, prices[i] - minPrice);
        }

        return maxProfit;
    }
}
