public class Solution
{
    public int MonkeyMove(int n)
    {
        long m = (long)Math.Pow(10, 9) + 7;

        return (int)((Pow(2, n, m) + m - 2) % m);

        long Pow(long x, long n, long m)
        {
            if (n == 0)
            {
                return 1;
            }

            if (n % 2 == 0)
            {
                return Pow(x * x % m, n / 2, m);
            }
            else
            {
                return x * Pow(x, n - 1, m) % m;
            }
        }
    }
}
