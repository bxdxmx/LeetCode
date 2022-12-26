using System.Net.Sockets;

public class Solution
{
    public int LastStoneWeight(int[] stones)
    {
        var sortedStones = new PriorityQueue<int, int>();

        foreach (int stone in stones)
        {
            sortedStones.Enqueue(stone, 1000 - stone);
        }

        while (sortedStones.Count >= 2)
        {
            int y = sortedStones.Dequeue();
            int x = sortedStones.Dequeue();

            if (y != x)
            {
                sortedStones.Enqueue(y - x, 1000 - (y - x));
            }
        }

        return sortedStones.Count == 0 ? 0 : sortedStones.Dequeue();
    }
}
