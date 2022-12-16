public class Solution
{
    public int[] SearchRange(int[] nums, int target)
    {
        int start = 0, end = nums.Length - 1, middle = 0;

        while (start <= end)
        {
            middle = start + (end - start) / 2;

            if (nums[middle] == target)
            {
                break;
            }
            else if (nums[middle] > target)
            {
                end = middle - 1;
            }
            else if (nums[middle] < target)
            {
                start = middle + 1;
            }
        }

        if (start > end)
        {
            return new int[] { -1, -1 };
        }

        int left = SubSearchRange(nums, start, middle - 1, target, true);
        int right = SubSearchRange(nums, middle+1, end, target, false);

        return new int[] { left == -1 ? middle : left, right == -1 ? middle : right };
    }

    private int SubSearchRange(int[] nums, int start, int end, int target, bool left)
    {
        int index = -1;

        while (start <= end)
        {
            int middle = start + (end - start) / 2;

            if (nums[middle] == target)
            {
                index = middle;

                if (left)
                {
                    end = middle - 1;
                }
                else
                {
                    start = middle + 1;
                }
            }
            else if (nums[middle] > target)
            {
                end = middle - 1;
            }
            else if (nums[middle] < target)
            {
                start = middle + 1;
            }
        }

        return index;
    }
}
