var s = new Solution();

s.MinimumPartition("165462", 60);
s.MinimumPartition("238182", 5);

public class Solution
{
    /*
     * dp[i]:i桁目での最小のパーティション数
     * 
     * dp[i+1] = min( dp[i]+1, dp[i-kの桁数]+1)
     * 
     */

    public int MinimumPartition(string s, int k)
    {
        int[] dp = new int[s.Length + 1];
        Array.Fill(dp, int.MaxValue);
        dp[0] = 0;

        int kl = 0;
        int temp = k;

        while (temp > 0)
        {
            kl++;
            temp /= 10;
        }

        for (int i = 0; i < s.Length; i++)
        {
            bool canDivide = false;

            for (int j = 0; j < kl; j++)
            {
                if (i - j < 0)
                {
                    continue;
                }

                int n = int.Parse(s[(i-j)..(i+1)]);

                if (n <= k)
                {
                    canDivide = true;
                    dp[i+1] = Math.Min(dp[i] + 1, dp[i - j] + 1);
                }
            }

            if (!canDivide)
            {
                return -1;
            }
        }

        return dp[^1];
    }
}
