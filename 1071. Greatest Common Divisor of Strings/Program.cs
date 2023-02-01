var s = new Solution();

s.GcdOfStrings("ABCABC", "ABC");

public class Solution
{
    public string GcdOfStrings(string str1, string str2)
    {
        for (int n = Math.Min(str1.Length, str2.Length); n >= 1; n--)
        {
            if (str1.Length % n != 0 || str2.Length % n != 0)
            {
                continue;
            }

            string s1 = string.Concat(Enumerable.Repeat(str1[0..n], str1.Length / n).ToArray());
            string s2 = string.Concat(Enumerable.Repeat(str1[0..n], str2.Length / n).ToArray());

            if (str1 == s1 && str2 == s2)
            {
                return str1[0..n];
            }
        }

        return string.Empty;
    }
}
