public class DataStream
{
    private Queue<int> q;
    private Dictionary<int, int> d;
    private int value, k;

    public DataStream(int value, int k)
    {
        q = new();
        d = new();
        this.value = value;
        this.k = k;
    }

    public bool Consec(int num)
    {
        q.Enqueue(num);
        if (!d.ContainsKey(num))
        {
            d[num] = 1;
        }
        else
        {
            d[num]++;
        }

        if( q.Count > k )
        {
            int del = q.Dequeue();
            d[del]--;
        }

        if (value == num && d[num] == k)
        {
            return true;
        }
        else
        {
            return false;
        }
    }
}
