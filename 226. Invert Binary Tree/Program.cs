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
    public TreeNode InvertTree(TreeNode root)
    {
        void DFS(TreeNode node)
        {
            if (node == null)
            {
                return;
            }

            (node.left, node.right) = (node.right, node.left);

            DFS(node.left);
            DFS(node.right);
        }

        DFS(root);

        return root;
    }
}