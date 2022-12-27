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
 
public class Solution
{
    public bool IsBalanced(TreeNode root)
    {
        bool balanced = true;

        int DFS(TreeNode node)
        {
            if (!balanced || node == null)
            {
                return 0;
            }

            int leftHeight = DFS(node.left) + 1;
            int rightHeight = DFS(node.right) + 1;

            if (Math.Abs(leftHeight - rightHeight) > 1)
            {
                balanced = false;
            }

            return Math.Max(leftHeight, rightHeight);
        }

        DFS(root);

        return balanced;
    }
}