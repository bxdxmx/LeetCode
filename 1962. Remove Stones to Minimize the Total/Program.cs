public class Solution
{
    public int MinStoneSum(int[] piles, int k)
    {
        PriorityQueue<int, int> q = new(piles.Length);

        foreach (var pile in piles)
        {
            q.Enqueue(pile, int.MaxValue - pile);
        }

        for (int i = 0; i < k; i++)
        {
            int temp = q.Dequeue();
            int pile = temp - (int)Math.Floor(temp / 2.0);

            q.Enqueue(pile, int.MaxValue - pile);
        }

        int sum = 0;

        for (int i = 0; i < piles.Length; i++)
        {
            sum += q.Dequeue();
        }

        return sum;
    }
}
