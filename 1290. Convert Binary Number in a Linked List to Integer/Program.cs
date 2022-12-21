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
    public int GetDecimalValue(ListNode head)
    {
        int n = 0;

        while (head != null)
        {
            n <<= 1;
            n += head.val;
            head = head.next;
        }

        return n;
    }
}