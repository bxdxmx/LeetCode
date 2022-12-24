public class Solution
{
    public bool IsPowerOfTwo(int n)
    {
        while (n > 1)
        {
            n = Math.DivRem(n, 2, out int mod);
            if (mod != 0)
            {
                return false;
            }
        }

        return n == 1;
    }
}
