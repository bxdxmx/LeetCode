var s = new Solution();

Console.WriteLine(s.LengthOfLongestSubstring("abcabcbb"));
Console.WriteLine(s.LengthOfLongestSubstring("bbbbb"));
Console.WriteLine(s.LengthOfLongestSubstring("pwwkew"));

public class Solution
{
    public int LengthOfLongestSubstring(string s)
    {
        if (string.IsNullOrEmpty(s))
        {
            return 0;
        }

        var charSet = new HashSet<char>();
        int maxLength = 1;
        int startIndex = 0;
        int currentLength = 0;

        while(startIndex + currentLength < s.Length)
        {
            var nextChar = s[startIndex + currentLength];

            if (!charSet.Contains(nextChar))
            {
                charSet.Add(nextChar);
                currentLength++;
                maxLength = Math.Max(maxLength, currentLength);
            }
            else
            {
                while (true)
                {
                    charSet.Remove(s[startIndex++]);
                    currentLength--;

                    if (!charSet.Contains(nextChar))
                    {
                        charSet.Add(nextChar);
                        currentLength++;
                        break;
                    }
                }
            }
        }

        return maxLength;
    }
}
