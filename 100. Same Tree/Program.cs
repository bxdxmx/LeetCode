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
    public bool IsSameTree(TreeNode p, TreeNode q)
    {
        bool DFS(TreeNode p1, TreeNode p2)
        {
            if (p1 == null || p2 == null)
            {
                return false;
            }

            if (p1.val != p2.val)
            {
                return false;
            }

            if ((p1.left != null && p2.left == null) ||
                (p1.left == null && p2.left != null) ||
                (p1.right != null && p2.right == null) ||
                (p1.right == null && p2.right != null))
            {
                return false;
            }

            return ((p1.left != null && p2.left != null) ? DFS(p1.left, p2.left) : true) &&
                ((p1.right != null && p2.right != null) ? DFS(p1.right, p2.right) : true);
        }

        return (p == null && q == null) || DFS(p, q);
    }
}