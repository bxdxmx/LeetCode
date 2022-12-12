// See https://aka.ms/new-console-template for more information
Console.WriteLine("Hello, World!");

/*
 * 1 <= nums.length <= 500
 * 1 <= nums[i] <= 10_5
 */

public class Solution
{
    public int FindNumbers(int[] nums)
    {
        return nums
            .Where(n => (n >= 10 && n <= 99) || (n >= 1000 && n <= 9999) || n == 100000)
            .Count();
    }
}