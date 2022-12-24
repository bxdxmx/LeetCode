using System.Text;

public class Solution
{
    public IList<string> LetterCasePermutation(string s)
    {
        var res = new List<StringBuilder>() { new StringBuilder() };

        foreach (char c in s)
        {
            int length = res.Count;

            for( int i = 0; i < length; i++)
            {
                var sb1 = res[i];

                if (char.IsDigit(c))
                {
                    sb1.Append(c);
                }
                else
                {
                    var sb2 = new StringBuilder(sb1.ToString());
                    res.Add(sb2);
                    sb1.Append(char.ToLower(c));
                    sb2.Append(char.ToUpper(c));
                }
            }
        }

        return res.Select(sb => sb.ToString()).ToList();
    }
}
