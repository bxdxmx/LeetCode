public class Node {
    public int val;
    public Node? left;
    public Node? right;
    public Node? next;

    public Node() {}

    public Node(int _val) {
        val = _val;
    }

    public Node(int _val, Node _left, Node _right, Node _next) {
        val = _val;
        left = _left;
        right = _right;
        next = _next;
    }
}

public class Solution
{
    // DFSで繋いでいくだけ

    public Node Connect(Node root)
    {
        if (root == null)
        {
            return null;
        }

        var q = new Queue<Node>();
        q.Enqueue(root);

        while (q.Any())
        {
            Node prev = null, current;
            var temp = new Queue<Node>();

            while (q.Any())
            {
                current = q.Dequeue();
                if (current.left != null)
                {
                    temp.Enqueue(current.left);
                    temp.Enqueue(current.right);
                }

                if (prev != null)
                {
                    prev.next = current;
                }

                prev = current;
            }

            q = temp;
        }

        return root;
    }
}