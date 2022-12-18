var s = new Solution();
var n1 = new ListNode(1);
var n2 = new ListNode(2);
var n3 = new ListNode(6);
var n4 = new ListNode(3);
var n5 = new ListNode(4);
var n6 = new ListNode(5);
var n7 = new ListNode(6);

n1.next = n2;
n2.next = n3;
n3.next = n4;
n4.next = n5;
n5.next = n6;
n6.next = n7;
n7.next = null;

s.RemoveElements(n1, 6);


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
    public ListNode RemoveElements(ListNode head, int val)
    {
        var dummy = new ListNode
        {
            next = head
        };
        var node = dummy;

        while (node.next != null)
        {
            if (node.next.val == val)
            {
                node.next = node.next.next;
            }
            else
            {
                node = node.next;
            }
        }

        return dummy.next;
    }
}