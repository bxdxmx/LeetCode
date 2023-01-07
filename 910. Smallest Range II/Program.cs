var s = new Solution();

int[] nums = new int[] { 4, 7, 4 };
int k = 4;

s.SmallestRangeII(nums, k);

public class Solution
{
    public int SmallestRangeII(int[] nums, int k)
    {
        Array.Sort(nums);
        int ans = nums[^1] - nums[0];

        for (int i = 0; i < nums.Length - 1; i++)
        {
            int high = Math.Max(nums[^1] - k, nums[i] + k);
            int low = Math.Min(nums[0] + k, nums[i + 1] - k);
            ans = Math.Min(ans, high - low);
        }

        return ans;
    }
}
