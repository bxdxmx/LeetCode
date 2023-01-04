public class Solution
{
    /*
     * 
     * n/3 + 1 if n%3!=0
     * 
     */

    public int MinimumRounds(int[] tasks)
    {
        Dictionary<int, int> d = tasks.GroupBy(t => t).ToDictionary(g => g.Key, g => g.Count());

        int res = 0;

        foreach ( var task in d )
        {
            if (task.Value == 1)
            {
                return -1;
            }

            res += task.Value / 3 + (task.Value % 3 != 0 ? 1 : 0);
        }

        return res;
    }
}
