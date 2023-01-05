var s = new Solution();

s.GroupAnagrams(new string[] { "eat", "tea", "tan", "ate", "nat", "bat" });

public class Solution
{
    public IList<IList<string>> GroupAnagrams(string[] strs)
    {
        Dictionary<string, List<int>> d = new();

        for (int i = 0; i < strs.Length; i++)
        {
            string orderedStr = string.Concat(strs[i].OrderBy(c => c));

            if(!d.ContainsKey(orderedStr))
            {
                d[orderedStr] = new List<int>();
            }

            d[orderedStr].Add(i);
        }

        List<IList<string>> res = new();

        foreach (string orderedStr in d.Keys)
        {
            List<string> l = new();

            foreach (int index in d[orderedStr])
            {
                l.Add(strs[index]);
            }

            res.Add(l);
        }

        return res;
    }
}