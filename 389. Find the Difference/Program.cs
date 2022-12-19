public class Solution
{
    public char FindTheDifference(string s, string t)
    {
        var ds = s.GroupBy(c => c).ToDictionary(c => c.Key, c => c.Count());
        var dt = t.GroupBy(c => c).ToDictionary(c => c.Key, c => c.Count());
        char result = '_';

        foreach (var c in dt.Keys)
        {
            if (!ds.ContainsKey(c) || dt[c] - ds[c] > 0)
            {
                result = c;
                break;
            }
        }

        return result;
    }
}
