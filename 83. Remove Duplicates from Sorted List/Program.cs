public class ListNode
{
    public int val;
    public ListNode? next;
    public ListNode(int val = 0, ListNode next = null)
    {
        this.val = val;
        this.next = next;
    }
}
 
public class Solution
{
    public ListNode DeleteDuplicates(ListNode head)
    {
        ListNode current = head, next = current?.next;

        while (next != null)
        {
            if (current.val == next.val)
            {
                current.next = next.next;
            }
            else
            {
                current = current.next;
            }
            next = next.next;
        }

        return head;        
    }
}