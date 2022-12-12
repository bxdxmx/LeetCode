// See https://aka.ms/new-console-template for more information

new Solution().RemoveDuplicates(new int[] { 1, 1 });

public class Solution
{
    public int RemoveDuplicates(int[] nums)
    {
        int i=0, j=0;

        while(j < nums.Length)
        {
            nums[i++] = nums[j++];

            while ( j < nums.Length && nums[j-1] == nums[j])
            {
                j++;
            }
        }

        return i;
    }
}