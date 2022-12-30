var s = new Solution();

var graph = new int[][]
{
    new int[]{4,3,1 },
    new int[]{3,2,4 },
    new int[]{3 },
    new int[]{4 },
    new int[]{ },
};

s.AllPathsSourceTarget(graph);

public class Solution
{
    public IList<IList<int>> AllPathsSourceTarget(int[][] graph)
    {
        var s = new Stack<int>();
        var res = new List<IList<int>>();
        
        s.Push(0);
        DFS(graph[0]);

        void DFS(int[] nodes)
        {
            foreach (var node in nodes)
            {
                s.Push(node);

                if (node == graph.Length - 1)
                {
                    var l = s.ToList();
                    l.Reverse();
                    res.Add(l);
                }

                DFS(graph[node]);
                s.Pop();
            }
        }

        return res;
    }
}
