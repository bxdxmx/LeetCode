


public class Solution
{
    public int[] RunningSum(int[] nums)
    {
        var result = new int[nums.Length];
        int sum = 0;

        for(int i=0; i<nums.Length; ++i )
        {
            sum += nums[i];
            result[i] = sum;
        }

        return result;
    }
}