public class Solution
{
    // nums1.Intersect(nums2).ToArray();だと重複が除かれてしまう。
    // nums1.Where(n => nums2.Contains(n)).ToArray();もダメ。
    public int[] Intersect(int[] nums1, int[] nums2)
    {
        var list = new List<int>();
        Array.Sort(nums1);
        Array.Sort(nums2);

        int i = 0, j = 0;

        while (i < nums1.Length && j < nums2.Length)
        {
            if (nums1[i] == nums2[j])
            {
                list.Add(nums1[i]);
                i++;
                j++;
            }
            else if (nums1[i] > nums2[j])
            {
                j++;
            }
            else
            {
                i++;
            }
        }

        return list.ToArray();
    }
}
