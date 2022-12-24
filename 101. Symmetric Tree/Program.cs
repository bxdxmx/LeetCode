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
    // BFSで左からと右からのを比較すればOK

    public bool IsSymmetric(TreeNode root)
    {
        if (root.left == null && root.right == null)
        {
            return true;
        }

        var qL = new Queue<TreeNode>();
        var qR = new Queue<TreeNode>();
        if (root.left != null)
        {
            qL.Enqueue(root.left);
        }

        if (root.right != null)
        {
            qR.Enqueue(root.right);
        }

        while (qL.Any() && qR.Any())
        {
            var tempL = new Queue<TreeNode>();
            var tempR = new Queue<TreeNode>();

            while (qL.Any() && qR.Any())
            {
                var nodeL = qL.Dequeue();
                var nodeR = qR.Dequeue();

                if (nodeL.val != nodeR.val ||
                    nodeL.left == null && nodeR.right != null ||
                    nodeL.left != null && nodeR.right == null ||
                    nodeL.right == null && nodeR.left != null ||
                    nodeL.right != null && nodeR.left == null
                    )
                {
                    return false;
                }

                if (nodeL.left != null)
                {
                    tempL.Enqueue(nodeL.left);
                }

                if (nodeL.right != null)
                {
                    tempL.Enqueue(nodeL.right);
                }

                if (nodeR.right != null)
                {
                    tempR.Enqueue(nodeR.right);
                }

                if (nodeR.left != null)
                {
                    tempR.Enqueue(nodeR.left);
                }
            }

            qL = tempL;
            qR = tempR;
        }

        return !qL.Any() && !qR.Any();
    }
}