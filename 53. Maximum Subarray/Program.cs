public class Solution
{
    // dp[i] = max(dp[i], dp[i]+dp[i-1])

    public int MaxSubArray(int[] nums)
    {
        int max = nums[0];

        for (int i = 1; i < nums.Length; i++)
        {
            nums[i] = Math.Max(nums[i], nums[i] + nums[i - 1]);
            max = Math.Max(max, nums[i]);
        }

        return max;
    }
}
