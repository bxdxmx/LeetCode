public class Solution
{
    // 文字列の長さが奇数の場合：各文字の個数が奇数1個、残りがすべて偶数になればOK
    // 文字列の長さが偶数の場合：各文字の個数が全て偶数になればOK

    public int LongestPalindrome(string s)
    {
        var d = new Dictionary<char, int>();

        s.ToList().ForEach(c =>
        {
            if (d.ContainsKey(c))
            {
                d[c]++;
            }
            else
            {
                d[c] = 1;
            }
        });

        int oddCount = d.Values.Select(n => n & 1).Sum();

        return s.Length - (oddCount > 0 ? oddCount - 1 : 0);
    }
}
