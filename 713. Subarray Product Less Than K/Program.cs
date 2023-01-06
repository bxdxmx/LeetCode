public class Solution
{
    public int NumSubarrayProductLessThanK(int[] nums, int k)
    {
        int res = 0;

        if (k <= 1)
        {
            return res;
        }

        int product = 1, left = 0;

        for (int right = 0; right < nums.Length; right++)
        {
            product *= nums[right];

            while (product >= k)
            {
                product /= nums[left++];
            }

            res += right - left + 1;
        }

        return res;
    }
}
