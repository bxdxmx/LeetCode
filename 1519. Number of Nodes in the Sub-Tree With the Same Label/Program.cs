public class Solution
{
    private class TreeNode
    {
        public int Val { get; set; }
        public char Label { get; set; }
        public IList<TreeNode> Children { get; set; }

        public TreeNode(int val, char label)
        {
            Val = val;
            Label = label;
            Children = new List<TreeNode>();
        }
    }

    public int[] CountSubTrees(int n, int[][] edges, string labels)
    {
        TreeNode[] nodes = new TreeNode[n];
        int[] res = new int[n];

        for (int i = 0; i < n; i++)
        {
            nodes[i] =new TreeNode(i, labels[i]);
        }
        TreeNode root = nodes[0];

        foreach (int[] edge in edges)
        {
            nodes[edge[0]].Children.Add(nodes[edge[1]]);
            nodes[edge[1]].Children.Add(nodes[edge[0]]);
        }

        Dictionary<char, int> DFS(TreeNode node, TreeNode from)
        {
            Dictionary<char, int> nodeD = new()
            {
                [node.Label] = 1
            };

            foreach (TreeNode child in node.Children.Where(n => n != from))
            {
                var childD = DFS(child, node);
                foreach ((char childLabel, int childValue) in childD)
                {
                    if (!nodeD.ContainsKey(childLabel))
                    {
                        nodeD[childLabel] = childValue;
                    }
                    else
                    {
                        nodeD[childLabel] += childValue;
                    }
                }
            }

            res[node.Val] = nodeD[node.Label];

            return nodeD;
        }

        DFS(root, root);

        return res;
    }
}
