var s = new Solution();

s.ClosestPrimes(1, 2);

public class Solution
{
    public int[] ClosestPrimes(int left, int right)
    {
        int leftRes = -1, rightRes = -1, minDiff = int.MaxValue;

        if (right <= 1)
        {
            return new int[] { leftRes, rightRes };
        }

        var l = GeneratePrime(left, right);

        for (int i = 1; i < l.Count; i++)
        {
            if (l[i] - l[i - 1] < minDiff)
            {
                minDiff = l[i] - l[i - 1];
                leftRes = l[i - 1];
                rightRes = l[i];
            }
        }

        return new int[] { leftRes, rightRes };
    }

    private List<int> GeneratePrime(int min, int max)
    {
        int prime;
        double sqrtMax = Math.Sqrt(max);
        var primeList = new List<int>();

        var searchList = Enumerable.Range(2, max - 1).ToList();

        do
        {
            prime = searchList.First();
            primeList.Add(prime);
            searchList.RemoveAll(n => n % prime == 0);
        } while (prime < sqrtMax);

        primeList.AddRange(searchList);

        return primeList.Where( n => n >= min).ToList();
    }
}
