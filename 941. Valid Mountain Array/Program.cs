public class Solution
{
    public bool ValidMountainArray(int[] arr)
    {
        int maxIndex = Array.IndexOf(arr, arr.Max());

        if (arr.Length < 3 || maxIndex == 0 || maxIndex == arr.Length - 1)
        {
            return false;
        }

        for (int i = maxIndex ; i >= 1; i--)
        {
            if (arr[i-1] >= arr[i])
            {
                return false;
            }
        }

        for(int i = maxIndex; i < arr.Length -1; i++)
        {
            if (arr[i] <= arr[i+1])
            {
                return false;
            }
        }

        return true;
    }
}
