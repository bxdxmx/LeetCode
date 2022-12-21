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
    public int MaxDepth(TreeNode root)
    {
        if(root == null)
        {
            return 0;
        }

        int DFS(TreeNode node)
        {
            return 1 + Math.Max(node.left != null ? DFS(node.left) : 0, node.right != null ? DFS(node.right) : 0);
        }

        return DFS(root);
    }
}