Console.WriteLine(new Solution().HalvesAreAlike("book"));
Console.WriteLine(new Solution().HalvesAreAlike("textbook"));


public class Solution
{
    public bool HalvesAreAlike(string s)
    {
        var a = s.Substring(0, s.Length / 2).ToLower().ToArray();
        var b = s.Substring(s.Length / 2).ToLower().ToArray();
        var vowels = new char[] { 'a', 'e', 'i', 'o', 'u' };

        return a.Count(c => vowels.Contains(c)) == b.Count(c => vowels.Contains(c));
    }
}
