public class Solution
{
    public int CountNegatives(int[][] grid)
    {
        return grid.SelectMany(x => x).Where(x => x < 0).Count();
    }
}
