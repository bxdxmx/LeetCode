public class Solution
{
    public int TakeCharacters(string s, int k)
    {
        var d = new Dictionary<char, int>
        {
            ['a'] = 0,
            ['b'] = 0,
            ['c'] = 0
        };

        foreach (char c in s)
        {
            d[c]++;
        }

        if (d['a'] < k || d['b'] < k || d['c'] < k)
        {
            return -1;
        }

        int res = d['a'] + d['b'] + d['c'];
        int i = 0;
        int window = 0;

        foreach (char c in s)
        {
            d[c]--;
            window++;

            while (d['a'] < k || d['b'] < k || d['c'] < k)
            {
                d[s[i]]++;
                i++;
                window--;
            }

            res = Math.Min(res, s.Length - window);
        }

        return res;
    }
}
