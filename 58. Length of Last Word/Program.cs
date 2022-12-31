public class Solution
{
    public int LengthOfLastWord(string s)
    {
        return s.TrimEnd().Split(' ')[^1].Length;
    }
}
