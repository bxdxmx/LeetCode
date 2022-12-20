public class Solution
{
    // diffが同じ場合、+(++counter)
    // diffが違う場合、diffをセットしなおし、counterを0に戻す

    public int NumberOfArithmeticSlices(int[] nums)
    {
        if (nums.Length <= 2)
        {
            return 0;
        }

        int diff = nums[1] - nums[0];
        int counter = 0;
        int result = 0;

        for (int i = 2; i < nums.Length; i++)
        {
            if (nums[i] - nums[i - 1] == diff)
            {
                result += (++counter);
            }
            else
            {
                diff = nums[i] - nums[i - 1];
                counter = 0;
            }
        }

        return result;
    }
}
