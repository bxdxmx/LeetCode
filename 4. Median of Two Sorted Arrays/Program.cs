public class Solution
{
    public double FindMedianSortedArrays(int[] nums1, int[] nums2)
    {
        var list = nums1.Concat(nums2).OrderBy(x => x).ToArray();

        return (list.Length & 1) == 1 ? list[list.Length / 2] : (list[list.Length / 2 - 1] + list[list.Length / 2]) / 2.0;
    }
}
