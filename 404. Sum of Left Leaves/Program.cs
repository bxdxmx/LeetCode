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
    public int SumOfLeftLeaves(TreeNode root)
    {
        int DFS(TreeNode node)
        {
            int n = 0;

            if (node.left != null && node.left.left == null && node.left.right == null)
            {
                n = node.left.val;
            }

            n += node.left != null ? DFS(node.left) :0;
            n += node.right != null ? DFS(node.right) : 0;

            return n;
        }

        return DFS(root);
    }
}