public class Solution
{
    public int PeakIndexInMountainArray(int[] arr)
    {
        int start = 0, end = arr.Length;
        int result = 0;

        while (start < end)
        {
            int index = start + (end - start) / 2;

            if (arr[index] > arr[index + 1])
            {
                end = index;
                result = arr[result] < arr[end] ? end : result;
            }
            else
            {
                start = index + 1;
            }
        }

        return result;
    }
}
