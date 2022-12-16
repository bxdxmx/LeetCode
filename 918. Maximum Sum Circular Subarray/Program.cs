public class Solution
{
    // 解説
    // https://leetcode.com/problems/maximum-sum-circular-subarray/solutions/2868539/maximum-sum-circular-subarray/?orderBy=hot

    // approach1
    // 通常のkadaneで求めた通常配列の最大部分和と、
    // 先頭からの合計と、それ以外の右側の中での最大部分和を足したものの大きい方を返す。

    // approach2
    // 下のコード
    // 普通のkadaneと一番負の値が大きくなる最小部分和を合計から引けば最大部分和になるでしょうという話

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
