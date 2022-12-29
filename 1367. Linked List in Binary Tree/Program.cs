using System.Xml.Linq;

public class ListNode
{
    public int val;
    public ListNode next;
    public ListNode(int val = 0, ListNode next = null)
    {
        this.val = val;
        this.next = next;
    }
}

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
    public bool IsSubPath(ListNode head, TreeNode root)
    {
        bool DFS1(TreeNode treeNode)
        {
            if( treeNode == null)
            {
                return false;
            }

            return
                (head.val == treeNode.val && DFS2(head, treeNode)) ||
                (DFS1(treeNode.left) || DFS1(treeNode.right));
        }

        bool DFS2(ListNode listNode, TreeNode treeNode)
        {
            if (listNode == null)
            {
                return true;
            }
            else if (treeNode == null)
            {
                return false;
            }

            return
                listNode.val == treeNode.val &&
                (DFS2(listNode.next, treeNode.left) || DFS2(listNode.next, treeNode.right));
        }

        return DFS1(root);
    }
}