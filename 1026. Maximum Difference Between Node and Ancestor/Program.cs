public class TreeNode
{
    public int val;
    public TreeNode? left;
    public TreeNode? right;
    public TreeNode(int val = 0, TreeNode? left = null, TreeNode? right = null)
    {
        this.val = val;
        this.left = left;
        this.right = right;
    }
}
 
public class Solution
{
    public int MaxAncestorDiff(TreeNode root)
    {
        (int distance, _, _) = SubMaxAncestorDiff(root, int.MaxValue, int.MinValue);
        return distance;
    }

    private (int, int, int) SubMaxAncestorDiff(TreeNode node, int min, int max)
    {
        (int distanceL, int minL, int maxL) = node.left != null
            ? SubMaxAncestorDiff(node.left, min, max)
            : (0, node.val, node.val);

        (int distanceR, int minR, int maxR) = node.right != null
            ? SubMaxAncestorDiff(node.right, min, max)
            : (0, node.val, node.val);

        return (
            new int[] { Math.Abs(node.val - minL), Math.Abs(node.val - maxL),
                    Math.Abs(node.val - minR), Math.Abs(node.val - maxR),
                    distanceL, distanceR}.Max(),
            new int[] { node.val, minL, minR }.Min(),
            new int[] { node.val, maxL, maxR }.Max());
    }
}