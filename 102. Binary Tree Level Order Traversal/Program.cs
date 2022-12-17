public class TreeNode
{
    public int val;
    public TreeNode? left;
    public TreeNode? right;
    public TreeNode(int val = 0, TreeNode left = null, TreeNode right = null)
    {
        this.val = val;
        this.left = left;
        this.right = right;
    }
}
 
public class Solution
{
    public IList<IList<int>> LevelOrder(TreeNode root)
    {
        var result = new List<IList<int>>();

        if (root == null)
        {
            return result;
        }

        var bfs = new Queue<TreeNode>();
        bfs.Enqueue(root);

        while(bfs.Any())
        {
            var list = new List<int>();
            var q = new Queue<TreeNode>();

            while (bfs.Any())
            {
                var node = bfs.Dequeue();
                list.Add(node.val);

                if (node.left != null)
                {
                    q.Enqueue(node.left);
                }

                if (node.right != null)
                {
                    q.Enqueue(node.right);
                }
            }

            result.Add(list);
            bfs = q;
        }

        return result;
    }
}