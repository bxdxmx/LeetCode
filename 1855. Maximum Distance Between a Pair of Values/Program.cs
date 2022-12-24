var s = new Solution();

int[] nums1 = new int[] { 55, 30, 5, 4, 2 };
int[] nums2 = new int[] { 100, 20, 10, 10, 5 };

s.MaxDistance(nums1, nums2);

public class Solution
{
    public int MaxDistance(int[] nums1, int[] nums2)
    {
        int maxD = 0;

        for (int i = 0; i < nums1.Length; i++)
        {
            int start = i;
            int end = nums2.Length - 1;
            int index = -1;

            while (start <= end)
            {
                int m = start + (end - start) / 2;

                if (nums1[i] <= nums2[m])
                {
                    start = m + 1;
                    index = m;
                }
                else
                {
                    end = m - 1;
                }
            }

            maxD = Math.Max(maxD, index - i);
        }

        return maxD;
    }
}
