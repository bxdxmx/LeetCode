public class Solution
{
    public int FindTheDistanceValue(int[] arr1, int[] arr2, int d)
    {
        Array.Sort(arr2);

        int count = 0;

        for (int i = 0; i < arr1.Length; i++)
        {
            int start = 0, end = arr2.Length - 1;

            while (start < end)
            {
                int m = start + (end - start) / 2;

                if (arr1[i] == arr2[m])
                {
                    end = m;
                    break;
                }
                else if (arr1[i] < arr2[m])
                {
                    end = m;
                }
                else
                {
                    start = m + 1;
                }
            }

            if (end - 1 >= 0 && Math.Abs(arr1[i] - arr2[end - 1]) <= d)
            {
                continue;
            }

            if (end < arr2.Length && Math.Abs(arr1[i] - arr2[end]) <= d)
            {
                continue;
            }

            count++;
        }

        return count;
    }
}
