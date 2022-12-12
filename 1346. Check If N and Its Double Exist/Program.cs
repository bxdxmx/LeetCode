new Solution().CheckIfExist(new int[] { -2, 0, 10, -19, 4, 6, -8 });

new Solution().CheckIfExist(new int[] { 10, 2, 5, 3 });

new Solution().CheckIfExist(new int[] { 3, 1, 7, 11 });

public class Solution
{
    public bool CheckIfExist(int[] arr)
    {
        Array.Sort(arr);

        int indexPlus = 0;

        while (indexPlus < arr.Length && arr[indexPlus] < 0)
        {
            indexPlus++;
        }

        for( int i = 0; i < indexPlus; ++i)
        {
            if ((arr[i] & 1) == 0 &&
                Array.BinarySearch(arr, i + 1, indexPlus - i - 1, arr[i] / 2) > -1)
            {
                return true;
            }
        }

        for (int i = arr.Length-1; i >= indexPlus; --i)
        {
            if ((arr[i] & 1) == 0 &&
                Array.BinarySearch(arr, indexPlus, i - indexPlus, arr[i] / 2) > -1)
            {
                return true;
            }
        }

        return false;
    }
}
//   0,  1,  2, 3, 4, 5,  6
// -19, -8, -2, 0, 4, 6, 10

//   0,  1,  2,  3
//   2,  3,  5, 10

