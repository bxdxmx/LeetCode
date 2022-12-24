var s = new Solution();

s.CharacterReplacement("ABAA", 0);

public class Solution
{
    /*
     * 順番にみていくとO(n^2)
     * 遅いけどクリア
     */
    public int CharacterReplacement(string s, int k)
    {
        int m = 1;

        for (int i = 0; i < s.Length - k; i++)
        {
            int n = k;
            int j = 1;

            while (j < s.Length)
            {
                int index = i + j < s.Length ? j : -1 - Math.Abs(i + j - s.Length);

                if (n == 0 && s[i] != s[i+index])
                {
                    break;
                }

                if (s[i] != s[i + index])
                {
                    n--;
                }

                j++;
            }

            m = Math.Max(m, j);
            if (m == s.Length)
            {
                return m;
            }
        }

        for (int i = s.Length - 1; i >= k; i--)
        {
            int n = k;
            int j = -1;

            while (j > -s.Length)
            {
                int index = i + j >= 0 ? j : Math.Abs(i + j);

                if (n == 0 && s[i] != s[i + index])
                {
                    break;
                }

                if (s[i] != s[i + index])
                {
                    n--;
                }

                j--;
            }

            m = Math.Max(m, -j);
            if (m == s.Length)
            {
                return m;
            }
        }

        return m;
    }
}
