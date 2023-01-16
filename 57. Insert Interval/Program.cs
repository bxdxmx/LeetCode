var s = new Solution();

int[][] intervals = new int[][]
{
    new int[]{ 1,5},
};

int[] newInterval = new int[] { 1, 7 };

s.Insert(intervals, newInterval);

public class Solution
{
    public int[][] Insert(int[][] intervals, int[] newInterval)
    {
        List<int[]> res = new();
        PriorityQueue<(int start, int end), int> q = new();
        q.Enqueue((newInterval[0], newInterval[1]), newInterval[0]);

        foreach (var interval in intervals)
        {
            q.Enqueue((interval[0], interval[1]), interval[0]);
        }

        while (q.Count > 0)
        {
            (int s1, int e1) = q.Dequeue();

            if (q.Count == 0)
            {
                res.Add(new int[] { s1, e1 });
                break;
            }
            else
            {
                (int s2, int e2) = q.Peek();

                if (s1 <= s2 && s2 <= e1)
                {
                    q.Dequeue();
                    q.Enqueue((s1, Math.Max(e1, e2)), s1);
                }
                else
                {
                    res.Add(new int[] { s1, e1 });
                }
            }
        }

        return res.ToArray();
    }
}
