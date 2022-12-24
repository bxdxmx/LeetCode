public class Solution
{
    /*
     * 解説
     * https://leetcode.com/problems/sum-of-distances-in-tree/solutions/130611/sum-of-distances-in-tree/?orderBy=hot
     */
    public int[] SumOfDistancesInTree(int n, int[][] edges)
    {
        var graph = new List<HashSet<int>>();
        int[] ans = new int[n];
        int[] count = new int[n];
        Array.Fill(count, 1);

        for (int i = 0; i < n; ++i)
        {
            graph.Add(new HashSet<int>());
        }

        foreach (int[] edge in edges)
        {
            graph[edge[0]].Add(edge[1]);
            graph[edge[1]].Add(edge[0]);
        }

        DFS(0, -1);
        DFS2(0, -1);
        
        return ans;

        void DFS(int node, int parent)
        {
            foreach (int child in graph[node])
            {
                if (child != parent)
                {
                    DFS(child, node);
                    count[node] += count[child];
                    ans[node] += ans[child] + count[child];
                }
            }
        }

        void DFS2(int node, int parent)
        {
            foreach (int child in graph[node])
            {
                if (child != parent)
                {
                    ans[child] = ans[node] - count[child] + n - count[child];
                    DFS2(child, node);
                }
            }
        }
    }
}
