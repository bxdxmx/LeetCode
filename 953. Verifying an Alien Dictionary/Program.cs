public class Solution
{
    public bool IsAlienSorted(string[] words, string order)
    {
        int p = 0;
        var d = new Dictionary<char, int>();

        foreach( var c in order)
        {
            d[c] = p++;
        }

        bool Check(string word1, string word2)
        {
            int i = 0;

            while (i < word1.Length && i < word2.Length)
            {
                char c1 = word1[i];
                char c2 = word2[i];

                if (d[c1] > d[c2])
                {
                    return false;
                }
                else if (d[c1] < d[c2])
                {
                    return true;
                }

                i++;
            }

            return word1.Length <= word2.Length;
        }

        for (int i = 1; i < words.Length; i++)
        {
            var word1 = words[i - 1];
            var word2 = words[i];

            if(!Check(word1,word2))
            {
                return false;
            }
        }

        return true;
    }
}
