var s = new Solution();

int[] nums = new int[] { 3, 1 };
int target = 1;

Console.WriteLine(s.Search(nums, target));


public class Solution
{
    // n[i]-n[i-1]がマイナスになるポイント
    // n[0..i]とn[i..n.length]で2分探索

    public int Search(int[] nums, int target)
    {
        int SubSearch(int left, int right)
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
                int index = SubSearch(m + 1, right);
                if (index < 0)
                {
                    index = SubSearch(left, m - 1);
                }

                return index;
            }
        }

        int firstPos = nums.Length == 1 ? 0 : SubSearch(0, nums.Length - 1);

        if( firstPos < 0)
        {
            firstPos = 0;
        }

        int result = Array.BinarySearch(nums, 0, firstPos, target);

        if (result >= 0)
        {
            return result;
        }

        result = Array.BinarySearch(nums, firstPos, nums.Length - firstPos, target);

        return result >= 0 ? result : -1;
    }
}
