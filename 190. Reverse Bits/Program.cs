public class Solution
{
    public uint reverseBits(uint n)
    {
        var q = new Queue<uint>();

        for (int i = 0; i < 32; i++)
        {
            q.Enqueue(n & 1);
            n >>= 1;
        }

        uint rn = 0;

        for (int i = 0; i < 32; i++)
        {
            rn <<= 1;
            rn += q.Dequeue();
        }

        return rn;
    }
}
