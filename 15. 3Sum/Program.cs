var s = new Solution();

Console.WriteLine(s.ThreeSum(new int[] { 0, 2, 2, 3, 0, 1, 2, 3, -1, -4, 2 }));
Console.WriteLine(s.ThreeSum(new int[] { 0,0,0,0 }));
Console.WriteLine(s.ThreeSum(new int[] { -1, 0, 1, 2, -1, -4 }));

public class Solution
{
    public IList<IList<int>> ThreeSum(int[] nums)
    {
        var result = new List<IList<int>>();

        Array.Sort(nums);

        for( int i = 0; i < nums.Length -1 ; i++ )
        {
            if ( i > 0 && nums[i-1] == nums[i])
            {
                continue;
            }

            var d = new Dictionary<int,bool>();

            for( int j = i + 1; j < nums.Length; j++ )
            {
                if (d.ContainsKey(nums[j]))
                {
                    if (d[nums[j]])
                    {
                        d[nums[j]] = false;
                        result.Add(new List<int>() { nums[i], -nums[i] - nums[j], nums[j] });
                    }
                }
                else
                {
                    d[-nums[i] - nums[j]] = true;
                }
            }
        }

        return result;
    }
}