var s = new Solution();

Console.WriteLine(s.NthUglyNumber(1690));

public class Solution
{
    public int NthUglyNumber(int n)
    {
        var list = new List<int>() { 1, 2, 3, 4, 5 };

        while (list.Count < n)
        {
            list.Add(
                new int[] {
                    (int)list.Select(x => (long)x * 2).Where(x => x > list[^1]).Min(),
                    (int)list.Select(x => (long)x * 3).Where(x => x > list[^1]).Min(),
                    (int)list.Select(x => (long)x * 5).Where(x => x > list[^1]).Min()
                 }.Min()
             );
        }

        return list[n - 1];
    }
}
