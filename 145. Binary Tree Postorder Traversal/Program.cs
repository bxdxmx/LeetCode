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
    // DFSで左、右、自分の順に足していけばOK


    public IList<int> PostorderTraversal(TreeNode root)
    {
        List<int> result = new();

        void DFS(TreeNode node)
        {
            if (node != null)
            {
                DFS(node.left);
                DFS(node.right);
                result.Add(node.val);
            }
        }

        DFS(root);

        return result;
    }
}