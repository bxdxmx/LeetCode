using System.Text;

string s1 = "parker";
string s2 = "morris";
string baseStr = "parser";

var s = new Solution();
s.SmallestEquivalentString(s1, s2, baseStr);

public class Solution
{
    public string SmallestEquivalentString(string s1, string s2, string baseStr)
    {
        var equivChars = new SortedSet<char>[26];

        for (int i = 0; i < s1.Length; i++)
        {
            char c1 = s1[i], c2 = s2[i];

            var set1 = equivChars[c1 - 'a'] ?? new SortedSet<char>();
            var set2 = equivChars[c2 - 'a'] ?? new SortedSet<char>();

            SortedSet<char> mergedSet = new(set1.Concat(set2))
            {
                c1,
                c2
            };

            foreach (char c in mergedSet)
            {
                equivChars[c - 'a'] = mergedSet;
            }
        }

        StringBuilder sb = new();

        for (int i = 0; i < baseStr.Length; i++)
        {
            char c = baseStr[i];

            if (equivChars[c - 'a'] == null)
            {
                sb.Append(c);
            }
            else
            {
                sb.Append(equivChars[c - 'a'].ElementAt(0));
            }
        }

        return sb.ToString();
    }
}
