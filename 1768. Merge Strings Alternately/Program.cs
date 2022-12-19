using System.Text;

public class Solution
{
    public string MergeAlternately(string word1, string word2)
    {
        int i = 0, j = 0;
        bool flag = true;
        var sb = new StringBuilder();

        while (i < word1.Length || j < word2.Length)
        {
            if (flag)
            {
                sb.Append(word1[i++]);

                if (j < word2.Length)
                {
                    flag = !flag;
                }
            }
            else
            {
                sb.Append(word2[j++]);
                if (i < word1.Length)
                {
                    flag = !flag;
                }
            }
        }

        return sb.ToString();
    }
}
