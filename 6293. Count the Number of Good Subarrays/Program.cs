var s = new Solution();

Console.WriteLine(s.CountGood(new int[] { 1, 1, 3, 1, 2, 1, 2, 2, 1, 2, 1, 2, 3, 3 }, 14));

public class Solution
{
    public long CountGood(int[] nums, int k)
    {
        long res = 0;
        int n = nums.Length;

        long pairsum = 0;
        int j = 0;
        Dictionary<int, int> numsum = new();

        for (int i = 0; i < n; i++)
        {
            if (numsum.ContainsKey(nums[i]))
            {
                numsum[nums[i]]++;
            }
            else
            {
                numsum[nums[i]] = 1;
            }

            pairsum += numsum[nums[i]] - 1;

            while (pairsum >= k && j <= i)
            {
                res += (n - i);
                numsum[nums[j]]--;
                pairsum -= numsum[nums[j]];
                j++;
            }
        }

        return res;
    }
}
