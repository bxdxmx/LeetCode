public class Solution
{
    /*
     * dp[i]：nがiの時の通り数。i列目にこのミノを置いた時の通り数
     * dp[i] = dp[i,2縦] + dp[i,2横] + dp[i,3上] + dp[i,3下]
     * dp[i,はみ上] = dp[i-1] + [i-1,はみ下]
     * dp[i,はみ下] = dp[i-1] + [i-1,はみ上]
     * 
     * dp[0] = 1
     * dp[1] = 1
     * dp[2] = 2
     * dp[3] = 5
     * dp[4] = 11
     * dp[5] = 24
     * 
     * dp[i,2縦] = dp[i-1]
     * dp[i,2横] = dp[i-2]
     * dp[i,3上] = dp[i-2,はみ上]
     * dp[i,3下] = dp[i-2,はみ下]
     */
    public int NumTilings(int n)
    {
        long[] dp = new long[n + 1];
        long[] dpUD = new long[n + 1];
        dp[0] = 1;
        dp[1] = 1;
        dpUD[0] = 0;
        dpUD[1] = 1;

        for (int i = 2; i <= n; i++)
        {
            (long dp2V, long dp2H, long dp3U, long dp3D) = (
                dp[i - 1],
                dp[i - 2],
                dpUD[i - 2],
                dpUD[i - 2]
                );

            dp[i] = (dp2V + dp2H + dp3U + dp3D) % (long)(Math.Pow(10, 9) + 7);
            dpUD[i] = (dp[i - 1] + dpUD[i - 1]);
        }

        return (int)(dp[n]);
    }
}
