public class Solution
{
    private class TreeNode
    {
        public int Val { get; set; }
        public char Label { get; set; }
        public List<TreeNode> Children { get; set; }

        public TreeNode(int val, char label)
        {
            Val = val;
            Label = label;
            Children = new List<TreeNode>();
        }
    }

    public int LongestPath(int[] parent, string s)
    {
        TreeNode[] nodes = new TreeNode[parent.Length];

        for (int i = 0; i < nodes.Length; i++)
        {
            nodes[i] = new TreeNode(i, s[i]);
        }

        for (int i = 0; i < nodes.Length; i++)
        {
            if (parent[i] != -1)
            {
                nodes[parent[i]].Children.Add(nodes[i]);
            }
        }

        int maxLongestPath = 0;

        int DFS(TreeNode node)
        {
            PriorityQueue<int,int> q = new();

            foreach (TreeNode child in node.Children)
            {
                int path = DFS(child);

                if (node.Label != child.Label)
                {
                    q.Enqueue(path, int.MaxValue - path);
                }
            }

            int children1stLongestPath = q.Count != 0 ? q.Dequeue() : 0;
            int children2ndLongestPath = q.Count != 0 ? q.Dequeue() : 0;

            maxLongestPath = Math.Max(maxLongestPath, children1stLongestPath + children2ndLongestPath + 1);

            return children1stLongestPath + 1;
        };

        DFS(nodes[0]);

        return maxLongestPath;
    }
}
