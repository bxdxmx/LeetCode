public class Solution
{
    public int SubtractProductAndSum(int n)
    {
        int product(int x)
        {
            return x == 0 ? 1 : (x % 10) * product(x / 10);
        }

        int sum(int x)
        {
            return x == 0 ? 0 : (x % 10) + sum(x / 10);
        }

        return product(n) - sum(n);
    }
}
