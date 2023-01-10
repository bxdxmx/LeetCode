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
 
public class Solution
{
    public ListNode RotateRight(ListNode head, int k)
    {
        if (head == null)
        {
            return null;
        }

        List<ListNode> l = new();
        ListNode node = head;

        while (node != null)
        {
            l.Add(node);
            node = node.next;
        }

        int n = l.Count;
        k %= n;

        ListNode res = l[(n - k) % n];

        if ((n - k) % n != 0)
        {
            l[^1].next = l[0];
            l[(n - k - 1) % n].next = null;
        }

        return res;
    }
}