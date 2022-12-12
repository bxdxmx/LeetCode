var s = new Solution();

Console.WriteLine(s.IsMatch("aa", "a"));
Console.WriteLine(s.IsMatch("aa", "a*"));
Console.WriteLine(s.IsMatch("ab", ".*"));
Console.WriteLine(s.IsMatch("ab", "a*ab"));
Console.WriteLine(s.IsMatch("ab", "c*ab"));
Console.WriteLine(s.IsMatch("ab", ".*ab"));
Console.WriteLine(s.IsMatch("ab", ".*"));
Console.WriteLine(s.IsMatch("aab", "c*a*b"));
Console.WriteLine(s.IsMatch("aaa", "a*a"));


public class Solution
{
    public bool IsMatch(string s, string p)
    {
        if (string.IsNullOrEmpty(p))
        {
            return string.IsNullOrEmpty(s);
        }

        if (p.Length > 1 && p[1] == '*')
        {
            return IsMatch(s, p[2..]) ||
                (!string.IsNullOrEmpty(s) && (p[0] == '.' || s[0] == p[0]) &&
                IsMatch(s[1..], p));
        }
        else
        {
            return !string.IsNullOrEmpty(s) && (p[0] == '.' || s[0] == p[0]) &&
                IsMatch(s[1..], p[1..]);
        }
    }

    // *の対象は最大とるのでは駄目だった。なので、再帰か動的計画法で対処する必要がある。
    //public bool IsMatch(string s, string p)
    //{
    //    int si = 0, pi = 0;
    //    char prev = '_';

    //    while (si < s.Length && pi < p.Length)
    //    {
    //        if (p[pi] == '.' || p[pi] == s[si])
    //        {
    //            prev = p[pi];
    //            pi++;
    //            si++;
    //        }
    //        else if (p[pi] == '*')
    //        {
    //            while (si < s.Length)
    //            {
    //                if (prev == '.' || prev == s[si])
    //                {
    //                    si++;
    //                }
    //                else
    //                {
    //                    break;
    //                }
    //            }

    //            prev = '_';
    //            pi++;
    //        }
    //        else if (pi + 1 < p.Length && p[pi + 1] == '*')
    //        {
    //            pi += 2;
    //        }
    //        else
    //        {
    //            break;
    //        }
    //    }

    //    if (si == s.Length && pi == p.Length)
    //    {
    //        return true;
    //    }
    //    else
    //    {
    //        return false;
    //    }
    //}
}
