var s = new Solution();

s.CheckInclusion("hello", "ooolleoooleh");

public class Solution
{
    public bool CheckInclusion(string s1, string s2)
    {
        if (s1.Length > s2.Length)
        {
            return false;
        }

        var d1 = new Dictionary<char, int>();
        var d2 = new Dictionary<char, int>();
        for (char c = 'a'; c <= 'z'; c++)
        {
            d1[c] = 0;
            d2[c] = 0;
        }

        for (int i = 0; i < s1.Length; i++)
        {
            d1[s1[i]]++;
            d2[s2[i]]++;
        }

        if (d1.SequenceEqual(d2))
        {
            return true;
        }

        for (int i = 1; i + s1.Length - 1 < s2.Length; i++)
        {
            d2[s2[i - 1]]--;
            d2[s2[i + s1.Length - 1]]++;

            if (d1.SequenceEqual(d2))
            {
                return true;
            }
        }

        return false;
    }
}
