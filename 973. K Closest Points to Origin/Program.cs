var s = new Solution();

int[][] points = new int[][]
{
    new int[]{ 2,2},
    new int[]{ 2,2},
    new int[]{ 2,2},
    new int[]{ 2,2},
    new int[]{ 2,2},
    new int[]{ 2,2},
    new int[]{ 1,1}
};

s.KClosest(points, 1);

public class Solution
{
    public int[][] KClosest(int[][] points, int k)
    {
        return points.OrderBy(p => p[0] * p[0] + p[1] * p[1]).Take(k).ToArray();
    }
}
