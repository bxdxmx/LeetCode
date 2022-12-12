ListNode n1 = new ListNode(2);
var n2 = new ListNode(1);
var n3 = new ListNode(3);
var n4 = new ListNode(5);
var n5 = new ListNode(6);
var n6 = new ListNode(4);
//var n7 = new ListNode(7);

n1.next= n2;
n2.next = n3;
n3.next = n4;
n4.next = n5;
n5.next = n6;
//n6.next = n7;

var s = new Solution();
s.OddEvenList(n1);

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
    public ListNode OddEvenList(ListNode head)
    {
        if (head?.next?.next == null)
        {
            return head;
        }

        var node = head.next.next;
        var evenNodeHead = head.next;
        var evenNode = evenNodeHead;
        head.next = node;

        while (node.next != null)
        {
            evenNode.next = node.next;
            evenNode = evenNode.next;

            if (node.next.next == null)
            {
                break;
            }
            else
            {
                node.next = node.next.next;
                node = node.next;
            }
        }

        evenNode.next = null;
        node.next = evenNodeHead;

        return head;
    }
}