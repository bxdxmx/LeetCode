public class Solution
{
    public int DistinctPrimeFactors(int[] nums)
    {
        HashSet<int> PrimeFactors(int n)
        {
            HashSet<int> res = new();

            int i = 2;
            int tmp = n;

            while (i * i <= n)
            {
                if (tmp % i == 0)
                {
                    tmp /= i;
                    res.Add(i);
                }
                else
                {
                    i++;
                }
            }

            if (tmp != 1)
            {
                res.Add(tmp);
            }

            return res;
        }

        HashSet<int> res = new();

        foreach (var n in nums)
        {
            var result = PrimeFactors(n);

            foreach (var item in result)
            {
                res.Add(item);
            }
        }

        return res.Count;
    }
}
