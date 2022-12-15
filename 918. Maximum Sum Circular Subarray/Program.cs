public class Solution
{
    public int MaxSubarraySumCircular(int[] nums)
    {
        if (nums.Length == 1)
        {
            return nums[0];
        }

        int n = nums.Length;
        int max = nums[0], min = nums[0], maxResult = nums[0], minResult = nums[0];
        int sum = nums.Sum();

        for (int i = 1; i < n; i++)
        {
            max = Math.Max(max + nums[i], nums[i]);
            maxResult = Math.Max(maxResult, max);

            min = Math.Min(min + nums[i], nums[i]);
            minResult = Math.Min(minResult, min);
        }

        if (minResult == sum)
        {
            return maxResult;
        }

        return Math.Max(maxResult, sum - minResult);
    }
}
