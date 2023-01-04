public class Solution
{
    public int[] NextGreaterElements(int[] nums)
    {
        Stack<(int index, int value)> s = new();
        int[] res = new int[nums.Length];
        Array.Fill(res, -1);

        int[] nums2 = nums.Concat(nums).ToArray();

        for (int i = 0; i < nums2.Length; i++)
        {
            while (s.Any())
            {
                var (index, value) = s.Peek();

                if (value < nums2[i])
                {
                    res[index] = nums2[i];
                    s.Pop();
                }
                else
                {
                    break;
                }
            }

            if (i < nums.Length)
            {
                s.Push((i, nums[i]));
            }
        }

        return res;
    }
}
