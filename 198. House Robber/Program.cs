public class Solution
{
    // DPで
    // dp[i]：i番目までで最大となる値を記録しておく。
    // dp[i] = max(dp[i] + dp[i-2], dp[i-1]);

    public int Rob(int[] nums)
    {
        int dp1 = nums[0], dp2 = 0;

        for (int i = 1; i < nums.Length; i++)
        {
            nums[i] = Math.Max(nums[i] + dp2, dp1);
            dp2 = dp1;
            dp1 = nums[i];
        }

        return nums[^1];
    }
}
