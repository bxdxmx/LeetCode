public class MinStack
{
    private Stack<(int val, int min)> s;

    public MinStack()
    {
        s = new();
    }

    public void Push(int val)
    {
        if (s.Any())
        {
            s.Push((val, Math.Min(val, s.Peek().min)));
        }
        else
        {
            s.Push((val, val));
        }
    }

    public void Pop()
    {
        s.Pop();
    }

    public int Top()
    {
        return s.Peek().val;
    }

    public int GetMin()
    {
        return s.Peek().min;
    }
}
