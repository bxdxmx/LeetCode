using System.Runtime.CompilerServices;

public class Solution
{
    public int[] SortArrayByParity(int[] nums)
    {
        return nums
            .OrderBy(n => n, Comparer<int>.Create((x, y) => (x & 1) - (y & 1)))
            .ToArray();
    }
}
