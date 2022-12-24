var s = new Solution();

var t5 = new TreeNode(5);
var t4_1 = new TreeNode(4);
var t11 = new TreeNode(11);
var t7 = new TreeNode(7);
var t2 = new TreeNode(2);
var t8 = new TreeNode(8);
var t13 = new TreeNode(13);
var t4_2 = new TreeNode(4);
var t1 = new TreeNode(1);

t5.left = t4_1;
t4_1.left = t11;
t11.left = t7;
t11.right= t2;
t5.right = t8;
t8.left = t13;
t8.right = t4_2;
t4_2.right= t1;

s.HasPathSum(t5,22);

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

    public bool HasPathSum(TreeNode root, int targetSum)
    {
        if (root == null)
        {
            return false;
        }

        bool DFS(TreeNode node, int sum) 
        {
            int newSum = sum + node.val;

            if (node.left == null && node.right == null)
            {
                return newSum == targetSum;
            }

            if (node.left != null)
            {
                bool result = DFS(node.left, newSum);
                if (result)
                {
                    return true;
                }
            }

            if (node.right != null)
            {
                bool result = DFS(node.right, newSum);
                if (result)
                {
                    return true;
                }
            }

            return false;
        }

        return DFS(root, 0);
    }

    // 途中じゃなくてleafまでの合計だった
    // 途中で検出する場合はこちら
    public bool HasPathSum2(TreeNode root, int targetSum)
    {
        if (root == null)
        {
            return false;
        }

        var q = new Queue<(TreeNode, int)>();

        q.Enqueue((root, 0));

        while (q.Any())
        {
            var temp = new Queue<(TreeNode, int)>();

            while (q.Any())
            {
                (TreeNode node, int sum) = q.Dequeue();
                sum += node.val;

                if (sum == targetSum)
                {
                    return true;
                }
                else if (sum > targetSum)
                {
                    continue;
                }

                if (node.left != null)
                {
                    temp.Enqueue((node.left, sum));
                }

                if (node.right != null)
                {
                    temp.Enqueue((node.right, sum));
                }
            }

            q = temp;
        }

        return false;
    }
}