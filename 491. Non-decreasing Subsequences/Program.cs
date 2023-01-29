public class Solution
{
    public IList<IList<int>> FindSubsequences(int[] nums)
    {
        PriorityQueue<List<int>, int> q = new();

        foreach (int num in nums)
        {
            q.Enqueue(new List<int> { num }, num);
        }

    }
}