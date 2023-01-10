public class TreeNode
{
    public int val;
    public TreeNode left;
    public TreeNode right;
    public TreeNode(int val = 0, TreeNode left = null, TreeNode right = null)
    {
        this.val = val;
        this.left = left;
        this.right = right;
    }
}

public class BSTIterator
{
    private Stack<TreeNode> traversal;

    public BSTIterator(TreeNode root)
    {
        traversal = new();
        MoveLeft(root);
    }

    private void MoveLeft(TreeNode current)
    {
        while (current != null)
        {
            traversal.Push(current);
            current = current.left;
        }
    }

    public int Next()
    {
        TreeNode current = traversal.Pop();

        if (current.right != null)
        {
            MoveLeft(current.right);
        }

        return current.val;
    }

    public bool HasNext()
    {
        return traversal.Count > 0;
    }
}
