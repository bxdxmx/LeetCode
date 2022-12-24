var s = new Solution();

s.SortByBits(new int[] { 0,1,2,3,4,5,6,7,8});

public class Solution
{
    public int[] SortByBits(int[] arr)
    {
        Array.Sort(arr, (a, b) =>
        {
            int n =
                Convert.ToString(a, 2).Where(c => c == '1').Count() -
                Convert.ToString(b, 2).Where(c => c == '1').Count();

            return n != 0 ? n : a - b;
        });

        return arr;
    }
}
