// See https://aka.ms/new-console-template for more information
Console.WriteLine("Hello, World!");


public class Solution
{
    public int[] SortedSquares(int[] nums)
    {
        return nums
            .Select(x => x*x)
            .OrderBy(n => n)
            .ToArray();
    }
}