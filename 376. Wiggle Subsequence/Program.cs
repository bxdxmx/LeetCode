public class Solution
{
    /*
     * dp[i,+]  // 最大値、小、大、小、大、・・・
     * dp[i,-]  // 最小値、大、小、大、小、・・・
    */

    public int WiggleMaxLength(int[] nums)
    {
        int longest1 = 0, longest2 = 0;
        int[] dp1 = new int[nums.Length + 1];
        int[] dp2 = new int[nums.Length + 1];

        for (int i = 0; i <= nums.Length; i++)
        {
            dp1[i] = i % 2 == 1 ? int.MaxValue : int.MinValue;
            dp2[i] = i % 2 == 1 ? int.MinValue : int.MaxValue;
        }
        dp1[0] = int.MaxValue;
        dp2[0] = int.MinValue;

        for (int i = 0; i < nums.Length; i++)
        {
            for (int j = 0; j <= longest1; j++)
            {
                if ((j % 2 == 0 && dp1[j] > nums[i] && dp1[j + 1] > nums[i]) ||
                   ((j % 2 == 1 && dp1[j] < nums[i] && dp1[j + 1] < nums[i])))
                {
                    dp1[j + 1] = nums[i];
                    longest1 = Math.Max(longest1, j + 1);
                }
            }

            for (int j = 0; j <= longest2; j++)
            {
                if ((j % 2 == 0 && dp2[j] < nums[i] && dp2[j + 1] < nums[i]) ||
                   ((j % 2 == 1 && dp2[j] > nums[i] && dp2[j + 1] > nums[i])))
                {
                    dp2[j + 1] = nums[i];
                    longest2 = Math.Max(longest2, j + 1);
                }
            }
        }

        return Math.Max(longest1, longest2);
    }
}
