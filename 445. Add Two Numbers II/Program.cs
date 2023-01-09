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
    public ListNode AddTwoNumbers(ListNode l1, ListNode l2)
    {
        Stack<int> s1 = new();
        Stack<int> s2 = new();
        Queue<ListNode> q = new();

        while (l1 != null)
        {
            s1.Push(l1.val);
            l1 = l1.next;
        }

        while (l2 != null)
        {
            s2.Push(l2.val);
            l2 = l2.next;
        }

        int carry = 0;

        while (s1.Any() || s2.Any() || carry != 0)
        {
            int sum = (s1.Any() ? s1.Pop() : 0) + (s2.Any() ? s2.Pop() : 0) + carry;

            (sum, carry) = (sum % 10, sum / 10);

            q.Enqueue(new ListNode(sum));
        }

        ListNode head = null;

        while (q.Any())
        {
            ListNode curr = q.Dequeue();
            curr.next = head;
            head = curr;
        }

        return head;
    }
}