var s = new Solution();

var t1 = new TreeNode(1);
var t0 = new TreeNode(0);
var t_2 = new TreeNode(-2);
var t4 = new TreeNode(4);
var t3 = new TreeNode(3);

t1.left = t0;
t1.right = t4;
t0.left = t_2;
t4.left = t3;

s.FindTarget(t1, 7);

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
    public bool FindTarget(TreeNode root, int k)
    {
        bool BST(TreeNode node)
        {
            if (BST2(node, root, k - node.val))
            {
                return true;
            }
            else
            {
                if (node.left != null)
                {
                    if (BST(node.left))
                    {
                        return true;
                    }
                }

                if (node.right != null)
                {
                    if (BST(node.right))
                    {
                        return true;
                    }
                }
            }

            return false;
        }

        bool BST2(TreeNode node, TreeNode target, int n)
        {
            if (node != target && target.val == n)
            {
                return true;
            }
            else
            {
                if (target.val < n)
                {
                    if (target.right != null)
                    {
                        return BST2(node, target.right, n);
                    }
                }
                else
                {
                    if (target.left != null)
                    {
                        return BST2(node, target.left, n);
                    }
                }
            }

            return false;
        }

        return BST(root);
    }
}