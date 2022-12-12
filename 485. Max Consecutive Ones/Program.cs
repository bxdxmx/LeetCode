

var s = new Solution();

Console.WriteLine(s.FindMaxConsecutiveOnes(new int[] { 1, 1, 0, 1, 1, 1 }));
Console.WriteLine(s.FindMaxConsecutiveOnes(new int[] { 1, 0, 1, 1, 0, 1 }));
Console.WriteLine(s.FindMaxConsecutiveOnes(new int[] { 1, 1, 1, 1, 1, 1 }));
Console.WriteLine(s.FindMaxConsecutiveOnes(new int[] { 1, 1, 1, 0, 1, 1 }));

public class Solution
{
    public int FindMaxConsecutiveOnes(int[] nums)
    {
        int max = 0;
        int index = 0;

        while(true)
        {
            int nextIndex = Array.IndexOf(nums, 0, index);
            if(nextIndex == -1)
            {
                max = Math.Max(max, nums.Length - index);
                break;
            }
            else
            {
                max = Math.Max(max, nextIndex - index);
                index = nextIndex+1;
            }
        }

        return max;
    }
}