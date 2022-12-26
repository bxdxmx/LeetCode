public class Solution
{
    public IList<string> TopKFrequent(string[] words, int k)
    {
        Dictionary<string, int> d = new();

        foreach (string word in words)
        {
            if (d.ContainsKey(word))
            {
                d[word]++;
            }
            else
            {
                d[word] = 1;
            }
        }

        return d
            .OrderByDescending(d => d.Value)
            .ThenBy(d => d.Key)
            .Select(d => d.Key)
            .Take(k)
            .ToList();
    }
}
