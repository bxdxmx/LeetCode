var s = new Solution();

Console.WriteLine(s.CloseStrings("abc", "bca"));
Console.WriteLine(s.CloseStrings("a", "aa"));
Console.WriteLine(s.CloseStrings("cabbba", "abbccc"));

public class Solution
{
    public bool CloseStrings(string word1, string word2)
    {
        if (word1.Length != word2.Length)
        {
            return false;
        }

        if( word1.Except(word2).Any() || word2.Except(word1).Any() )
        {
            return false;
        }

        var word1C = word1
            .GroupBy(c => c)
            .Select(g => g.Count())
            .OrderBy(n => n);

        var word2C = word2
            .GroupBy(c => c)
            .Select(g => g.Count())
            .OrderBy(n => n);

        return word1C.SequenceEqual(word2C);
    }
}
