public class Solution
{
    public int[] ReplaceElements(int[] arr)
    {
        int max = -1, next;

        for(int i = arr.Length-1; i >= 0; i--)
        {
            next = Math.Max(max, arr[i]);
            arr[i] = max;
            max = next;
        }

        return arr;
    }
}
