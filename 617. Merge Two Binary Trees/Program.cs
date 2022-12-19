var s = new Solution();

var t1 = new TreeNode(1);
var t3 = new TreeNode(3);
var t2 = new TreeNode(2);
var t5 = new TreeNode(5);
t1.left = t3;
t1.right = t2;
t3.left = t5;

var r1 = new TreeNode(1);
var r2 = new TreeNode(2);
var r3 = new TreeNode(3);
var r4 = new TreeNode(4);
var r7 = new TreeNode(7);

r2.left = r1;
r2.right = r3;
r1.right = r4;
r3.right = r7;

var wwe = s.MergeTrees(t1, r2);

Console.WriteLine(wwe);

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
    public TreeNode MergeTrees(TreeNode root1, TreeNode root2)
    {
        TreeNode tree = null;

        if(root1 != null || root2 != null)
        {
            tree = SubMergeTrees(root1, root2);
        }

        return tree;
    }

    private TreeNode SubMergeTrees(TreeNode node1, TreeNode node2)
    {
        var node = new TreeNode((node1?.val ?? 0) + (node2?.val ?? 0));

        if (node1?.left != null || node2?.left != null)
        {
            node.left = SubMergeTrees( node1?.left, node2?.left );
        }

        if (node1?.right != null || node2?.right != null)
        {
            node.right = SubMergeTrees(node1?.right, node2?.right);
        }

        return node;
    }
}
