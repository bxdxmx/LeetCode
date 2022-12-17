public class Solution
{
    // fib(n) = fib(n-1) + 1
    // f(1) = 1

    public int ArrangeCoins(int n)
    {
        int coins = 0, r = 0;

        while (n > 0)
        {
            if (n - (r + 1) >= 0)
            {
                int coin = r++ + 1;
                coins += coin;
                n -= coin;
            }
            else
            {
                break;
            }
        }

        return r;
    }
}
