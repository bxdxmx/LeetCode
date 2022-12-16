public class Solution
{
    // 2, 3, -2, 4

    // i番目までの値で取り得る最大値と最小値をいれておく。

    // dp[i,max] =  max(dp[i-1,max] * nums[i], dp[i-1,min] * nums[i], nums[i])
    // dp[i,min] =  min(dp[i-1,max] * nums[i], dp[i-1,min] * nums[i], nums[i])

    public int MaxProduct(int[] nums)
    {
        int dpmax = nums[0];
        int dpmin = nums[0];
        int max = nums[0];

        for (int i = 1; i < nums.Length; i++)
        {
            (dpmax, dpmin) = (
                new int[] { nums[i], nums[i] * dpmax, nums[i] * dpmin }.Max(),
                new int[] { nums[i], nums[i] * dpmax, nums[i] * dpmin }.Min()
            );

            max = Math.Max(max, dpmax);
        }

        return max;

        // ↑メモリ節約版
        /*
        int[] dpmax = new int[nums.Length];
        int[] dpmin = new int[nums.Length];

        dpmax[0] = nums[0];
        dpmin[0] = nums[0];
        int max = nums[0];

        for (int i = 1; i < nums.Length; i++)
        {
            dpmax[i] = new int[] { nums[i], nums[i] * dpmax[i - 1], nums[i] * dpmin[i - 1] }.Max();
            dpmin[i] = new int[] { nums[i], nums[i] * dpmax[i - 1], nums[i] * dpmin[i - 1] }.Min();

            max = Math.Max(max, dpmax[i]);
        }

        return max;
        */
    }
}
