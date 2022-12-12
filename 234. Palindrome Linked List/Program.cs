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
    public bool IsPalindrome(ListNode? head)
    {
        var original = new List<int>();
        var reverse = new List<int>(); // 効率を求めるのであれば、これは使わない方がいい。originalに全部入れてから最初と最後から順番に比較していって、半分超えたときにOKならtrue返せばいい。

        while (true)
        {
            var val = head.val;
            original.Add(head.val);
            reverse.Add(head.val);

            head = head.next;
            if(head == null)
            {
                break;
            }
        }

        reverse.Reverse();
        return original.SequenceEqual(reverse);
    }
}