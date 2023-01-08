public class Solution
{
    public int MaximumCount(int[] nums)
    {
        return Math.Max(
            nums.Where(n => n < 0 ).Count(),
            nums.Where(n => n > 0 ).Count()
            );
    }
}
