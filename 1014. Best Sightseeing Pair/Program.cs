public class Solution
{
    // dp[i]：i番目からみたときの最も高い価値をいれておく
    // dp[0] = nums[0]-1
    // dp[i] = max(dp[i-1]-1,nums[i])
    // max = max( max, nums[i] + dp[i-1]-1)

    // 8, 1, 7, 2, 9
    // dp[0] = 8
    // dp[1] = max(8-1,1)=7       7+1=8
    // dp[2] = max(7-1,7)=7       7+6=13
    // dp[3] = max(7-1,2)=6       2+6=8
    // dp[4] = max(6-1,9)=9       9+5=14

    public int MaxScoreSightseeingPair(int[] values)
    {
        int dp = values[0];
        int max = int.MinValue;

        for (int i = 1; i < values.Length; i++)
        {
            max = Math.Max(max, values[i] + dp - 1);
            dp = Math.Max(dp - 1, values[i]);
        }

        return max;
    }
}
