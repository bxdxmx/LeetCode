public class Solution
{
    public bool AreAlmostEqual(string s1, string s2)
    {
        if (s1 == s2)
        {
            return true;
        }

        var p = new int[2];
        int count = 0;

        for (int i = 0; i < s1.Length; i++)
        {
            if (s1[i] != s2[i])
            {
                if (count == 2)
                {
                    return false;
                }

                p[count++] = i;
            }
        }

        return count == 2 && s1[p[0]] == s2[p[1]] && s1[p[1]] == s2[p[0]];
    }
}
