public class TreeNode
{
    public int val;
    public TreeNode? left;
    public TreeNode? right;
    public TreeNode(int val = 0, TreeNode? left = null, TreeNode? right = null)
    {
        this.val = val;
        this.left = left;
        this.right = right;
    }
}

public class Solution
{
    public bool LeafSimilar(TreeNode root1, TreeNode root2)
    {
        var r1 = new List<int>();
        var r2 = new List<int>();

        SubLeafSimilar(root1, r1);
        SubLeafSimilar(root2, r2);

        return r1.SequenceEqual(r2);
    }

    private void SubLeafSimilar(TreeNode? node, List<int> result)
    {
        if (node == null)
        {
            return;
        }

        if (node.left == null && node.right == null)
        {
            result.Add(node.val);
            return;
        }

        SubLeafSimilar(node.left, result);
        SubLeafSimilar(node.right, result);
    }
}

