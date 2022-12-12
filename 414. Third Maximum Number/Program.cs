public class Solution
{
    public int ThirdMax(int[] nums)
    {
        var sortedDistincts = new SortedSet<int>(nums);

        return sortedDistincts.Count < 3
            ? sortedDistincts.ElementAt(sortedDistincts.Count - 1)
            : sortedDistincts.ElementAt(sortedDistincts.Count - 3);
    }
}
