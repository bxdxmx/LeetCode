// 全てのサブツリーの合計をリストに突っ込んでおけば、
// あとはそれをループして全合計から各要素のをひいてproduct求めるだけか。

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
    private static long sumAllTreeValue;
 
    public int MaxProduct(TreeNode root)
    {
        sumAllTreeValue = SumTreeValue(root);
        return (int)(SubMaxProduct(root) % ((int)Math.Pow(10,9)+7));
    }

    private long SubMaxProduct(TreeNode node)
    {
        long s1 = node.left != null ? SubMaxProduct(node.left) : 0;
        long s2 = node.right != null ? SubMaxProduct(node.right) : 0;

        long sumSubTreeValue = SumTreeValue(node);
        long subMaxProduct = sumSubTreeValue * (sumAllTreeValue - sumSubTreeValue);

        return new long[] { s1, s2, subMaxProduct }.Max();
    }

    private static Dictionary<TreeNode, long> memo = new();

    private long SumTreeValue(TreeNode node)
    {
        if(memo.ContainsKey(node))
        {
            return memo[node];
        }

        return memo[node] =
            node.val +
            (node.left != null ? SumTreeValue(node.left) : 0) +
            (node.right != null ? SumTreeValue(node.right) : 0);
    }
}
