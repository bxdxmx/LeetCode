var s = new Solution();

int n = 7;
int[][] edges = new int[][]
{
    new int[] { 0,1 },
    new int[] { 0,2 },
    new int[] { 1,4 },
    new int[] { 1,5},
    new int[] { 2,3 },
    new int[] { 2,6 }
};
bool[] hasApple = new bool[] { false, false, true, false, true, true, false };

Console.WriteLine(s.MinTime(n, edges, hasApple));

public class Solution
{
    public int MinTime(int n, int[][] edges, IList<bool> hasApple)
    {
        if (!hasApple.Where(b => b == true).Any())
        {
            return 0;
        }

        Dictionary<int, List<int>> d = new()
        {
            [0] = new()
        };

        foreach (int[] edge in edges)
        {
            (int edgeFrom, int edgeTo) = (edge[0], edge[1]);

            if (!d.ContainsKey(edgeFrom))
            {
                d[edgeFrom] = new();
            }

            if (!d.ContainsKey(edgeTo))
            {
                d[edgeTo] = new();
            }

            d[edgeFrom].Add(edgeTo);
            d[edgeTo].Add(edgeFrom);
        }

        (int sum, bool found) DFS(int vertex, int from)
        {
            bool found = hasApple[vertex];
            int sum = 0;

            foreach (int childVerterx in d[vertex].Where(v => v != from))
            {
                (int sumChildren, bool foundChildren) = DFS(childVerterx, vertex);
                found |= foundChildren;
                sum += sumChildren;
            }

            return ( found ? sum + 2 : sum, found);
        }

        return DFS(0,0).sum - 2;
    }
}
