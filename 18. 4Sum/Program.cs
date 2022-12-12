var s = new Solution();

Console.WriteLine(s.FourSum(new int[] { 1, 0, -1, 0, -2, 2 }, 0));
Console.WriteLine(s.FourSum(new int[] { 2, 2, 2, 2, 2 }, 8));
Console.WriteLine(s.FourSum(new int[] { 1000000000, 1000000000, 1000000000, 1000000000 }, -294967296));

public class Solution
{
    public IList<IList<int>> FourSum(int[] nums, int target)
    {
        var result = new List<IList<int>>();

        Array.Sort(nums);

        for (int i = 0; i < nums.Length - 1; i++)
        {
            if (i > 0 && nums[i - 1] == nums[i])
            {
                continue;
            }

            for (int j = i + 1; j < nums.Length; j++)
            {
                if (j > i + 1 && nums[j - 1] == nums[j])
                {
                    continue;
                }

                var d = new Dictionary<long, bool>();

                long twosum = nums[i] + nums[j];

                for (int k = j + 1; k < nums.Length; k++)
                {
                    if (d.ContainsKey(nums[k]))
                    {
                        if (d[nums[k]])
                        {
                            d[nums[k]] = false;
                            result.Add(new List<int>() { nums[i], nums[j], (int)(-twosum - nums[k] + target), nums[k] });
                        }
                    }
                    else
                    {
                        d[-twosum - nums[k] + target] = true;
                    }
                }
            }
        }

        return result;
    }
}
