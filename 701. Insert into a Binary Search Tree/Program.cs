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
    public TreeNode InsertIntoBST(TreeNode root, int val)
    {
        void SubInsertIntoBST(TreeNode node)
        {
            if (node.val < val)
            {
                if (node.right == null)
                {
                    node.right = new TreeNode(val);
                }
                else
                {
                    SubInsertIntoBST(node.right);
                }
            }
            else
            {
                if (node.left == null)
                {
                    node.left = new TreeNode(val);
                }
                else
                {
                    SubInsertIntoBST(node.left);
                }
            }
        }

        if (root != null)
        {
            SubInsertIntoBST(root);
        }
        else
        {
            root = new TreeNode(val);
        }

        return root;
    }
}