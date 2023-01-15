var s = new Solution();

Console.WriteLine(s.CountGood(new int[] { 1, 1, 3, 1, 2, 1, 2, 2, 1, 2, 1, 2, 3, 3 }, 14));

public class Solution
{
    public long CountGood(int[] nums, int k)
    {
        Dictionary<int, long> d = new();

        long PairSum(int n)
        {
            if (n % 2 == 0)
            {
                return (1 + n) * (n / 2);
            }
            else
            {
                return (1 + n) * (n / 2) + (int)Math.Ceiling(n / 2.0);
            }
        }

        long res = 0;
        int n = nums.Length;

        for (int i = 0; i < n; i++)
        {
            Dictionary<int, int> numsum = new();

            for (int j = i; j < n; j++)
            {
                if (numsum.ContainsKey(nums[j]))
                {
                    numsum[nums[j]]++;
                }
                else
                {
                    numsum[nums[j]] = 1;
                }
            }

            long pairsum = 0;
            foreach (int value in numsum.Values)
            {
                pairsum += PairSum(value - 1);
            }

            for (int end = n - 1; end >= i; end--)
            {
                if (pairsum >= k)
                {
                    res++;
                }
                else
                {
                    break;
                }

                pairsum -= PairSum(numsum[nums[end]] - 1);
                numsum[nums[end]]--;
                pairsum += PairSum(numsum[nums[end]] - 1);
            }
        }

        return res;
    }
}
