public class Solution
{
    // 初期位置は0 or 1
    // stepは1 or 2
    // 初期値を-1からにすればOK
    // step1のループと、step2のループを回して
    // 最小のコストを設定していって、
    // n-1とn-2の小さい方を返せばOK

    // 下のが速い

    // nにいくには、n-2から2歩、n-1から1歩の2通り
    // cost[n] = cost[n] + min(cost[n-2], cost[n-1])
    // return min(cost[n-2], cost[n-1])

    // costの値を変えればdp配列はいらなくなるけど、わかりやすさのためにこのままでいいか

    public int MinCostClimbingStairs(int[] cost)
    {
        if (cost.Length <= 2)
        {
            return Math.Min(cost[0], cost[1]);
        }
        else
        {
            var dp = new int[3] { cost[0], cost[1], 0 };

            for (int i = 2; i < cost.Length; i++)
            {
                dp[2] = cost[i] + Math.Min(dp[0], dp[1]);
                dp[0] = dp[1];
                dp[1] = dp[2];
            }

            return Math.Min(dp[0], dp[1]);
        }
    }
}
