// See https://aka.ms/new-console-template for more information
Console.WriteLine("Hello, World!");



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
    public ListNode MiddleNode(ListNode? head)
    {
        var node = head;
        int listCount = 0;

        while (true)
        {
            listCount++;

            node = node.next;
            if (node == null)
            {
                break;
            }
        }

        for(int i = 0; i < listCount / 2; ++i)
        {
            head = head.next;
        }

        return head;
    }
}