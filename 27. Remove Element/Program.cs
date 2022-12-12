// See https://aka.ms/new-console-template for more information
Console.WriteLine("Hello, World!");

var s = new Solution();

s.RemoveElement(new int[] { 1 }, 0);
s.RemoveElement(new int[] { 1 }, 1);
s.RemoveElement(new int[] { 0, 1, 2, 2, 3, 0, 4, 2 }, 2);
s.RemoveElement(new int[] { 3, 2, 2, 3 }, 3);


public class Solution
{
    public int RemoveElement(int[] nums, int val)
    {
        int i = 0, j = nums.Length - 1;

        while (i <= j)
        {
            while (i <= j && nums[i] != val )
            {
                i++;
            }

            while (j >= 0 && nums[j] == val)
            {
                j--;
            }

            if (i < j)
            {
                nums[i] = nums[j];
                j--;
            }
        }

        return i;
    }
}