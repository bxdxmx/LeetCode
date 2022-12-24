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
    public TreeNode SearchBST(TreeNode root, int val)
    {
        if (root.val == val)
        {
            return root;
        }
        else if (root.val < val)
        {
            return root.right != null ? SearchBST(root.right, val) : null;
        }
        else
        {
            return root.left != null ? SearchBST(root.left, val) : null;
        }
    }
}