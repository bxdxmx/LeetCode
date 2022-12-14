var s = new Solution();

Console.WriteLine(s.IsPerfectSquare(2147395600));

public class Solution
{
    public bool IsPerfectSquare(int num)
    {
        int start = 1, end = 46341;

        while(start < end)
        {
            int m = start + (end - start) / 2;

            int n = m * m;

            if (n == num)
            {
                return true;
            }
            else if(n > num )
            {
                end = m;
            }
            else
            {
                start = m + 1;
            }
        }

        return false;
    }
}
