int[][] mat = 
    {
    new int[]{ 1, 1, 0, 0, 0 },
    new int[] {1, 1, 1, 1, 0},
    new int[]{1, 0, 0, 0, 0},
    new int[]{1, 1, 0, 0, 0},
    new int[]{1, 1, 1, 1, 1}
     };
int k = 3;

var aa = new Solution().KWeakestRows(mat, k);

foreach(var a in aa )
{
    Console.WriteLine(a);
}


public class Solution
{
    public int[] KWeakestRows(int[][] mat, int k)
    {
        var list = new List<(int, int)>();
        
        for( int i=0; i < mat.Length; ++i )
        {
            list.Add((i, Array.LastIndexOf(mat[i], 1)));
        }

        return list
            .OrderBy(_ => _.Item2)
            .Take(k)
            .Select(_ => _.Item1)
            .ToArray();
    }
}