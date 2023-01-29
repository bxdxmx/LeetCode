public class Solution
{
    public int DistinctIntegers(int n)
    {
        if (n <= 2)
        {
            return 1;
        }
        else
        {
            return n - 1;
        }
    }
}
