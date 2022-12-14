var s = new Solution();

Console.WriteLine(s.NearestValidPoint(3, 4, new int[][] {
    new int[]{1,2 },
    new int[]{3,1 },
    new int[]{2,4 },
    new int[]{2,3 },
    new int[]{4,4 }
}));

public class Solution
{
    public int NearestValidPoint(int x, int y, int[][] points)
    {
        int minManhattan = int.MaxValue, minIndex = -1;

        for (int i = 0; i < points.Length ; i++)
        {
            if ((points[i][0] != x && points[i][1] != y))
            {
                continue;
            }

            var manhattan = Math.Abs(x - points[i][0]) + Math.Abs(y - points[i][1]);

            if (minManhattan > manhattan)
            {
                minManhattan = manhattan;
                minIndex = i;
            }
        }

        return minIndex;
    }
}
