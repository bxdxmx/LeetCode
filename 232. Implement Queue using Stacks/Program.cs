public class MyQueue
{
    private readonly Stack<int> main;
    private readonly Stack<int> sub;

    public MyQueue()
    {
        main = new Stack<int>();
        sub = new Stack<int>();
    }

    public void Push(int x)
    {
        main.Push(x);
    }

    public int Pop()
    {
        while (main.Count != 0)
        {
            sub.Push(main.Pop());
        }

        var pop = sub.Pop();

        while (sub.Count != 0)
        {
            main.Push(sub.Pop());
        }

        return pop;
    }

    public int Peek()
    {
        while (main.Count != 0)
        {
            sub.Push(main.Pop());
        }

        var peek = sub.Peek();

        while (sub.Count != 0)
        {
            main.Push(sub.Pop());
        }

        return peek;
    }

    public bool Empty()
    {
        return main.Count == 0;
    }
}

/**
 * Your MyQueue object will be instantiated and called as such:
 * MyQueue obj = new MyQueue();
 * obj.Push(x);
 * int param_2 = obj.Pop();
 * int param_3 = obj.Peek();
 * bool param_4 = obj.Empty();
 */