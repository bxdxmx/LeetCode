var s = new Solution();
var n1 = new TreeNode(1);
var n2 = new TreeNode(2);
var n3 = new TreeNode(3);
n1.left= n2;
n1.right= n3;

Console.WriteLine(s.MaxPathSum(n1));

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

// 左と自分、右と自分、自分、左と右と自分　どれかが最大値よりも多いい場合は設定する。
// 左の総数と自分、右の総数と自分、自分の大きい方を返す。

public class Solution
{
    private static int maxSum;

    public int MaxPathSum(TreeNode root)
    {
        maxSum = int.MinValue;
        int r = SubMaxPathSum(root);
        return Math.Max(r, maxSum);
    }

    private int SubMaxPathSum(TreeNode node)
    {
        int leftSum = node.left != null ? SubMaxPathSum(node.left) : 0;
        int rightSum = node.right != null ? SubMaxPathSum(node.right) : 0;

        maxSum =  new int[] { maxSum, leftSum + node.val, rightSum + node.val, leftSum + rightSum + node.val, node.val }.Max();

        return new int[] { leftSum + node.val, rightSum + node.val, node.val }.Max();
    }
}