using System.Text;

var s = new Solution();

s.FreqAlphabets("1326#");


public class Solution
{
    public string FreqAlphabets(string s)
    {
        int i = s.Length - 1;
        var sb = new StringBuilder();

        while (i >= 0)
        {
            if (s[i] == '#')
            {
                sb.Append((char)('j' + int.Parse(s[(i - 2)..i]) - 10));
                i -= 3;
            }
            else
            {
                sb.Append((char)('a' + char.GetNumericValue(s[i]) - 1));
                i--;
            }
        }

        return new string(sb.ToString().Reverse().ToArray());
    }
}
