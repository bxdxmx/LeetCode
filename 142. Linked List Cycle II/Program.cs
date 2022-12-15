
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

// メモリをO(1)でやるには、1ずつ進むのと2ずつ進むのと両方まわして、そのうちイコールになればOK
 
public class Solution
{
    public ListNode DetectCycle(ListNode head)
    {
        var s = new HashSet<ListNode>();

        while (head != null)
        {
            if (s.Contains(head))
            {
                return head;
            }
            else
            {
                s.Add(head);
                head = head.next;
            }
        }

        return null;
    }
}