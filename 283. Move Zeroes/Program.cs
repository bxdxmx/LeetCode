public class Solution
{
    public void MoveZeroes(int[] nums)
    {
        for(int i = 0; i < nums.Length-1; i++)
        {
            if (nums[i] != 0 )
            {
                continue;
            }

            for(int j = i+1; j < nums.Length; j++)
            {
                if (nums[j] == 0)
                {
                    continue;
                }

                nums[i] = nums[j];
                nums[j] = 0;
                break;
            }
        }
    }
}
