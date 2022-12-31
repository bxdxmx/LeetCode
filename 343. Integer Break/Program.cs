var s = new Solution();

s.IntegerBreak(10);

public class Solution
{
    /*
     * n>=5の時、3*x + n%3
     * n<=4の時、2*x + n%2
     */

    public int IntegerBreak(int n)
    {
        if (n == 2)
        {
            return 1;
        }

        List<int> res = new();

        if (n >= 5)
        {
            (int d, int m) = Math.DivRem(n, 3);

            for (int i = 0; i < d; i++)
            {
                res.Add(3);
            }

            if (m != 0)
            {
                if (m == 1)
                {
                    res.RemoveAt(res.Count - 1);
                    res.Add(2);
                    res.Add(2);
                }
                else
                {
                    res.Add(m);
                }
            }
        }
        else
        {
            (int d, int m) = Math.DivRem(n, 2);
            for (int i = 0; i < d; i++)
            {
                res.Add(2);
            }

            if (m != 0)
            {
                res.Add(m);
            }
        }

        return res.Aggregate(1, (s, num) => s *= num);
    }
}
