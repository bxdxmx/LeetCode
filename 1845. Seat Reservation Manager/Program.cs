public class SeatManager
{
    private PriorityQueue<int, int> q;

    public SeatManager(int n)
    {
        q = new PriorityQueue<int, int>(n + 1);
        for (int i = 1; i < n + 1; i++)
        {
            q.Enqueue(i, i);
        }
    }

    public int Reserve()
    {
        return q.Dequeue();
    }

    public void Unreserve(int seatNumber)
    {
        q.Enqueue(seatNumber, seatNumber);
    }
}
