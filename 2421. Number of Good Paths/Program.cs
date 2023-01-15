
class Solution
{
    private int[] parents;

    private int Find(int x)
    {
        if (x != parents[x])
        {
            parents[x] = Find(parents[x]);
        }

        return parents[x];
    }

    public int NumberOfGoodPaths(int[] vals, int[][] edges)
    {
        int n = vals.Length;

        if (n == 1)
        {
            return 1;
        }

        parents = new int[n];

        List<int> ids = new();
        for (int i = 0; i < n; i++)
        {
            parents[i] = i;
            ids.Add(i);
        }

        Dictionary<int, HashSet<int>> graph = new();

        foreach (int[] edge in edges)
        {
            int u = edge[0];
            int v = edge[1];

            if(!graph.ContainsKey(u))
            {
                graph[u] = new HashSet<int>();
            }

            if (!graph.ContainsKey(v))
            {
                graph[v] = new HashSet<int>();
            }

            graph[u].Add(v);
            graph[v].Add(u);
        }

        // 2. sort the ids by vals
        ids.Sort((a, b) => vals[a] - vals[b]);

        // 3. iterate from smallest to biggest
        int ret = 0;
        for (int i = 0; i < n; i++)
        {
            // get all same vals of node ids[i, j)
            int j = i + 1;
            while (j < n && vals[ids[j]] == vals[ids[i]]) j++;

            // enum each same val
            for (int k = i; k < j; k++)
            {
                int x = ids[k];
                // traverse neighbor, if small than current node
                foreach (int neighbor in graph[x])
                {
                    if (vals[x] >= vals[neighbor])
                    {
                        // union node x and its smaller neighbor
                        parents[Find(x)] = Find(neighbor);
                    }
                }
            }
            // checkout for current values, the # of val in each component 
            Dictionary<int, int> temp = new();
            for (int k = i; k < j; k++)
            {
                int root = Find(ids[k]);

                // # of current val in the {root} group
                if (temp.ContainsKey(root))
                {
                    temp[root]++;
                }
                else
                {
                    temp[root] = 1;
                }
            }

            // standalone nodes are included. Note C(n, 2) + n = C(n + 1, 2)
            foreach (int v in temp.Values)
            {
                ret += v * (v + 1) / 2;
            }

            i = j - 1;
        }

        return ret;
    }
}