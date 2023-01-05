public class Solution
{
    public int NumOfMinutes(int n, int headID, int[] manager, int[] informTime)
    {
        Dictionary<int, List<int>> d = new();

        for (int i = 0; i < n; i++)
        {
            int mID = manager[i];

            if (!d.ContainsKey(mID))
            {
                d[mID] = new List<int>();
            }

            d[mID].Add(i);
        }

        return DFS(headID);

        int DFS(int curr)
        {
            if (!d.ContainsKey(curr))
            {
                return 0;
            }

            int min = 0;
            List<int> l = d[curr];

            for (int i = 0; i < l.Count; i++)
            {
                min = Math.Max(DFS(l[i]), min);
            }

            return min + informTime[curr];
        }
    }
}
