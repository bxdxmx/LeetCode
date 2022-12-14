public class Solution
{
    // 2つの辺の長さを足し合わせると残りの1つの辺の長さより長くなる。
    // また、2の辺の長さを引いた時、残りの1つの辺の長さより短くなる。

    public int LargestPerimeter(int[] nums)
    {
        Array.Sort(nums, (a, b) => b - a);

        for (int i = 0; i < nums.Length - 2; i++)
        {
            var ns = new int[] { nums[i], nums[i + 1], nums[i + 2] };

            int sum = ns.Sum();

            if ((nums[i] < sum - nums[i]) && (sum - nums[i] - (nums[i + 2] * 2) < nums[i]))
            {
                return sum;
            }
        }

        return 0;
    }
}
