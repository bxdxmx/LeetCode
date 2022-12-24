var s = new Solution();

var l = new List<IList<int>>();
l.Add(new List<int> { 2 });
l.Add(new List<int> { 3,4 });
l.Add(new List<int> { 6,5,7 });
l.Add(new List<int> { 4,1,8,3 });

s.MinimumTotal(l);

public class Solution
{
    public int MinimumTotal(IList<IList<int>> triangle)
    {
        for (int i = 1; i < triangle.Count; i++)
        {
            var curr = triangle[i];
            var prev = triangle[i - 1];

            for (int j = 0; j < curr.Count; j++)
            {
                curr[j] += Math.Min(j - 1 >= 0 ? prev[j - 1] : int.MaxValue, j < prev.Count ? prev[j] : int.MaxValue);
            }
        }

        return triangle[^1].Min();
    }
}
