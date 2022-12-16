public class Node {
    public int val;
    public IList<Node> children;

    public Node() {}

    public Node(int _val) {
        val = _val;
    }

    public Node(int _val,IList<Node> _children) {
        val = _val;
        children = _children;
    }
}

public class Solution
{
    public IList<int> Preorder(Node root)
    {
        var list = new List<int>();
        if (root != null)
        {
            SubPreorder(root, list);
        }
        return list;
    }

    private void SubPreorder(Node node, List<int> list)
    {
        list.Add(node.val);
        foreach (var child in node.children)
        {
            SubPreorder(child, list);
        }
    }
}