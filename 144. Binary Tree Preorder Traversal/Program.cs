using System.ComponentModel.Design.Serialization;

public class TreeNode
{
    public int val;
    public TreeNode? left;
    public TreeNode? right;
    public TreeNode(int val = 0, TreeNode left = null, TreeNode right = null)
    {
        this.val = val;
        this.left = left;
        this.right = right;
    }
}
 
public class Solution
{
    // DFSでアクセス順に足していけばOK

    public IList<int> PreorderTraversal(TreeNode root)
    {
        List<int> result = new();

        void DFS(TreeNode node)
        {
            if (node != null)
            {
                result.Add(node.val);
                DFS(node.left);
                DFS(node.right);
            }
        }

        DFS(root);

        return result;
    }
}