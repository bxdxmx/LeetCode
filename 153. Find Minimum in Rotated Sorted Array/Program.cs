public class Solution
{
    public int FindMin(int[] nums)
    {
        int SubFindMin(int left, int right)
        {
            if (left > right)
            {
                return -1;
            }

            int m = left + (right - left) / 2;

            if (m != 0 && nums[m] - nums[m - 1] < 0)
            {
                return m;
            }
            else
            {
                int index = SubFindMin(m + 1, right);
                if (index < 0)
                {
                    index = SubFindMin(left, m - 1);
                }

                return index;
            }
        }

        int firstPos = nums.Length == 1 ? 0 : SubFindMin(0, nums.Length - 1);

        if (firstPos < 0)
        {
            firstPos = 0;
        }

        return nums[firstPos];
    }
}
