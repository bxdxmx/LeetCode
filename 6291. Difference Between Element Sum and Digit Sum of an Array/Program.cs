public class Solution
{
    public int DifferenceOfSum(int[] nums)
    {
        int sum = nums.Sum();
        int dsum = 0;

        for(int i = 0; i < nums.Length; i++)
        {
            while (nums[i] > 0)
            {
                dsum += nums[i] % 10;
                nums[i] /= 10;
            }
        }

        return Math.Abs(sum - dsum);
    }
}
