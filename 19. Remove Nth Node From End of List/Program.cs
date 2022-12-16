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

// 再帰使わない場合
// node1をn分進める。
// node1を最後まですすめる、一緒にnode2をすすめる
// そこでnode2のnextを操作すればOK
 
public class Solution
{
    public ListNode RemoveNthFromEnd(ListNode head, int n)
    {
        int NthFromEnd(ListNode node, ListNode prev)
        {
            int nth = node.next == null ? 1 : NthFromEnd(node.next, node) + 1;

            if (nth == n)
            {
                prev.next = node.next;
            }

            return nth;
        }

        var dummy = new ListNode
        {
            next = head
        };

        NthFromEnd(head, dummy);

        return dummy.next;
    }
}