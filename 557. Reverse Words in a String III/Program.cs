var s = new Solution();

Console.WriteLine(s.ReverseWords("Let's take LeetCode contest"));

public class Solution
{
    public string ReverseWords(string s)
    {
        return string.Join(" ",
            s.Split(' ').Select(str => new string(str.Reverse().ToArray())));
    }
}
