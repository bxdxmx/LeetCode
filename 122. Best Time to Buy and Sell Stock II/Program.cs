public class Solution
{
    // p[i] < p[i+1] : profit += (p[i+1]-p[i]), i++
    // p[i] > p[i+1] : i++


    public int MaxProfit(int[] prices)
    {
        int profit = 0;

        for (int i = 0; i < prices.Length - 1; i++)
        {
            if (prices[i] < prices[i + 1])
            {
                profit += (prices[i + 1] - prices[i]);
            }
        }

        return profit;
    }
}
