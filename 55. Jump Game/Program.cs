var s = new Solution();

Console.WriteLine(s.CanJump(new int[] { 2, 3, 1, 1, 4 }));

public class Solution
{
    public bool CanJump(int[] nums)
    {
        int reach = 0;

        for (int i = 0; i < nums.Length - 1 && i <= reach && reach < nums.Length - 1 ; i++)
        {
            reach = Math.Max(reach, i + nums[i]);
        }

        return reach >= nums.Length - 1;
    }
}
