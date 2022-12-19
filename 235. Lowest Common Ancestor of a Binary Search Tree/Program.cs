using System.Security.Cryptography;

var s = new Solution();

var t0 = new TreeNode(0);
var t1 = new TreeNode(1);
var t2 = new TreeNode(2);
var t3 = new TreeNode(3);
var t4 = new TreeNode(4);
var t5 = new TreeNode(5);
var t6 = new TreeNode(6);
var t7 = new TreeNode(7);
var t8 = new TreeNode(8);
var t9 = new TreeNode(9);

t6.left = t2;
t6.right = t8;
t2.left = t0;
t2.right = t4;
t4.left = t3;
t4.right = t5;
t8.left = t7;
t8.right = t9;

s.LowestCommonAncestor(t6, t2, t8);

public class TreeNode
{
    public int val;
    public TreeNode? left;
    public TreeNode? right;
    public TreeNode(int x) { val = x; }
}

public class Solution
{
    // 単純にrootから辿って行って、pとqがleftとrightに分かれるタイミングのnodeを返せばよかった

    public TreeNode LowestCommonAncestor(TreeNode root, TreeNode p, TreeNode q)
    {
        var sP = SubLowestCommonAncestor(root, p);
        var sQ = SubLowestCommonAncestor(root, q);

        TreeNode prevP = null, prevQ = null, currentP, currentQ;

        while (sP.Any() && sQ.Any())
        {
            currentP = sP.Pop();
            currentQ = sQ.Pop();

            if (currentP.val != currentQ.val)
            {
                return prevP;
            }
            else if (!sP.Any())
            {
                return currentP;
            }
            else if (!sQ.Any())
            {
                return currentQ;
            }
            prevP = currentP;
            prevQ = currentQ;
        }

        return null;
    }

    private Stack<TreeNode> SubLowestCommonAncestor(TreeNode node, TreeNode target)
    {
        if (node.val == target.val)
        {
            var s = new Stack<TreeNode>();
            s.Push(node);
            return s;
        }
        else
        {
            var s = SubLowestCommonAncestor(node.val < target.val ? node.right : node.left, target);
            s.Push(node);
            return s;
        }
    }

    /*
     * list版
     * 
    public TreeNode LowestCommonAncestor(TreeNode root, TreeNode p, TreeNode q)
    {
        var nodeListP = SubLowestCommonAncestor(root, p);
        var nodeListQ = SubLowestCommonAncestor(root, q);

        nodeListP.Reverse();
        nodeListQ.Reverse();

        int i = 0;

        while (i < nodeListP.Count && i < nodeListQ.Count)
        {
            if (nodeListP[i].val != nodeListQ[i].val)
            {
                return nodeListP[i - i];
            }
            else if (nodeListP.Count - 1 == i)
            {
                return nodeListP[^1];
            }
            else if (nodeListQ.Count - 1 == i)
            {
                return nodeListQ[^1];
            }

            i++;
        }

        return null;
    }

    private List<TreeNode> SubLowestCommonAncestor(TreeNode node, TreeNode target)
    {
        if (node.val == target.val)
        {
            return new List<TreeNode> { node };
        }
        else if( node.val < target.val)
        {
            var list = SubLowestCommonAncestor(node.right, target);
            list.Add(node);
            return list;
        }
        else
        {
            var list = SubLowestCommonAncestor(node.left, target);
            list.Add(node);
            return list;
        }
    }
     */
}
