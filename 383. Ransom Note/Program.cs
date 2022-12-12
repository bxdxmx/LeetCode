var s = new Solution();

Console.WriteLine(s.CanConstruct("a", "b"));
Console.WriteLine(s.CanConstruct("aa", "ab"));
Console.WriteLine(s.CanConstruct("aa", "aab"));
Console.WriteLine(s.CanConstruct("bg", "efjbdfbdgfjhhaiigfhbaejahgfbbgbjagbddfgdiaigdadhcfcj"));

public class Solution
{
    public bool CanConstruct(string ransomNote, string magazine)
    {
        var a = new int[26];

        foreach(var c in ransomNote)
        {
            a[(int)c - 97]--;
        }

        foreach (var c in magazine)
        {
            a[(int)c - 97]++;
        }

        for( int i = 0; i < 26; ++i )
        {
            if(a[i] < 0)
            {
                return false;
            }
        }

        return true;
    }
}