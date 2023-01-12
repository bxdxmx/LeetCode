var m = new MyLinkedList();
m.AddAtHead(1);
m.AddAtTail(3);
m.AddAtIndex(1, 2);
Console.WriteLine(m.Get(1));
m.DeleteAtIndex(1);
Console.WriteLine(m.Get(1));
m.DeleteAtIndex(0);
m.DeleteAtIndex(0);
Console.WriteLine(m.Get(0));

public class MyLinkedList
{
    private class Node
    {
        public int val;
        public Node? prev, next;

        public Node(int val, Node? prev = null, Node? next = null)
        {
            this.val = val;
            this.prev = prev;
            this.next = next;
        }
    }

    private int count;
    private Node head;
    private Node tail;

    public MyLinkedList()
    {
        count = 0;
        head = new Node(int.MaxValue); //dummy
        tail = new Node(int.MaxValue); //dummy
        head.next = tail;
        tail.prev = head;
    }

    public int Get(int index)
    {
        if (index < 0 || index >= count)
        {
            return -1;
        }

        Node node = head.next!;

        for (int i = 0; i < index; i++)
        {
            node = node.next!;
        }

        return node.val;
    }

    public void AddAtHead(int val)
    {
        Node node = new(val, head, head.next);
        head.next!.prev = node;
        head.next = node;
        count++;
    }

    public void AddAtTail(int val)
    {
        Node node = new(val, tail.prev, tail);
        tail.prev!.next = node;
        tail.prev = node;
        count++;
    }

    public void AddAtIndex(int index, int val)
    {
        if (index < 0 || index > count)
        {
            return;
        }

        if (index == count)
        {
            AddAtTail(val);
        }
        else if (index == 0)
        {
            AddAtHead(val);
        }
        else
        {
            Node curr = head.next!, prev = curr.prev!;

            for (int i = 0; i < index; i++)
            {
                prev = curr!;
                curr = curr.next!;
            }

            Node node = new(val, prev, curr);
            prev.next = node;
            curr.prev = node;
            count++;
        }
    }

    public void DeleteAtIndex(int index)
    {
        if (index < 0 || index >= count)
        {
            return;
        }

        Node curr = head.next!;
        Node prev = curr.prev!;

        for (int i = 0; i < index; i++)
        {
            prev = curr;
            curr = curr.next!;
        }

        prev.next = curr.next;
        curr.next!.prev = prev;
        count--;
    }
}
