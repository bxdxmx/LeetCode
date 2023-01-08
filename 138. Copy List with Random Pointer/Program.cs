public class Node
{
    public int val;
    public Node next;
    public Node random;

    public Node(int _val)
    {
        val = _val;
        next = null;
        random = null;
    }
}

public class Solution
{
    public Node CopyRandomList(Node head)
    {
        Dictionary<Node, Node> d = new();
        Node oldNode = head;
        Node newHead = GetNewNode(head);

        while (oldNode != null)
        {
            Node newNode = GetNewNode(oldNode);
            newNode.next = GetNewNode(oldNode.next);
            newNode.random = GetNewNode(oldNode.random);

            oldNode = oldNode.next;
        }

        Node GetNewNode(Node oldNode)
        {
            if (oldNode == null)
            {
                return null;
            }

            if (d.TryGetValue(oldNode, out Node newNode))
            {
                return newNode;
            }
            else
            {
                newNode = new(oldNode.val);
                d[oldNode] = newNode;
                return newNode;
            }
        }

        return newHead;
    }
}