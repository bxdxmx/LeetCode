using System.Text;

public class Solution
{
    public bool RepeatedSubstringPattern(string s)
    {
        string S = (s + s)[1..^1];
        return S.IndexOf(s) > -1;
    }
}
