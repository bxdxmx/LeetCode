public class NumArray
{
    private int[] nums;

    public NumArray(int[] nums)
    {
        this.nums = nums;
    }

    public int SumRange(int left, int right)
    {
        return nums.Skip(left).Take(right - left + 1).Sum();
    }
}
