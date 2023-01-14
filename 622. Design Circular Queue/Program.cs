public class MyCircularQueue
{
    private readonly int[] array;
    int head, tail, count, n;

    public MyCircularQueue(int k)
    {
        array = new int[k];
        n = k;
    }

    public bool EnQueue(int value)
    {
        if (IsFull())
        {
            return false;
        }

        array[tail] = value;
        tail = (tail + 1) % n;
        count++;

        return true;
    }

    public bool DeQueue()
    {
        if (IsEmpty())
        {
            return false;
        }

        head = (head + 1) % n;
        count--;

        return true;
    }

    public int Front()
    {
        return IsEmpty() ? -1 : array[head];
    }

    public int Rear()
    {
        return IsEmpty() ? -1 : array[(tail - 1 + n) % n];
    }

    public bool IsEmpty()
    {
        return count == 0;
    }

    public bool IsFull()
    {
        return count == n;
    }
}
