public class Solution
{
    public IList<int> FindAnagrams(string s, string p)
    {
        var sd = new Dictionary<char, int>();
        var pd = new Dictionary<char, int>();

        foreach (char c in Enumerable.Range('a', 'z' - 'a' + 1).Select(v => (char)v))
        {
            sd[c] = 0;
            pd[c] = 0;
        }

        foreach (var c in p)
        {
            pd[c]++;
        }

        for( int i = 0; i < p.Length && i < s.Length; i++)
        {
            sd[s[i]]++;
        }

        var res = new List<int>();

        for (int i = 0; i < s.Length - p.Length + 1; i++)
        {
            if (sd.OrderBy(o => o.Key).SequenceEqual(pd.OrderBy(o => o.Key)))
            {
                res.Add(i);
            }

            if (i + p.Length < s.Length)
            {
                sd[s[i]]--;
                sd[s[i + p.Length]]++;
            }
        }

        return res;
    }
}
