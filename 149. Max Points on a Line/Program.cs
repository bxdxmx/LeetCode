var s = new Solution();

int[][] points = new int[][]
{
    new int[]{ 1,1},
    new int[]{ 2,2},
    new int[]{ 3,3}
};

s.MaxPoints(points);

public class Solution
{
    public int MaxPoints(int[][] points)
    {
        if (points.Length == 1)
        {
            return 1;
        }

        int result = 2;

        for (int i = 0; i < points.Length; i++)
        {
            Dictionary<double, int> cnt = new();

            for (int j = 0; j < points.Length; j++)
            {
                if (j != i)
                {
                    if (cnt.ContainsKey(Math.Atan2(points[j][1] - points[i][1], points[j][0] - points[i][0])))
                    {
                        cnt[Math.Atan2(points[j][1] - points[i][1], points[j][0] - points[i][0])]++;
                    }
                    else
                    {
                        cnt[Math.Atan2(points[j][1] - points[i][1], points[j][0] - points[i][0])] = 1;
                    }
                }
            }

            result = Math.Max(result, cnt.Values.Max() + 1);
        }

        return result;
    }
}
