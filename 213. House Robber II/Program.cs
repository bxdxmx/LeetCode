using System.Runtime.Intrinsics.Arm;

public class Solution
{
    // DPで
    // dp[i]：i番目までで最大となる値を記録しておく。
    // dp[i] = max(dp[i] + dp[i-2], dp[i-1]);

    // circularなので
    // 2～nと1～n-1の2つやって大きい方を返す。

    public int Rob(int[] nums)
    {
        if (nums.Length <= 2)
        {
            return nums.Max();
        }

        int SubRob(int[] nums, int start, int end)
        {
            int dp0 = 0, dp1 = nums[start - 1], dp2 = 0;

            for (int i = start; i < end; i++)
            {
                dp0 = Math.Max(nums[i] + dp2, dp1);
                dp2 = dp1;
                dp1 = dp0;
            }

            return dp0;
        }

        return Math.Max(SubRob(nums, 2, nums.Length), SubRob(nums, 1, nums.Length - 1));

/*
        if ( nums.Length <= 2 )
        {
            return nums.Max();
        }

        int dp0 = 0, dp1, dp2, max1, max2;

        // 2~n
        {
            dp1 = nums[1];
            dp2 = 0;

            for (int i = 2; i < nums.Length; i++)
            {
                dp0 = Math.Max(nums[i] + dp2, dp1);
                dp2 = dp1;
                dp1 = dp0;
            }

            max1 = dp0;
        }

        // 1~n-1
        {
            dp1 = nums[0];
            dp2 = 0;

            for (int i = 1; i < nums.Length - 1; i++)
            {
                dp0 = Math.Max(nums[i] + dp2, dp1);
                dp2 = dp1;
                dp1 = dp0;
            }

            max2 = dp0;
        }

        return Math.Max(max1, max2);
*/
    }
}
