var s = new Solution();

Console.WriteLine(s.IsPalindrome(121));


public class Solution
{
    public bool IsPalindrome(int x)
    {
        var xs = x.ToString();
        return xs == new string(xs.Reverse().ToArray());
    }
}
