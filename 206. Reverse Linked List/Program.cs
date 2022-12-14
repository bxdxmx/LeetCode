var s = new Solution();
var n1 = new ListNode(1);
var n2 = new ListNode(2);
var n3 = new ListNode(3);
var n4 = new ListNode(4);
var n5 = new ListNode(5);

n1.next = n2;
n2.next = n3;
n3.next = n4;
n4.next = n5;

s.ReverseList(n1);


public class ListNode
{
    public int val;
    public ListNode? next;
    public ListNode(int val = 0, ListNode? next = null)
    {
        this.val = val;
        this.next = next;
    }
}
 
public class Solution
{
    public ListNode? ReverseList(ListNode head)
    {
        if (head == null)
        {
            return null;
        }

        ListNode? last = null;

        ListNode SubReverseList(ListNode node)
        {
            if (node.next == null)
            {
                last = node;
                return node;
            }

            var n = SubReverseList(node.next);
            n.next = node;
            return node;
        }

        SubReverseList(head);
        head.next = null;
        
        return last;
    }
}