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
    public ListNode? MergeTwoLists(ListNode? list1, ListNode? list2)
    {
        var result = new ListNode();
        ListNode head = result;

        while(list1 != null || list2 != null)
        {
            if (list1 == null)
            {
                head.next = list2;
                break;
            }
            else if (list2 == null)
            {
                head.next = list1;
                break;
            }
            else
            {
                if (list1.val < list2.val)
                {
                    head.next = list1;
                    head = head.next;
                    list1 = list1.next;
                }
                else
                {
                    head.next = list2;
                    head = head.next;
                    list2 = list2.next;
                }
            }
        }

        return result.next;
    }
}