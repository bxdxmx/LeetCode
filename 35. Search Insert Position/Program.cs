public class Solution
{
    public int SearchInsert(int[] nums, int target)
    {
        int start = 0, end = nums.Length;

        while (start < end)
        {
            int index = start + (end - start) / 2;

            if (nums[index] == target)
            {
                return index;
            }
            else if (nums[index] > target)
            {
                end = index;
            }
            else
            {
                start = index + 1;
            }
        }

        return end;
    }
}
