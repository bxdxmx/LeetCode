// See https://aka.ms/new-console-template for more information
Console.WriteLine("Hello, World!");

public class Solution
{
    public void Merge(int[] nums1, int m, int[] nums2, int n)
    {
        for( int i = nums1.Length - 1, cnt = n-1; cnt >= 0; --i, --cnt )
        {
            nums1[i] = nums2[cnt];
        }

        Array.Sort(nums1);
    }
}