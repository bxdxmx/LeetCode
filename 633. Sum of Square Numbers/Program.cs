public class Solution
{
    public bool JudgeSquareSum(int c)
    {
        // フェルマーの二平方和定理
        for (int i = 2; i * i <= c; i++)
        {
            int count = 0;
            if (c % i == 0)
            {
                while (c % i == 0)
                {
                    count++;
                    c /= i;
                }
                if (i % 4 == 3 && count % 2 != 0)
                {
                    return false;
                }
            }
        }
        return c % 4 != 3;
    }
}
