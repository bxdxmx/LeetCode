var s = new Solution();
s.WordBreak("aaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaab",
    new List<string>() { "a", "aa", "aaa", "aaaa", "aaaaa", "aaaaaa", "aaaaaaa", "aaaaaaaa", "aaaaaaaaa", "aaaaaaaaaa" });


public class Solution
{
    // 取り得る値のインデックスを記録しておいて、前から見ていって、最後まで行ければOK

    public bool WordBreak(string s, IList<string> wordDict)
    {
        var q = new PriorityQueue<int, int>();
        var used = new HashSet<int>();
        q.Enqueue(0, 0);

        while (q.Count > 0)
        {
            int i = q.Dequeue();

            if (i == s.Length)
            {
                return true;
            }

            foreach( var word in wordDict)
            {
                int to = i + word.Length;

                if (to <= s.Length && s[i..to] == word)
                {
                    if (!used.Contains(to))
                    {
                        q.Enqueue(to, int.MaxValue - to);
                        used.Add(to);
                    }
                }
            }
        }

        return false;
    }
}
