public class Solution
{
    public bool WordPattern(string pattern, string s)
    {
        string[] pattern2 = s.Split(' ').ToArray();

        if (pattern.Length != pattern2.Length)
        {
            return false;
        }

        Dictionary<char, string> bi = new();
        Dictionary<string, char> bi2 = new();

        for (int i = 0; i < pattern.Length; i++)
        {
            if ((bi.ContainsKey(pattern[i]) && bi[pattern[i]] != pattern2[i]) ||
                (bi2.ContainsKey(pattern2[i]) && bi2[pattern2[i]] != pattern[i]))
            {
                return false;
            }
            else
            {
                bi[pattern[i]] = pattern2[i];
                bi2[pattern2[i]] = pattern[i];
            }
        }

        return true;
    }
}
