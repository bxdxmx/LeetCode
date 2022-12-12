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
    public ListNode AddTwoNumbers(ListNode? l1, ListNode? l2)
    {
        int carry = 0;
        var result = new ListNode();
        var node = result;

        while (true)
        {
            int l1num = l1?.val ?? 0;
            int l2num = l2?.val ?? 0;
            carry = Math.DivRem(l1num + l2num + carry, 10, out node.val);

            l1 = l1?.next;
            l2 = l2?.next;

            if(l1 != null || l2 != null || carry == 1)
            {
                node.next = new ListNode();
                node = node.next;
            }
            else
            {
                break;
            }
        }

        return result;
    }
}