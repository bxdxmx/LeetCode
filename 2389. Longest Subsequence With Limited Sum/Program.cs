var s = new Solution();

s.AnswerQueries(new int[] { 4, 5, 2, 1 }, new int[] { 3, 10, 21 });


public class Solution
{
    public int[] AnswerQueries(int[] nums, int[] queries)
    {
        var numList = new List<int>(nums);
        numList.Add(0);
        numList.Sort();

        for (int i = 1; i < numList.Count; i++)
        {
            numList[i] += numList[i - 1];
        }

        var res = new int[queries.Length];

        for (int i = 0; i < queries.Length; i++)
        {
            res[i] = numList.Where(n => n <= queries[i]).Select((_, i) => i).Last();
        }

        return res;
    }
}
