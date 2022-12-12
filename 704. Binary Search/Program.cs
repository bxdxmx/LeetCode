var s = new Solution();

Console.WriteLine(s.Search(new int[] { -1, 0, 3, 5, 9, 12 }, 9));

public class Solution
{
    public int Search(int[] nums, int target)
    {
        int start = 0, end = nums.Length - 1;

        while (start <= end)
        {
            int index = (start + end) / 2;

            if (nums[index] == target)
            {
                return index;
            }
            else if (nums[index] > target)
            {
                end = index - 1;
            }
            else if (nums[index] < target)
            {
                start = index + 1;
            }
        }

        return -1;
    }
}
