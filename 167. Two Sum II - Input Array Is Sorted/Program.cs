public class Solution
{
    public int[] TwoSum(int[] numbers, int target)
    {
        int i, j = -1;

        for (i = 0; i < numbers.Length - 1; i++)
        {
            j = Array.BinarySearch(numbers, i + 1, numbers.Length - (i + 1), target - numbers[i]);

            if( j > -1 )
            {
                break;
            }
        }

        return new int[] { i + 1, j + 1 };
    }
}
