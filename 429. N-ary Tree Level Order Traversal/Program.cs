public class Node
{
    public int val;
    public IList<Node> children;

    public Node(int _val = 0, IList<Node> _children = null)
    {
        val = _val;
        children = _children;
    }
}

public class Solution
{
    public IList<IList<int>> LevelOrder(Node root)
    {
        List<IList<int>> res = new();

        if (root == null)
        {
            return res;
        }

        Queue<Node> q = new();
        q.Enqueue(root);

        while (q.Any())
        {
            Queue<Node> tempQ = new();
            List<int> l = new();

            while (q.Any())
            {
                Node node = q.Dequeue();
                l.Add(node.val);
                foreach (var child in node.children)
                {
                    tempQ.Enqueue(child);
                }
            }

            q = tempQ;
            res.Add(l);
        }

        return res;
    }
}