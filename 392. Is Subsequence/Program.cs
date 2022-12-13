public class Solution
{
    public bool IsSubsequence(string s, string t)
    {
        int si = 0, ti = 0;

        while(si < s.Length && ti < t.Length)
        {
            if (s[si] == t[ti])
            {
                si++;
                ti++;
            }
            else
            {
                ti++;
            }
        }

        return si == s.Length;
    }

    /// <summary>
    /// これは違った。順番を担保する必要があった。
    /// </summary>
    /// <param name="s"></param>
    /// <param name="t"></param>
    /// <returns></returns>
    public bool IsSubsequence22(string s, string t)
    {
        var d = new Dictionary<char, int>();

        foreach (var c in t)
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

        foreach (var c in s)
        {
            if (d.ContainsKey(c))
            {
                if (--d[c] < 0)
                {
                    return false;
                }
            }
            else
            {
                return false;
            }
        }

        return true;
    }

}
