var s = new Solution();


Console.WriteLine(s.IsCircularSentence("leetcode exercises sound delightful"));
Console.WriteLine(s.IsCircularSentence("eetcode"));
Console.WriteLine(s.IsCircularSentence("Leetcode is cool"));

public class Solution
{
    public bool IsCircularSentence(string sentence)
    {
        var words = sentence.Split(' ');

        for (int i = 0; i < words.Length; i++)
        {
            var s1 = words[i];
            var s2 = words[(i + 1) % words.Length];

            if (s1[^1] != s2[0])
            {
                return false;
            }
        }

        return true;
    }
}
