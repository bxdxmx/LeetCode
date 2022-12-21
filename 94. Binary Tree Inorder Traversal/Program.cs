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
    // DFSで左、自分、右の順に足していけばOK

    public IList<int> InorderTraversal(TreeNode root)
    {
        List<int> result = new();

        void DFS(TreeNode node)
        {
            if (node != null)
            {
                DFS(node.left);
                result.Add(node.val);
                DFS(node.right);
            }
        }

        DFS(root);

        return result;
    }
}