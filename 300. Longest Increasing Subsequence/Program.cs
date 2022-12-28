public class Solution
{
    /*
     * dp[i]：最長がi個の時の一番小さい値を入れておく。
    */

    public int LengthOfLIS(int[] nums)
    {
        int longest = 0;
        int[] dp = new int[nums.Length + 1];
        Array.Fill(dp, int.MaxValue);
        dp[0] = int.MinValue;

        for( int i = 0; i < nums.Length; i++ )
        {
            for (int j = 0; j <= longest; j++)
            {
                if (dp[j] < nums[i] && dp[j+1] > nums[i])
                {
                    dp[j + 1] = nums[i];
                    longest = Math.Max(longest, j + 1);
                }
            }
        }

        return longest;
    }
}
