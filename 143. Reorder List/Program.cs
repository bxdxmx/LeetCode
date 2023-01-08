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
    public void ReorderList(ListNode head)
    {
        ListNode node = head;
        List<ListNode> list = new();

        while (node != null)
        {
            list.Add(node);
            node = node.next;
        }

        int left = 1, right = list.Count - 1;
        node = head;

        while (left <= right)
        {
            node.next = list[right--];
            node = node.next;

            if (left > right)
            {
                break;
            }

            node.next = list[left++];
            node = node.next;
        }

        node.next = null;
    }
}
