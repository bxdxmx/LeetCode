using System.Text;

var s = new Solution();

Console.WriteLine(s.FrequencySort("tree"));
Console.WriteLine(s.FrequencySort("cccaaa"));
Console.WriteLine(s.FrequencySort("Aabb"));

public class Solution
{
    public string FrequencySort(string s)
    {
        var d = new Dictionary<char, int>();
        foreach (var c in s)
        {
            if (d.ContainsKey(c))
            {
                d[c]++;
            }
            else
            {
                d.Add(c, 1);
            }
        }

        var sortedD = d
//            .Select( i => new { i.Key, i.Value })
            .OrderByDescending(i => i.Value)
            ;

        var sb = new StringBuilder();

        foreach (var item in sortedD)
        {
            sb.Append(new string(item.Key, item.Value));
        }

        return sb.ToString();
    }
}
