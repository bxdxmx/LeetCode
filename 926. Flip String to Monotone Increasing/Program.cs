public class Solution
{
    public int MinFlipsMonoIncr(string s)
    {
        int ans = 0, num = 0;

        for (int i = 0; i < s.Length; ++i)
        {
            if (s[i] == '0')
            {
                ans = Math.Min(num, ans + 1);
            }
            else
            {
                ++num;
            }
        }
        return ans;
    }
}
