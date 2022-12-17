public class Solution
{
    public int FirstUniqChar(string s)
    {
        var d = new Dictionary<char, int>();

        foreach (var c in s)
        {
            if (d.ContainsKey(c))
            {
                d[c]++;
            }
            else
            {
                d[c] = 1;
            }
        }

        for (int i = 0; i < s.Length; i++)
        {
            if (d[s[i]] == 1)
            {
                return i;
            }
        }

        return -1;
    }
}
