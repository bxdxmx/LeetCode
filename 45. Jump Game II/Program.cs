

public class Solution
{
    // 前提として、最後まで到達できない入力はありえない
    // dp[i]：i番目に到達できる最小のジャンプ数を格納する。
    // dp[0] = 0;

    public int Jump(int[] nums)
    {
        int[] dp = new int[nums.Length];
        for (int i = 1; i < nums.Length; i++)
        {
            dp[i] = int.MaxValue;
        }
        dp[0] = 0;

        for (int i = 0; i < nums.Length - 1 ; i++)
        {
            for (int j = i + 1; j <= i + nums[i]; j++)
            {
                dp[j] = Math.Min(dp[j], dp[i] + 1);

                if (j == nums.Length - 1)
                {
                    return dp[nums.Length - 1];
                }
            }
        }

        return 0;
    }
}
