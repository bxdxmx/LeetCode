public class Solution
{
    public bool IsIsomorphic(string s, string t)
    {
        var d1 = new Dictionary<char, char>();
        var d2 = new Dictionary<char, char>();

        for (int i = 0; i < s.Length; i++)
        {
            if (d1.ContainsKey(s[i]))
            {
                if (d1[s[i]] != t[i])
                {
                    return false;
                }
            }
            else
            {
                d1[s[i]] = t[i];
            }

            if (d2.ContainsKey(t[i]))
            {
                if (d2[t[i]] != s[i])
                {
                    return false;
                }
            }
            else
            {
                d2[t[i]] = s[i];
            }

        }

        return true;
    }
}
