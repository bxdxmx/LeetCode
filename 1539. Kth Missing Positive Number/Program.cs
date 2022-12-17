public class Solution
{
    public int FindKthPositive(int[] arr, int k)
    {
        int prev = 0;

        foreach (var n in arr)
        {
            int diff = n - prev;

            if (diff > 1)
            {
                if (diff <= k)
                {
                    k -= diff - 1;
                }
                else
                {
                    return prev + k;
                }
            }

            prev = n;
        }

        return arr[^1] + k;
    }
}
