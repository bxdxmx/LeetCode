public class ListNode
{
    public int val;
    public ListNode? next;
    public ListNode(int x)
    {
        val = x;
        next = null;
    }
}
 
public class Solution
{
    public bool HasCycle(ListNode head)
    {
        var s = new HashSet<ListNode>();

        while (head != null)
        {
            if (s.Contains(head))
            {
                return true;
            }
            else
            {
                s.Add(head);
                head = head.next;
            }
        }

        return false;
    }
}