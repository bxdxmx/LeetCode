public class Solution
{
    public bool DetectCapitalUse(string word)
    {
        string s1 = word.ToUpper();
        string s2 = word.ToLower();
        string s3 = char.ToUpper(s2[0]) + s2[1..s2.Length];

        return new string[] { s1, s2, s3 }.Contains(word);
    }
}
