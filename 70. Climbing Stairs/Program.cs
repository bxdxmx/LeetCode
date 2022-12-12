public class Solution
{
    // 最初に1歩いくか2歩いくかの2通りある。
    // 最初に1歩行った場合、そのあとはn-1歩通り
    // 最初に2歩行った場合、そのあとはn-2歩通り

    // N(4) = N(3)+N(2)
    // N(n) = N(n-1)+N(n-2)
    // N(1) = 1
    // N(2) = 2

    public int ClimbStairs(int n)
    {
        var dp = new int[3] { 1, 2, 0 };

        if( n <= 2 )
        {
            return dp[n - 1];
        }
        else
        {
            for (int i = 2; i < n; i++)
            {
                dp[2] = dp[1] + dp[0];
                dp[0] = dp[1];
                dp[1] = dp[2];
            }

            return dp[2];
        }
    }
}
