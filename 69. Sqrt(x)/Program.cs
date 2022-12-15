public class Solution
{
    public int MySqrt(int x)
    {
        double E = 0.000001;
        double y = x / 2d;
        while (true)
        {
            double e = y * y - x;
            if (Math.Abs(e) < E) return (int)y;
            y -= e / (y * 2);
        }
    }
}
