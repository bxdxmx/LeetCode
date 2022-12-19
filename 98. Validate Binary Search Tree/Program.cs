var s = new Solution();

var t1 = new TreeNode(1);
var t3 = new TreeNode(3);
var t4 = new TreeNode(4);
var t5 = new TreeNode(5);
var t6 = new TreeNode(6);

t5.left = t1;
t5.right = t4;
t4.left = t3;
t4.right = t6;

s.IsValidBST(t5);

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
    // btsで左の最大値が自分より小さいこと、右の最大値が自分より大きいこと

    public bool IsValidBST(TreeNode root)
    {
        (int max,int min, bool result) SubIsValidBST(TreeNode node)
        {
            int maxLeft = int.MinValue, minLeft = int.MaxValue, maxRight = int.MinValue, minRight = int.MaxValue;
            bool result = true;

            if (node.left != null)
            {
                (maxLeft, minLeft, result) = SubIsValidBST(node.left);

                result = result && node.val > maxLeft;
            }

            if (result && node.right != null)
            {
                (maxRight, minRight, result) = SubIsValidBST(node.right);

                result = result && node.val < minRight;
            }

            return (
                new int[] { node.val, maxLeft, maxRight }.Max(),
                new int[] { node.val, minLeft, minRight }.Min(),
                result);
        }

        (_, _, bool result) = SubIsValidBST(root);

        return result;
    }
}