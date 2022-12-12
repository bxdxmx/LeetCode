var s = new Solution();

Console.WriteLine(s.LongestPalindrome("bb"));
Console.WriteLine(s.LongestPalindrome("c"));
Console.WriteLine(s.LongestPalindrome("babad"));
Console.WriteLine(s.LongestPalindrome("cbbd"));

public class Solution
{
    public string LongestPalindrome(string s)
    {
        int start = 0;
        int maxLength = 1;

        for (int i = 0, j; i < s.Length; i++)
        {
            for (j = i + 1; j < s.Length && s[i] == s[j]; j++)
            {
                if (maxLength <= j - i + 1)
                {
                    start = i;
                    maxLength = j - i + 1;
                }
            }

            for (int i2 = i - 1, j2 = j; i2 >= 0 && j2 < s.Length && s[i2] == s[j2]; i2--, j2++)
            {
                if (maxLength <= j2 - i2 + 1)
                {
                    start = i2;
                    maxLength = j2 - i2 + 1;
                }
            }
        }

        return s.Substring(start, maxLength);
    }
}
