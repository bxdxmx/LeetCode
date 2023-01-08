var s = new Solution();

string w1 = "aab";
string w2 = "abcc";

s.IsItPossible(w1, w2);

public class Solution
{
    public bool IsItPossible(string word1, string word2)
    {
        Dictionary<char, int> d1 = word1.ToCharArray().GroupBy(c => c).ToDictionary(g => g.Key, g => g.Count());
        Dictionary<char, int> d2 = word2.ToCharArray().GroupBy(c => c).ToDictionary(g => g.Key, g => g.Count());
        (var dBig, var dSmall) = d1.Keys.Count > d2.Keys.Count ? (d1, d2) : (d2, d1);

        if (dBig.Keys.Count - dSmall.Keys.Count >= 3)
        {
            return false;
        }
        else if (dBig.Keys.Count - dSmall.Keys.Count == 2)
        {
            foreach (char c in dBig.Where( d => d.Value == 1).Select(d => d.Key))
            {
                if (!dSmall.ContainsKey(c))
                {
                    foreach (char c2 in dSmall.Where(d => d.Value >= 2).Select(d => d.Key))
                    {
                        if (dBig.ContainsKey(c2))
                        {
                            return true;
                        }
                    }
                }
            }
        }
        else if (dBig.Keys.Count - dSmall.Keys.Count == 1)
        {
            foreach (char c in dBig.Where(d => d.Value >= 2).Select(d => d.Key))
            {
                if (!dSmall.ContainsKey(c))
                {
                    foreach (char c2 in dSmall.Where(d => d.Value >= 2).Select(d => d.Key))
                    {
                        if (dBig.ContainsKey(c2))
                        {
                            return true;
                        }
                    }
                }
            }

            foreach (char c in dBig.Where(d => d.Value == 1).Select(d => d.Key))
            {
                if (!dSmall.ContainsKey(c))
                {
                    foreach (char c2 in dSmall.Where(d => d.Value >= 2).Select(d => d.Key))
                    {
                        if (!dBig.ContainsKey(c2))
                        {
                            return true;
                        }
                    }
                }
            }

            foreach (char c in dBig.Where(d => d.Value == 1).Select(d => d.Key))
            {
                if (!dSmall.ContainsKey(c))
                {
                    foreach (char c2 in dSmall.Where(d => d.Value == 1).Select(d => d.Key))
                    {
                        if (dBig.ContainsKey(c2))
                        {
                            return true;
                        }
                    }
                }
            }
        }
        else
        {
            foreach (char c in dBig.Where(d => d.Value >= 2).Select(d => d.Key))
            {
                if (dSmall.ContainsKey(c))
                {
                    return true;
                }
                else
                {
                    foreach (char c2 in dSmall.Where(d => d.Value >= 2).Select(d => d.Key))
                    {
                        if (!dBig.ContainsKey(c2))
                        {
                            return true;
                        }
                    }
                }
            }

            foreach (char c in dBig.Where(d => d.Value == 1).Select(d => d.Key))
            {
                if (dSmall.ContainsKey(c))
                {
                    return true;
                }
                else
                {
                    foreach (char c2 in dSmall.Where(d => d.Value == 1).Select(d => d.Key))
                    {
                        if (!dBig.ContainsKey(c2))
                        {
                            return true;
                        }
                    }
                }
            }
        }

        return false;
    }
}
