var s = new Solution();

Console.WriteLine(s.DeleteAndEarn(new int[] { 3, 4, 2 }));
Console.WriteLine(s.DeleteAndEarn(new int[] { 2, 2, 3, 3, 3, 4 }));
Console.WriteLine(s.DeleteAndEarn(new int[] { 8, 7, 3, 8, 1, 4, 10, 10, 10, 2 }));
Console.WriteLine(s.DeleteAndEarn(new int[] { 8, 3, 4, 7, 6, 6, 9, 2, 5, 8, 2, 4, 9, 5, 9, 1, 5, 7, 1, 4 }));


public class Solution
{
    // dp[i][2]
    //  dp[i][0] = 値iを使用しない場合の最大値 = Max(dp[i-1][0], dp[i-1][1])
    //  dp[i][1] = 値iを使用する場合の最大値 = Max(dp[i-1][1], dp[i-1][0] + i * 件数)
    // 飛び版は0,1ともにi-1の大きい方を入れればOK（飛んでいるということは使ったときに消えることがないから）

    // 最後に、max(dp[件数][0], dp[件数][1])

    public int DeleteAndEarn(int[] nums)
    {
        var d = new Dictionary<int, int>();
        int n = 0;

        foreach (int i in nums)
        {
            if (d.ContainsKey(i))
            {
                d[i] += i;
            }
            else
            {
                d[i] = i;
            }

            if (n < i)
            {
                n = i;
            }
        }

        int dp0 = 0, dp1 = 0;

        for (int i = 0; i <= n; i++)
        {
            if (!d.ContainsKey(i))
            {
                dp0 = dp1 = Math.Max(dp0, dp1);
            }
            else
            {
                (dp0, dp1) = (Math.Max(dp0, dp1), Math.Max(dp1, dp0 + d[i]));
            }
        }

        return Math.Max(dp0, dp1);
    }
}
