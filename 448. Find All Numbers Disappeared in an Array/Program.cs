public class Solution
{
    public IList<int> FindDisappearedNumbers(int[] nums)
    {
        var dict = new Dictionary<int, int>(nums.Length);

        for (int i = 1; i <= nums.Length; ++i )
        {
            dict[i] = 0;
        }

        foreach(var num in nums )
        {
            dict[num]++;
        }

        return dict
            .Where( d => d.Value == 0 )
            .Select( d => d.Key )
            .OrderBy( k => k )
            .ToList();
    }
}
