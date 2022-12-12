new Solution().TwoSum(new int[] { 2, 7, 11, 15 }, 9);
new Solution().TwoSum(new int[] { 3, 2, 4 }, 6);
new Solution().TwoSum(new int[] { 3, 3 }, 6);

public class Solution
{
    public int[] TwoSum(int[] nums, int target)
    {
        var sortedNumsWithIndex = nums
            .Select((n, i) => new { n, i })
            .OrderBy(x => x.n);

        var sortedNums = sortedNumsWithIndex.Select(x => x.n).ToArray();
        var sortedIndex = sortedNumsWithIndex.Select(x => x.i).ToArray();

        for (int i = 0; i < sortedNums.Length; i++)
        {
            int n = Array.BinarySearch(sortedNums, i+1, sortedNums.Length - (i+1), target - sortedNums[i]);

            if (n > -1)
            {
                return new int[] { sortedIndex[i], sortedIndex[n] };
            }
        }

        return new int[] { };
    }
}
