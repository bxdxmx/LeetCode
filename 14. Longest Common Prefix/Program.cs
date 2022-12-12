public class Solution
{
    public string LongestCommonPrefix(string[] strs)
    {
        int length = strs.Select(str => str.Length).Min();

        for (int j = 0; j < length; j++)
        {
            char c = strs[0][j];

            for (int i = 1; i < strs.Length; i++)
            {
                if (c != strs[i][j])
                {
                    return strs[0][..j];
                }
            }
        }

        return strs[0][..length];
    }
}
